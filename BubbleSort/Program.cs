using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fisier();
        }

        static int[] BubbleSort(int nrElemente, int[] elemente)
        {
            bool sortat = false;
            do
            {
                sortat = true;

                for(int i = 0; i <= nrElemente-2; i++)
                {
                    if (elemente[i] > elemente[i+1])
                    {
                        int aux = elemente[i];
                        elemente[i] = elemente[i+1];
                        elemente[i+1] = aux;

                        sortat = false;
                    }
                }
            }
            while (!sortat);

            return elemente;
        }

        static void Fisier()
        {
            StreamReader streamReader = new StreamReader("Citire.txt");
            StreamWriter streamWriter = new StreamWriter("Scriere.txt");

            var _for = streamReader.ReadLine();

            for(int i=0; i<int.Parse(_for);i++)
            {
                var nrElemente = streamReader.ReadLine().Trim();
                var elemente = streamReader.ReadLine().Split(' ');

                var elementeInt = new int[elemente.Length];

                for(int j = 0; j < elemente.Length; j++)
                {
                    elementeInt[j] = int.Parse(elemente[j]);
                }

                var result = BubbleSort(int.Parse(nrElemente), elementeInt);

                foreach(var r in result)
                {
                    streamWriter.WriteLine(r.ToString());
                }

                streamWriter.WriteLine('\n');
            }

            streamWriter.Close();
        }
    }
}
