using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cautare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FisierCaut();
            FisierCautBinarIterativ();
            FisierCautBinarRecursiv();
        }

        static int Cauta(int[] elemente, int nrElemente, int cautat)
        {
            for(int i = 0; i < nrElemente; i++)
            {
                if (elemente[i] == cautat) return i;
            }
            return -1;
        }

        static int CautaBinarRecursiv(int[] elemente, int left, int right, int cautat)
        {
            if (left > right) return -1;

            var mid = (left + right) / 2;

            if (elemente[mid] == cautat) return mid;

            else
            {
                if (elemente[mid] < cautat)
                { 
                    return CautaBinarRecursiv(elemente, mid + 1, right, cautat);
                }
                else
                {
                    return CautaBinarRecursiv(elemente, left, mid - 1, cautat);
                }
            }
        }

        static int CautaBinarIterativ(int[] elemente, int nrElemente, int cautat)
        {
            int left = 0;
            int right = nrElemente - 1;

            while(left <= right)
            {
                var mid = (left + right) / 2;

                if (elemente[mid] == cautat)
                {
                    return mid;
                }

                if (elemente[mid] < cautat)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }

        static void FisierCaut()
        {
            StreamReader streamReader = new StreamReader("Citire.txt");
            StreamWriter streamWriter = new StreamWriter("ScriereCauta.txt");

            var _for = streamReader.ReadLine();

            for(int i = 0; i < int.Parse(_for); i++)
            {
                var nrElemente = streamReader.ReadLine().Trim();
                var elemente = streamReader.ReadLine().Split(' ');
                var cautat = streamReader.ReadLine().Trim();

                var elementeInt = new int[elemente.Length];

                for(int j = 0; j < elemente.Length; j++)
                {
                    elementeInt[j] = int.Parse(elemente[j]);
                }

                var result = Cauta(elementeInt, int.Parse(nrElemente), int.Parse(cautat));

                streamWriter.WriteLine(result);
            }

            streamWriter.Close();
        }
        
        static void FisierCautBinarRecursiv()
        {
            StreamReader streamReader = new StreamReader("Citire.txt");
            StreamWriter streamWriter = new StreamWriter("ScriereCautaBinarRecursiv.txt");

            var _for = streamReader.ReadLine();

            for(int i = 0; i < int.Parse(_for); i++)
            {
                var nrElemente = streamReader.ReadLine().Trim();
                var elemente = streamReader.ReadLine().Split(' ');
                var cautat = streamReader.ReadLine().Trim();

                var elementeInt = new int[elemente.Length];

                for(int j = 0; j < elemente.Length; j++)
                {
                    elementeInt[j] = int.Parse(elemente[j]);
                }

                var result = CautaBinarRecursiv(elementeInt, 0, int.Parse(nrElemente) -1, int.Parse(cautat));

                streamWriter.WriteLine(result);
            }

            streamWriter.Close();
        }
        
        static void FisierCautBinarIterativ()
        {
            StreamReader streamReader = new StreamReader("Citire.txt");
            StreamWriter streamWriter = new StreamWriter("ScriereCautaBinarIterativ.txt");

            var _for = streamReader.ReadLine();

            for(int i = 0; i < int.Parse(_for); i++)
            {
                var nrElemente = streamReader.ReadLine().Trim();
                var elemente = streamReader.ReadLine().Split(' ');
                var cautat = streamReader.ReadLine().Trim();

                var elementeInt = new int[elemente.Length];

                for(int j = 0; j < elemente.Length; j++)
                {
                    elementeInt[j] = int.Parse(elemente[j]);
                }

                var result = CautaBinarIterativ(elementeInt, int.Parse(nrElemente), int.Parse(cautat));

                streamWriter.WriteLine(result);
            }

            streamWriter.Close();
        }
    }
}
