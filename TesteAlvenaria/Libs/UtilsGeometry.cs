using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TesteAlvenaria.Libs;

internal class UtilsGeometry
{
    public static Tuple<int, int> RetangularPoint(int x, int y, int addX, int addY) => new Tuple<int, int>(x + addX, y + addY);

    public static Tuple<int, int> PolarPoint(int x, int y, int length, int angle) => 
        new Tuple<int, int>(x + (int)(length * Math.Cos(GetRadAngle(angle))),
                            y + (int)(length * Math.Sin(GetRadAngle(angle))));

    public static double GetRadAngle(int angle) => Math.PI * angle / 180.0;
}
