using Lab_01.Algoritmi;
using Lab_01.Fisier;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01.Implement.ImplementMatrici
{
    public class ImplementareInmultireMatrici
    {
        public ImplementareInmultireMatrici() { }

        public void Main()
        {
            CitireScriere citireScriere = new CitireScriere();
            Matrici matrici = new Matrici();

            var matrice1 = citireScriere.CitireFisierMatrice("CInmultireMatrici.txt", 1, 4, 4, 2);
            var matrice2 = citireScriere.CitireFisierMatrice("CInmultireMatrici.txt", 5, 6, 2, 3);
            int[,] matrice3 = new int[4,3];

            var result = matrici.InmultireMatrici(matrice1, 4, 2, matrice2, 3, matrice3);

            citireScriere.ScriereFisier("SInmultireMatrici.txt", matrice3, 4, 3);
        }
    }
}
