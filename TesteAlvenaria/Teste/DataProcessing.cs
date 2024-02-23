using System;
using System.Collections.Generic;
using TesteAlvenaria.Core;

namespace TesteAlvenaria.Teste
{
    internal class DataProcessing
    {
        public void BlockOrOpening(string[] linesFile)
        {
            List<string> blocks = new List<string>();
            List<string> windows = new List<string>();
            List<string> doors = new List<string>();
            Dictionary<int, List<string>> paredes = new Dictionary<int, List<string>>();

            foreach (string str in linesFile)
            {
                if (str.StartsWith("bloco", StringComparison.OrdinalIgnoreCase))
                {
                    int indiceEspaco = str.IndexOf(' ');
                    string blocoSemPrimeiraPalavra = indiceEspaco >= 0 ? str.Substring(indiceEspaco + 1) : str;
                    blocks.Add(blocoSemPrimeiraPalavra);
                }

                if (str.StartsWith("Janela", StringComparison.OrdinalIgnoreCase))
                {
                    int indiceEspaco = str.IndexOf(' ');
                    string blocoSemPrimeiraPalavra = indiceEspaco >= 0 ? str.Substring(indiceEspaco + 1) : str;
                    windows.Add(blocoSemPrimeiraPalavra);
                }

                if (str.StartsWith("porta", StringComparison.OrdinalIgnoreCase))
                {
                    int indiceEspaco = str.IndexOf(' ');
                    string blocoSemPrimeiraPalavra = indiceEspaco >= 0 ? str.Substring(indiceEspaco + 1) : str;
                    doors.Add(blocoSemPrimeiraPalavra);
                }
            }

            BlockFilter.FilterValues(blocks);
            OpeningFilter.FilterValues(windows, "Windows");
            OpeningFilter.FilterValues(doors, "Doors");
           
            


            //_______________________ código para identificar parede ___________________

            
            paredes.Add(1, new List<string>());  
            int paredeAtual = 1;

            for (int i = 1; i < blocks.Count; i++)
            {
                string blocoAtual = blocks[i];
                string blocoAnterior = blocks[i - 1];

                int segundoValorAtual = ExtrairValor(blocoAtual, 2);
                int segundoValorAnterior = ExtrairValor(blocoAnterior, 2);

                if (segundoValorAtual != segundoValorAnterior)
                {
                    paredeAtual++;
                    paredes.Add(paredeAtual, new List<string>());
                }

                paredes[paredeAtual].Add(blocoAtual);
            }

            
            paredes[1].Add(blocks[1]);
            Console.WriteLine(paredes);
            WallFilter.FilterValues(blocks, paredes);
        }

        public static int ExtrairValor(string bloco, int valor)
        {
            string[] partes = bloco.Split('|');
            if (partes.Length >= valor && int.TryParse(partes[valor-1], out int valorExtraido))
            {
                return valorExtraido;
            }
            return -1; 
        }
    }
}

    