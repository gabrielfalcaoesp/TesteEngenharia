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

            Block.FilterValues(blocks);



            //_______________________ código para identificar parede ___________________

            Dictionary<int, List<string>> paredes = new Dictionary<int, List<string>>();
            paredes.Add(-1, new List<string>());  // Inicializa com uma lista vazia para a chave -1
            int paredeAtual = -1;

            for (int i = 1; i < blocks.Count; i++)
            {
                string blocoAtual = blocks[i];
                string blocoAnterior = blocks[i - 1];

                int segundoValorAtual = ExtrairSegundoValor(blocoAtual);
                int segundoValorAnterior = ExtrairSegundoValor(blocoAnterior);

                if (segundoValorAtual != segundoValorAnterior)
                {
                    paredeAtual++;
                    paredes.Add(paredeAtual, new List<string>());
                }

                paredes[paredeAtual].Add(blocoAtual);
            }

            foreach (var par in paredes)
            {
                int numeroParede = par.Key;
                List<string> blocosDaParede = par.Value;
                
            }
            Console.WriteLine(paredes);
        }

        static int ExtrairSegundoValor(string bloco)
        {
            string[] partes = bloco.Split('|');
            if (partes.Length >= 2 && int.TryParse(partes[1], out int segundoValor))
            {
                return segundoValor;
            }
            return -1; 
        }
    }
}

    