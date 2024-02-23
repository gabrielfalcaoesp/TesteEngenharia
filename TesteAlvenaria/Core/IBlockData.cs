using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAlvenaria.Teste;

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

    public Block (int wallPosition, int length)
    {
        WallPosition = wallPosition;
        Height = 20;
        Length = length;
    }

    public static void FilterValues(List<string> blocks)
    {
        
        List<int> listWallPosition = new List<int>();
        List<int> listLength = new List<int>();
        for (int i = 0; i < blocks.Count; i++)
        {
            int wallPosition = DataProcessing.ExtrairValor(blocks[i],3);
            listWallPosition.Add(wallPosition);
        }

        for (int i = 0; i < blocks.Count; i++)
        {
            int length = DataProcessing.ExtrairValor(blocks[i], 1);
            listLength.Add(length);
        }
    }
}