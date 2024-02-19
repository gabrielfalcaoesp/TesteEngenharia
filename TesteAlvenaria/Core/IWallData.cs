using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAlvenaria.Core;

internal interface IWallData
{
    string Name { get; }
    int PointX { get; }
    int PointY { get; }
    int Angle { get; }
    int Width { get; }
    int Length { get; }
    List<IBlockData> Blocks { get; }
    List<IOpeningData> Openings { get; }
}
