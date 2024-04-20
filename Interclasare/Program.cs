using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interclasare
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int nrElemente = 7;
            int[] elemente = { 1,2,3,4,5,7,9 };
            int[] elemente1 = { 2,4,6,8,10 };

            int[] result = new int[12];

            var a = Interclasare(elemente, elemente1, result);

            foreach (var b in a)
            {
                Console.WriteLine(b);
            }

            Console.ReadLine();

        }

        static int[] Interclasare(int[] elemente, int[] elemente1, int[] result)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < elemente.Length-1 || j < elemente1.Length-1)
            {
                if (elemente[i] == elemente1[j])
                {
                    result[k++] = elemente[i++];
                    result[k++] = elemente1[j++];
                }
                else
                {
                    if (elemente[i] < elemente1[j])
                    {
                        result[k++] = elemente[i++];
                    }

                    if (elemente[i] > elemente1[j])
                    {
                        result[k++] = elemente1[j++];
                    }
                }
            }
            
            while(i <= elemente.Length-1)
            {
                result[k] = elemente[i];
                k++;
                i++;
            }
            while(j <= elemente1.Length-1)
            {
                result[k] = elemente1[j];
                k++;
                j++;
            }
            

            return result;
        }
    }
}
