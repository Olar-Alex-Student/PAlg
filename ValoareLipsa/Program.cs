using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoareLipsa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CitireFisier();
        }

        static int ValoareLipsa(int nrElemente, int[] elemente)
        {
            int sumaNrElemente = 0;
            int sumaElementente = 0;

            for(int i = 0; i <= nrElemente; i++)
            {
                sumaNrElemente += i;
            }

            for(int i = 0; i < elemente.Length; i++)
            {
                sumaElementente += elemente[i];
            }

            return sumaNrElemente-sumaElementente;
        }

        static void CitireFisier()
        {
            StreamReader streamReader = new StreamReader("Citire.txt");

            StreamWriter streamWriter = new StreamWriter("Scriere1.txt");

            var _for = streamReader.ReadLine();

            for(int i = 0; i < int.Parse(_for); i++)
            {
                var nrElemente = streamReader.ReadLine();
                var elemente = streamReader.ReadLine().Split(' ');

                var elementeInt = new int[elemente.Length];

                for(int j=0; j < elemente.Length; j++)
                {
                    elementeInt[j] = int.Parse(elemente[j]);
                }

                var result = ValoareLipsa(int.Parse(nrElemente), elementeInt);

                streamWriter.WriteLine(result);
            }

            streamWriter.WriteLine("Hello");

            streamWriter.Close();

        }
    }
}
