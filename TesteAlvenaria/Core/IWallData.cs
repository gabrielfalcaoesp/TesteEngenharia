using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using System.Xml.Linq;
using TesteAlvenaria.Teste;

namespace TesteAlvenaria.Core;

internal interface IWallData
{
    string Name { get; }
    int PointX { get; }
    int PointY { get; }
    int Angle { get; }
    int Length { get; }
    List<Block> Blocks { get; }
    List<Opening> Openings { get; }
}


public class Wall : IWallData
{
    public string Name { get; }
    public int PointX { get; }
    public int PointY { get; }
    public int Angle { get; }
    public int Length { get; }
    public List<Block> Blocks { get; } = new List<Block>();
    public List<Opening> Openings { get; } = new List<Opening>();

    public Wall(string name, int pointX, int pointY, int angle, int length, List<Block> blocks, List<Opening> openings)
    {
        Name = name;
        PointX = pointX;
        PointY = pointY;
        Angle = angle;
        Length = length;
        Blocks = blocks;
        Openings = openings;
    }
}

public static class WallFilter
{
    public static List<Wall> FilterValues(List<string> blocks, Dictionary<int, List<string>> paredes)
    {
        List<Wall> listWall = new List<Wall>();
        int previousMaxValue = 0;
        foreach (KeyValuePair<int, List<string>> parede in paredes)
        {
            
            string name = "parede " + parede.Key;
            int pointX = parede.Value.Min(s => DataProcessing.ExtrairValor(s, 2));
            int pointY = parede.Value.Min(s => DataProcessing.ExtrairValor(s, 3));
            int angle = parede.Value.Min(s => DataProcessing.ExtrairValor(s, 4));
            int length = parede.Value.Max(s => DataProcessing.ExtrairValor(s, 3));

            int maxValue = parede.Value.Count;
            int minValue = previousMaxValue;


            List<string> sublist = parede.Value.GetRange(0, 13);
            List<Block> listBlocks = BlockFilter.FilterValues(sublist);
            
            Console.WriteLine(listBlocks);

            
        }

        return listWall;
    }


}
