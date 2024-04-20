using Lab_01.Algoritmi;
using Lab_01.Fisier;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01.Implement.ImplementPermutari
{
    public class ImplementarePermutari
    {
        public ImplementarePermutari() { }

        public void Main()
        {
            CitireScriere citireScriere = new CitireScriere();
            GenerarePermutari generarePermutari = new GenerarePermutari();

            var numar = citireScriere.CitireFisierPermutari("CGenerarePermutari.txt");

            var factorial = generarePermutari.Factorial(numar);

            int[,] results = new int[factorial, numar];

            var permutari = generarePermutari.GENERARE_PERMUTARI(numar);

            int k = 0;

            if (k < numar * factorial)
            {
                for (int i = 0; i < factorial; i++)
                {
                    for (int j = 0; j < numar; j++)
                    {
                        results[i, j] = permutari[k];
                        k++;
                    }
                }
            }

            citireScriere.ScriereFisier("SGenerarePermutari.txt", results, factorial, numar);
        }
    }
}
