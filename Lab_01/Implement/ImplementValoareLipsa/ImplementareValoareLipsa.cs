using Lab_01.Algoritmi;
using Lab_01.Fisier;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01.Implement.ImplementValoareLipsa
{
    public class ImplementareValoareLipsa
    {
        public ImplementareValoareLipsa() { }

        public void Main()
        {
            CitireScriere fisier = new CitireScriere();
            ValoareLipsa valoareLipsa = new ValoareLipsa();

            var vL = fisier.CitireFisierValLipsa("CElementLipsa.txt");

            var vl1 = valoareLipsa.ValoareLipsa_v1(vL, vL.Length);
            var vl2 = valoareLipsa.ValoareLipsa_v2(vL, vL.Length);
            var vl3 = valoareLipsa.ValoareLipsa_v3(vL, vL.Length);

            fisier.ScriereFisier("SElementLipsa1.txt", vl1);
            fisier.ScriereFisier("SElementLipsa2.txt", vl2);
            fisier.ScriereFisier("SElementLipsa3.txt", vl3);
        }
    }
}
