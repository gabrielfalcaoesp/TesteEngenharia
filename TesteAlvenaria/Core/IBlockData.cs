using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAlvenaria.Core;

internal interface IBlockData
{
    int WallPosition { get; }
    int Height { get; }
    int Length { get; }
    int Elevation { get; }
}

public class Block : IBlockData
{

    public int WallPosition { get; set; }
    public int Height { get; set; }
    public int Length { get; set; }
    public int Elevation { get; set; }

    public Block (int wallPosition, int height, int length)
    {
        WallPosition = wallPosition;
        Height = 20;
        Length = length;
    }

    public static void FilterValues(List<string> blocks)
    {
        List<Block> blocksList = new List<Block>();
        foreach (string block in blocks)
        {

        }
    }
}