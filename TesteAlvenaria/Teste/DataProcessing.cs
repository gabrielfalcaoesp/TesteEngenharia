using System;
using System.Collections.Generic;

namespace TesteAlvenaria.Teste
{
    internal class DataProcessing
    {
        public void BlockOrOpening(string[] linesFile)
        {
            List<string> blocks = new List<string>();
            List<string> windows = new List<string>();
            List<string> doors = new List<string>();

            foreach (string str in linesFile)
            {
                // Verifica se a string atual começa com "bloco" (insensível a maiúsculas e minúsculas)
                if (str.StartsWith("bloco", StringComparison.OrdinalIgnoreCase))
                {
                    blocks.Add(str);
                }

                if (str.StartsWith("Janela", StringComparison.OrdinalIgnoreCase))
                {
                    windows.Add(str);
                }

                if (str.StartsWith("porta", StringComparison.OrdinalIgnoreCase))
                {
                    doors.Add(str);
                }
            }

            Console.WriteLine(blocks.ToArray());
            Console.WriteLine(windows.ToArray());
            Console.WriteLine(doors.ToArray());
        }
    }
}
