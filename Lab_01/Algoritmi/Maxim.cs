using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01.Algoritmi
{
    public class Maxim
    {
        public Maxim() { }
        public int DeterminaMaxim(int[] a, int n)
        {
            int max = a[0];

            for(int i = 1; i < n-1;  i++)
            {
                if (max < a[i]) 
                {
                    max = a[i];
                }
            }

            return max;
        }
    }
}
