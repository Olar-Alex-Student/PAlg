using Lab_01.Algoritmi;
using Lab_01.Fisier;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01.Implement.ImplementSort
{
    public class ImplementareSortBule
    {
        public ImplementareSortBule() { }

        public void Main()
        {
            CitireScriere citireScriere = new CitireScriere();
            Sort sort = new Sort();

            var sortBule = citireScriere.CitireFisierSortBule("CSortareBule.txt");

            var result = sort.SORTEAZA_BULE(sortBule, sortBule.Length);

            citireScriere.ScriereFisier("SSortareBule.txt", result);
        }
    }
}
