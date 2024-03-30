using Lab_01.Algoritmi;
using Lab_01.Fisier;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01.Implement.ImplementMaxim
{
    public class ImplementareMaxim
    {
        public ImplementareMaxim() { }

        public void Main()
        {
            CitireScriere citireScriere = new CitireScriere();
            Maxim maxim = new Maxim();

            var numere = citireScriere.CitireFisierSortBule("CDeterminaMaxim.txt");

            var result = maxim.DeterminaMaxim(numere, numere.Length);

            citireScriere.ScriereFisier("SDeterminaMaxim.txt", result);
        }
    }
}
