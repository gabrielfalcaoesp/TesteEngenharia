using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAlvenaria.Libs;

internal class RectGeometry
{
    #region Variables and Properties

    public int PointX { get; }
    public int PointY { get; }
    public int Length { get; }
    public int Width { get; }
    public int Angle { get; }

    #endregion

    #region Constructors

    public RectGeometry(int pointX, int pointY, int length, int width, int angle)
    {
        PointX = pointX;
        PointY = pointY;
        Length = length;
        Width = width;
        Angle = angle;
    }

    public RectGeometry(int pointX, int pointY, int length, int width)
        : this (pointX, pointY, length, width, 0)
    { }

    #endregion

    #region Functions

    private double GetRadAngle() => UtilsGeometry.GetRadAngle(Angle);

    public int GetMinX()
    {
        var radAngle = GetRadAngle();

        // Calcular as coordenadas dos vértices do retângulo
        var x1 = PointX + Length * Math.Cos(radAngle);
        var x2 = PointX + Width * Math.Cos(radAngle + Math.PI / 2);

        return (int)Math.Min(Math.Min(x1, x2), PointX);
    }

    public int GetMaxX()
    {
        var radAngle = GetRadAngle();

        // Calcular as coordenadas dos vértices do retângulo
        var x1 = PointX + Length * Math.Cos(radAngle);
        var x2 = PointX + Width * Math.Cos(radAngle + Math.PI / 2);

        return (int)Math.Max(Math.Max(x1, x2), PointX);
    }

    public int GetMinY()
    {
        var radAngle = GetRadAngle();

        // Calcular as coordenadas dos vértices do retângulo
        var x1 = PointY + Length * Math.Sin(radAngle);
        var x2 = PointY + Width * Math.Sin(radAngle + Math.PI / 2);

        return (int)Math.Min(Math.Min(x1, x2), PointY);
    }

    public int GetMaxY()
    {
        var radAngle = GetRadAngle();

        // Calcular as coordenadas dos vértices do retângulo
        var x1 = PointY + Length * Math.Sin(radAngle);
        var x2 = PointY + Width * Math.Sin(radAngle + Math.PI / 2);

        return (int)Math.Max(Math.Max(x1, x2), PointY);
    }

    #endregion
}
