using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01.Algoritmi
{
    public class Sort
    {
        public Sort() { }

        public int[] SORTEAZA_BULE(int[] a, int n)
        {
            bool sortat;

            do
            {
                sortat = true;

                for (int i = 0; i <= n - 2; i++)
                {
                    if (a[i] > a[i+1])
                    {
                        int aux = a[i];
                        a[i] = a[i+1];
                        a[i+1] = aux;

                        sortat = false;
                    }
                }
            }
            while (!sortat);

            return a;
        }

        public int CAUTA_MIN(int[] a, int left, int right)
        {
            int indexMin = left;

            for (int i = left+1; i <= right; i++)
            {
                if (a[i] < a[indexMin])
                {
                    indexMin = i;
                }
            }

            return indexMin;
        }

        public int[] SORTEAZA_SELECTIE_MIN(int[] a, int n)
        {
            for (int i = 0; i <= n-2; i++)
            {
                int indexMin = CAUTA_MIN(a, i, n - 1);

                if(i != indexMin)
                {
                    int aux = a[i];
                    a[i] = a[indexMin];
                    a[indexMin] = aux;
                }
            }

            return a;
        }
    }
}
