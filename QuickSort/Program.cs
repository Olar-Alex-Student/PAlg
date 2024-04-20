using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fisier();
        }

        static void QuickSort(int[] elemente, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = elemente[(i + j) / 2];

            do
            {
                if (elemente[i] < pivot)
                {
                    i++;
                }

                if (pivot < elemente[j])
                {
                    j--;
                }

                if (i <= j)
                {
                    var aux = elemente[i];
                    elemente[i] = elemente[j];
                    elemente[j] = aux;

                    i++;
                    j--;
                }
            }
            while (i <= j);

            if(left < j)
            {
                QuickSort(elemente, left, j);
            }
            if(right > i)
            {
                QuickSort(elemente, i, right);
            }
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

                for(int j=0; j < elemente.Length; j++)
                {
                    elementeInt[j] = int.Parse(elemente[j]);
                }

                QuickSort(elementeInt, 0, int.Parse(nrElemente) - 1);


                for (int j = 0; j < elemente.Length; j++)
                {
                    streamWriter.WriteLine(elementeInt[j]);
                }

                streamWriter.WriteLine("\n");
            }

            streamWriter.Close();
        }
    }
}
