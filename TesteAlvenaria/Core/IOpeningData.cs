using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using TesteAlvenaria.Teste;

namespace TesteAlvenaria.Core;

internal interface IOpeningData
{
    int WallPosition { get; }
    int Height { get; }
    int Length { get; }
    int Elevation { get; }
}

public class Opening : IOpeningData
{

    public int WallPosition { get; set; }
    public int Height { get; set; }
    public int Length { get; set; }
    public int Elevation { get; set; }

    public Opening(int wallPosition, int height, int length)
    {
        WallPosition = wallPosition;
        Height = 20;
        Length = length;
        Elevation = 0;
    }

    public Opening(int wallPosition, int height, int length, int elevation)
    {
        WallPosition = wallPosition;
        Height = height;
        Length = length;
        Elevation = elevation;
    }

    public static void FilterValues(List<string> opening, string windownOrDoor)
    {
        List<int> listWallPosition = new List<int>();
        List<int> listLength = new List<int>();
        List<int> listHeight = new List<int>();
        List<int> listElevation = new List<int>();

        {
            for (int i = 0; i < opening.Count; i++)
            {
                int wallPosition = DataProcessing.ExtrairValor(opening[i], 4);
                listWallPosition.Add(wallPosition);
            }

            for (int i = 0; i < opening.Count; i++)
            {
                int length = DataProcessing.ExtrairValor(opening[i], 1);
                listLength.Add(length);
            }

            for (int i = 0; i < opening.Count; i++)
            {
                int height = DataProcessing.ExtrairValor(opening[i], 2);
                listHeight.Add(height);
            }

            if (windownOrDoor == "windowns")
            {
                for (int i = 0; i < opening.Count; i++)
                {
                    int elevation = DataProcessing.ExtrairValor(opening[i], 3);
                    listElevation.Add(elevation);
                }
            }
            else
            {
                int elevation = 0;
                listElevation.Add(elevation);
            }

        }
    }
}
