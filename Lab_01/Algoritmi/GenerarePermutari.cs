using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_01.Algoritmi
{
    public class GenerarePermutari
    {
        public GenerarePermutari() { }

        public int Factorial(int n)
        {
            int factorial = 1;
            for(int i=1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        public List<int> GENERARE_PERMUTARI(int n)
        {
            List<int> p = new List<int>();

            int k = 0;

            int[] stiva = new int[n];

            stiva[k] = 0;

            bool amSuccesor = false;
            bool esteValid = false;

            while (k >= 0)
            {
                do
                {
                    amSuccesor = true;

                    if (stiva[k] < n)
                    {
                        stiva[k] = stiva[k] + 1;

                        esteValid = true;

                        for (int i = 0; i <= k - 1; i++)
                        {
                            if (stiva[i] == stiva[k])
                            {
                                esteValid = false;
                            }
                        }
                    }
                    else
                    {
                        amSuccesor = false;
                    }

                }
                while (amSuccesor && !esteValid);

                if (amSuccesor)
                {
                    if (k == n - 1)
                    {
                        for (int i = 0; i <= n - 1; i++)
                        {
                            p.Add(stiva[i]);
                        }
                    }
                    else
                    {
                        k = k + 1;
                        stiva[k] = 0;
                    }
                }
                else
                {
                    k = k - 1;
                }
            }

            return p;
        }

        public static void GenereazaPermutari(int n)
        {
            int[] stiva = new int[n];
            int k = 0; // nivelul stivei
            stiva[k] = 0;
            while (k >= 0)
            {
                bool amSuccesor = false, esteValid = false;
                do
                {
                    if (stiva[k] < n)
                    {
                        amSuccesor = true;
                        stiva[k]++;
                        esteValid = true;

                        for (int i = 0; i < k; i++)
                            if (stiva[i] == stiva[k])

                            {

                                esteValid = false;

                                break;

                            }
                    }
                    else amSuccesor = false;
                } while (amSuccesor && !esteValid);
                if (amSuccesor)
                {
                    if (k == n - 1)
                    {
                        for (int i = 0; i < n; i++)
                            Console.Write("{0}{1}",
                            stiva[i], i == n - 1 ? "" : ",");
                        Console.WriteLine();
                    }
                    else { k++; stiva[k] = 0; }
                }
                else k--;
            }
        }
    }
}
