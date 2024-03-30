using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01.Algoritmi
{
    public class Matrici
    {
        public Matrici() { }

        public int[,] InmultireMatrici(int[,] A, int n, int m, int[,] B, int p, int[,] C)
        {
            for (int i = 0; i <= n-1; i++) 
            {
                for (int j = 0; j <= p-1; j++) 
                {
                    C[i, j] = 0;

                    for (int k = 0; k <= m-1; k++)
                    {
                        C[i,j] = C[i, j] + A[i,k] * B[k,j];
                    }
                }
            }

            return C;
        }
    }
}
