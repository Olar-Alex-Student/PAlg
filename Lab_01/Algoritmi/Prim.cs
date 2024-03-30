using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01.Algoritmi
{
    internal class Prim
    {
        public Prim() { }

        public string PRIM(int n)
        {
            if (n == 2) return "PRIM";
            if (n % 2 == 0) return "COMPUS";

            var r = Math.Sqrt(double.Parse(n.ToString()));

            for (int i = 3; i < r; i+=2) 
            {
                if (n % i == 0) return "COMPUS";
            }

            return "PRIM";
        }
    }
}
