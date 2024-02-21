using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAlvenaria.Teste
{
    internal class DataProcessing
    {
        public void BlockOrOpening(string[] linesFile)
        {
            List<string> resultado = new List<string>();

            foreach (string str in arrayDeStrings)
            {

                string[] partes = str.Split(' ');

                resultado.AddRange(partes);
            }
        }
    }
}
