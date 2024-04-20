using Lab_01.Algoritmi;
using Lab_01.Fisier;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01.Implement.ImplementProdusCartezian
{
    public class ImplementareProdusCartezian
    {
        public ImplementareProdusCartezian() { }

        public void Main()
        {
            CitireScriere citireScriere = new CitireScriere();
            ProdusCartezian produsCartezian = new ProdusCartezian();

            var result = citireScriere.CitireFisierProdusCartezian("CProdusCartezian.txt");

            var nrMultimi = result.Item1;

            var dimMultimi = result.Item2.ToArray();

            int[,] multimi = new int[3, 3];

            for(int i=0; i < dimMultimi.Length; i++)
            {
                for(int j = 0; j < dimMultimi[i]; j++)
                {
                    multimi[i, j] = int.Parse(result.Item3[i][j]);
                }
            }

            var r = produsCartezian.PRODUS_CARTEZIAN(nrMultimi, dimMultimi, multimi);

            citireScriere.ScriereFisier("SProdusCartezian.txt", r.ToArray());
        }
    }
}
