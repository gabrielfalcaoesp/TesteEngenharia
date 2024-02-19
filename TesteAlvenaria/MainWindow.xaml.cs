using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TesteAlvenaria.Core;
using TesteAlvenaria.Libs;

namespace TesteAlvenaria
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Variables and Properties

        MainWindowModel _model = new MainWindowModel();

        double _scale = 1.0;
        double _minX = 0.0;
        double _maxY = 0.0;
        double _posX = 0.0;
        double _posY = 0.0;

        #endregion

        #region Constructors

        public MainWindow()
        {
            InitializeComponent();
            DataContext = _model;
            _model.PropertyChanged += VM_PropertyChanged;
        }

        #endregion

        #region Events

        private void VM_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(_model.SelectedWall)) DrawPreview();
        }

        private void cnv_preview_SizeChanged(object sender, SizeChangedEventArgs e) => DrawPreview();

        #endregion

        #region Functions

        #endregion

        #region Draw functions

        public void DrawPreview()
        {
            cnv_preview.Children.Clear();
            if (cnv_preview.ActualHeight == 0 || cnv_preview.ActualWidth == 0)
                return;
            if (_model.Walls.Count == 0)
                return;
            if (_model.SelectedWall == null)
                DrawFirstRow();
        }

        private void DrawFirstRow()
        {
            SetScaleFirstRow();
            var rects = new List<RectGeometry>();
            _model.Walls.ForEach(w => rects.Add(new RectGeometry(w.PointX, w.PointY, w.Length, w.Width, w.Angle)));
            //rects.ForEach(r => DrawRect(r, 1));
            foreach (var wall in _model.Walls)
            {
                var blocks = wall.Blocks.FindAll(bl => bl.Elevation == _model.ShowRow);
                blocks.ForEach(bl => DrawBlockFR(wall, bl));
                wall.Openings.ForEach(op => DrawOpeningFR(wall, op));
            }
        }

        private void DrawBlockFR(IWallData wall, IBlockData bl)
        {
            var posBlock = UtilsGeometry.PolarPoint(wall.PointX, wall.PointY, bl.WallPosition, wall.Angle);
            var rectBlock = new RectGeometry(posBlock.Item1, posBlock.Item2, bl.Length, 20, wall.Angle);
            DrawRect(rectBlock, 2);
            var posHole = UtilsGeometry.PolarPoint(posBlock.Item1, posBlock.Item2, 3, wall.Angle);
            posHole = UtilsGeometry.PolarPoint(posHole.Item1, posHole.Item2, 3, wall.Angle + 90);
            var rectHole = new RectGeometry(posHole.Item1, posHole.Item2, 14, 14, wall.Angle);
            DrawRect(rectHole, 3);
            if (bl.Length < 30)
                return;
            posHole = UtilsGeometry.PolarPoint(posHole.Item1, posHole.Item2, 20, wall.Angle);
            rectHole = new RectGeometry(posHole.Item1, posHole.Item2, 14, 14, wall.Angle);
            DrawRect(rectHole, 3);
        }

        private void DrawOpeningFR(IWallData wall, IOpeningData op)
        {
            var posOpening = UtilsGeometry.PolarPoint(wall.PointX, wall.PointY, op.WallPosition, wall.Angle);
            var rectOpening = new RectGeometry(posOpening.Item1, posOpening.Item2, op.Length, 20, wall.Angle);
            if (op.Elevation == 0)
            {
                DrawRect(rectOpening, 4);
                var posDoor = UtilsGeometry.PolarPoint(posOpening.Item1, posOpening.Item2, 9, wall.Angle + 90);
                var rectDoor = new RectGeometry(posDoor.Item1, posDoor.Item2, op.Length, 2, wall.Angle);
                DrawRect(rectDoor, 4);
            }
            else
            {
                DrawRect(rectOpening, 5);
                var posWindow = UtilsGeometry.PolarPoint(posOpening.Item1, posOpening.Item2, 5, wall.Angle + 90);
                var rectWindow = new RectGeometry(posWindow.Item1, posWindow.Item2, op.Length, 10, wall.Angle);
                DrawRect(rectWindow, 5);
            }
        }

        private void SetScaleFirstRow()
        {
            var h = cnv_preview.ActualHeight;
            var w = cnv_preview.ActualWidth;
            var rects = new List<RectGeometry>();
            _model.Walls.ForEach(w => rects.Add(new RectGeometry(w.PointX, w.PointY, w.Length, w.Width, w.Angle)));

            _minX = rects.Min(r => r.GetMinX());
            var maxX = rects.Max(r => r.GetMaxX());
            var minY = rects.Min(r => r.GetMinY());
            _maxY = rects.Max(r => r.GetMaxY());

            var scaleX = w / ((maxX - _minX) * 1.1);
            var scaleY = h / ((_maxY - minY) * 1.1);

            _scale = Math.Min(scaleX, scaleY);

            _posX = (w - _scale * (maxX - _minX)) / 2.0;
            _posY = (h - _scale * (_maxY - minY)) / 2.0;
        }

        private void DrawRect(RectGeometry rect, int type)
        {
            var rectangle = new Rectangle();
            rectangle.Width = (rect.GetMaxX() - rect.GetMinX()) * _scale;
            rectangle.Height = (rect.GetMaxY() - rect.GetMinY()) * _scale;
            rectangle.Stroke = GetStrokeBlock(type);
            var left = (rect.GetMinX() - _minX) * _scale;

            var top = (_maxY - rect.GetMaxY()) * _scale;
            Canvas.SetLeft(rectangle, _posX + left); // Posicionamento horizontal
            Canvas.SetTop(rectangle, _posY + top); // Posicionamento vertical

            cnv_preview.Children.Add(rectangle);
        }

        private static Brush GetStrokeBlock(int type)
        {
            if (type == 2)
                return Brushes.Blue;
            if (type == 3)
                return Brushes.LightBlue;
            if (type == 4)
                return Brushes.Red;
            if (type == 5)
                return Brushes.Orange;
            return Brushes.Black;
        }

        #endregion

    }
}
