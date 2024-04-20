using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01.Algoritmi
{
    public class ProdusCartezian
    {
        public ProdusCartezian() { }

        public List<int> PRODUS_CARTEZIAN(int n, int[] m, int[,] A)
        {
            List<int> c = new List<int>();

            int k = 0;

            int[] stiva = new int[n];

            stiva[k] = 0;

            while (k >= 0)
            {
                if (stiva[k] < m[k]-1)
                {
                    stiva[k] = stiva[k] + 1;

                    if (k == n-1)
                    {
                        c.Add(stiva[k]);
                    }
                    else
                    {
                        k = k + 1;
                        stiva[k] = -1;
                    }
                }
                else
                {
                    k = k - 1;
                }
            }

            return c;
        }
    }
}
