using Lab_01.Algoritmi;
using Lab_01.Fisier;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01.Implement.ImplementPrim
{
    public class ImplementarePrim
    {
        public ImplementarePrim() { }

        public void Main()
        {
            CitireScriere citireScriere = new CitireScriere();
            Prim prim = new Prim();

            var numere = citireScriere.CitireFisierPrim("CPrim.txt");

            string[] results = new string[numere.Length];

            for (int i = 0; i < numere.Length; i++)
            {
                results[i] = prim.PRIM(numere[i]);
            }

            citireScriere.ScriereFisier("SPrim.txt", results);
        }
    }
}
