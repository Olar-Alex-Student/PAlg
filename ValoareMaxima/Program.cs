using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoareMaxima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fisier();
        }

        static int ValoareMaxima(int nrElemente, int[] elemente)
        {
            int valMaxima = elemente[0];

            foreach(var e in elemente)
            {
                if(valMaxima < e) 
                {
                    valMaxima = e;
                }
            }

            return valMaxima;
        }

        static void Fisier()
        {
            StreamReader sr = new StreamReader("Citire.txt");
            StreamWriter sw = new StreamWriter("Scriere.txt");

            var _for = sr.ReadLine();

            for (int i = 0; i < int.Parse(_for); i++)
            {
                var nrElemente = sr.ReadLine();
                var elemente = sr.ReadLine().Split(' ');

                var elementeInt = new int[elemente.Length];

                for (int j=0;  j < elemente.Length; j++)
                {
                    elementeInt[j] = int.Parse(elemente[j]);
                }

                var result = ValoareMaxima(int.Parse(nrElemente), elementeInt);

                sw.WriteLine(result);
            }

            sw.Close();
        }

    }
}
