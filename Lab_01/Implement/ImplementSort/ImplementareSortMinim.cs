using Lab_01.Algoritmi;
using Lab_01.Fisier;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01.Implement.ImplementSort
{
    public class ImplementareSortMinim
    {
        public ImplementareSortMinim() { }

        public void Main()
        {
            CitireScriere citireScriere = new CitireScriere();
            Sort sort = new Sort();

            var numere = citireScriere.CitireFisierSortBule("CSortareMinim.txt");

            var result = sort.SORTEAZA_SELECTIE_MIN(numere, numere.Length);

            citireScriere.ScriereFisier("SSortareMinim.txt", result);
        }
    }
}
