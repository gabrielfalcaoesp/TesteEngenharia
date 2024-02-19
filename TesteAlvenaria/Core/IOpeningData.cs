using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAlvenaria.Core;

internal interface IOpeningData
{
    int WallPosition { get; }
    int Height { get; }
    int Length { get; }
    int Elevation { get; }
}
