using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAlvenaria.Core;

namespace TesteAlvenaria.Teste;

internal class Wall : IWallData
{
    public string Name { get; set; }
    public int PointX { get; set; }
    public int PointY { get; set; }
    public int Angle { get; set; }
    public int Width { get; set; }
    public int Length { get; set; }

    public List<IBlockData> Blocks { get; set; } = new List<IBlockData>();

    public List<IOpeningData> Openings { get; set; } = new List<IOpeningData>();
}

internal class Block : IBlockData
{
    public int WallPosition { get; set; }
    public int Height { get; set; }
    public int Length { get; set; }
    public int Elevation { get; set; }
}

internal class Opening : IOpeningData
{
    public int WallPosition { get; set; }
    public int Height { get; set; }
    public int Length { get; set; }
    public int Elevation { get; set; }
}


internal class MainTest
{
    public static List<IWallData> RunTest(string path)
    {
        return new List<IWallData>() { 
            new Wall() { 
                Name = "Test 01",
                PointX = 0,
                PointY = 0,
                Length = 560,
                Width = 20,
                Angle = 0,
                Blocks = new List<IBlockData>(){
                    new Block(){
                        WallPosition = 0,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 40,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 80,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 120,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 160,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 200,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 240,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 280,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 320,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 360,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 400,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 440,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 480,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 520,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 20,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 60,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 100,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 140,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 180,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 220,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 260,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 300,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 340,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 380,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 420,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 460,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 500,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                },
            },
            new Wall() {
                Name = "Test 02",
                PointX = 560,
                PointY = 0,
                Length = 360,
                Width = 20,
                Angle = 90,
                Blocks = new List<IBlockData>(){
                    new Block(){
                        WallPosition = 0,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 40,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 80,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 120,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 160,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 200,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 240,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 280,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 320,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 20,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 60,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 100,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 140,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 180,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 220,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 260,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 300,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                },
            },
            new Wall() {
                Name = "Test 03",
                PointX = 0,
                PointY = 340,
                Length = 560,
                Width = 20,
                Angle = 0,
                Blocks = new List<IBlockData>(){
                    new Block(){
                        WallPosition = 0,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 40,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 80,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 120,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 160,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 200,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 240,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 280,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 320,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 360,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 400,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 440,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 480,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 520,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 20,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 60,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 100,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 140,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 180,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 220,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 260,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 300,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 340,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 380,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 420,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 460,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 500,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                },
                Openings = new List<IOpeningData>(){
                    new Opening(){
                        WallPosition = 220,
                        Height = 120,
                        Length = 120,
                        Elevation = 100,
                    },
                },

            },
            new Wall() {
                Name = "Test 04",
                PointX = 20,
                PointY = 0,
                Length = 360,
                Width = 20,
                Angle = 90,
                Blocks = new List<IBlockData>(){
                    new Block(){
                        WallPosition = 0,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 40,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 80,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 120,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 160,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 200,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 240,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 280,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 320,
                        Height = 20,
                        Length = 40,
                        Elevation = 20,
                    },
                    new Block(){
                        WallPosition = 20,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 60,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 100,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 140,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 180,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 220,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 260,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                    new Block(){
                        WallPosition = 300,
                        Height = 20,
                        Length = 40,
                        Elevation = 0,
                    },
                },
                Openings = new List<IOpeningData>(){
                    new Opening(){
                        WallPosition = 20,
                        Height = 220,
                        Length = 80,
                        Elevation = 0,

                    },
                },
            },
        };
    }
}
