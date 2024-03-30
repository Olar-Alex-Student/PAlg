using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01.Algoritmi
{
    public class ValoareLipsa
    {
        public ValoareLipsa() { }

        public int ValoareLipsa_v1(int[] A, int n)
        {
            for (int v = 1; v <= n; v++)
            {
                bool amGasit = false;

                for(int i = 0; i <= n-2; i++)
                {
                    if (A[i] == v)
                    {
                        amGasit = true;
                        break;
                    }
                }

                if (amGasit == false) 
                {
                    return v;
                }
            }

            return -1;
        }

        public int ValoareLipsa_v2(int[] A, int n)
        {
            int[] prezent = new int[n];

            for(int i = 0; i <= n-1; i++)
            {
                prezent[i] = 0;
            }

            for(int i = 0; i <= n-2; i++)
            {
                prezent[A[i] - 1] = 1;
            }

            for(int i = 0; i <= n-1; i++)
            {
                if (prezent[i] == 0)
                {
                    return i + 1;
                }
            }

            return -1;
        }

        public int ValoareLipsa_v3(int[] A, int n)
        {
            int suma = 0;

            for(int i=0; i <= n-2 ; i++)
            {
                suma += A[i];
            }

            return n * (n + 1) / 2 - suma;
        }
    }
}
