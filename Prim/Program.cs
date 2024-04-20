using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fisier();
        }

        static string PRIM(int n)
        {
            if (n == 2) return "PRIM";
            if (n % 2 == 0) return "COMPUS";
            var radacina = Math.Sqrt(n);

            for(int i = 3; i <= radacina; i+=2) 
            {
                if(n%i == 0)
                {
                    return "COMPUS";
                }
            }

            return "PRIM";
        }

        static void Fisier()
        {
            StreamReader streamReader = new StreamReader("Citire.txt");
            StreamWriter streamWriter = new StreamWriter("Scriere.txt");

            var _for = streamReader.ReadLine();

            for(int i = 0; i < int.Parse(_for); i++)
            {
                var nr = streamReader.ReadLine();

                var result = PRIM(int.Parse(nr));

                streamWriter.WriteLine(result);
            }

            streamWriter.Close();
        }
    }
}
