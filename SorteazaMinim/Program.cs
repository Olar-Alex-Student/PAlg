using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorteazaMinim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fisier();
        }

        static int CautaMinim(int[] elemente, int left, int right)
        {
            int indexMinim = left;
            for(int i=left+1; i<=right; i++)
            {
                if (elemente[i] < elemente[indexMinim])
                {
                    indexMinim = i;
                }
            }

            return indexMinim;
        }

        static int[] SorteazaMinim(int nrElemente, int[]elemente)
        {
            for(int i=0; i<=nrElemente-2; i++) 
            {
                var indexMinim = CautaMinim(elemente, i, nrElemente - 1);
                if(i != indexMinim)
                {
                    var aux = elemente[i];
                    elemente[i] = elemente[indexMinim];
                    elemente[indexMinim] = aux;
                }
            }

            return elemente;
        }

        static void Fisier()
        {
            StreamReader streamReader = new StreamReader("Citeste.txt");
            StreamWriter streamWriter = new StreamWriter("Scrie.txt");

            var _for = streamReader.ReadLine();

            for(int i=0;i< int.Parse(_for); i++)
            {
                var nrElemente = streamReader.ReadLine().Trim();
                var elemente = streamReader.ReadLine().Split(' ');

                var elementeInt = new int[elemente.Length];

                for(int j = 0; j< elemente.Length; j++)
                {
                    elementeInt[j] = int.Parse(elemente[j]);
                }

                var result = SorteazaMinim(int.Parse(nrElemente), elementeInt);

                foreach(var r in result)
                {
                    streamWriter.WriteLine(r);
                }

                streamWriter.WriteLine("\n");
            }

            streamWriter.Close();
        }
    }
}
