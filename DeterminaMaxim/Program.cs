using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeterminaMaxim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fisier();
        }

        static int DeterminaMaxim(int[] elemente, int left, int right)
        {
            if(left == right)
            {
                return elemente[left];
            }

            var mid = (left + right) / 2;

            var max_1 = DeterminaMaxim(elemente, left, mid);
            var max_2 = DeterminaMaxim(elemente, mid + 1, right);

            return max_1 > max_2 ? max_1 : max_2;
        }

        static void Fisier()
        {
            StreamReader streamReader = new StreamReader("Citire.txt");
            StreamWriter streamWriter = new StreamWriter("Scriere.txt");

            var _for = streamReader.ReadLine();

            for(int i = 0; i < int.Parse(_for); i++)
            {
                var nrElemente = streamReader.ReadLine().Trim();
                var elemente = streamReader.ReadLine().Split(' ');

                var elementeInt = new int[elemente.Length];

                for(int j = 0; j < elemente.Length; j++)
                {
                    elementeInt[j] = int.Parse(elemente[j]);
                }

                var result = DeterminaMaxim(elementeInt, 0, int.Parse(nrElemente) - 1);

                streamWriter.WriteLine(result);
            }

            streamWriter.Close();
        }
    }
}
