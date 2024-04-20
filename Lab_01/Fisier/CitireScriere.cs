using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01.Fisier
{
    public class CitireScriere
    {
        public CitireScriere() { }

        public Tuple<int, List<int>, List<string[]>> CitireFisierProdusCartezian(string path)
        {
            try
            {
                var lines = File.ReadAllLines(path);

                var nrMultimi = lines[0].Trim();

                List<int> dimMultimi = new List<int>();

                List<string[]> multimi = new List<string[]>();

                for(int i= 1; i < lines.Length; i = i+2)
                {
                    dimMultimi.Add(int.Parse(lines[i].Trim()));
                    multimi.Add(lines[i+1].Split(' '));
                }

                return new Tuple<int, List<int>, List<string[]>>(int.Parse(nrMultimi), dimMultimi, multimi);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int CitireFisierPermutari(string path)
        {
            try
            {
                var lines = File.ReadAllLines(path);

                var result = int.Parse(lines[0].Trim());

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int[] CitireFisierValLipsa(string path)
        {
            try
            {
                var lines = File.ReadAllLines(path);

                var nrElemente = lines[0].Trim();

                var elemente = lines[1].Trim().Split(' ');

                int[] elementeInt = new int[int.Parse(nrElemente)];

                for (int i = 0; i < int.Parse(nrElemente); i++)
                {
                    elementeInt[i] = 0;
                }

                for (int i = 0; i < elemente.Length; i++)
                {
                    elementeInt[i] = int.Parse(elemente[i]);
                }

                return elementeInt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public int[] CitireFisierSortBule(string path)
        {
            try
            {
                var lines = File.ReadAllLines(path);

                var nrElemente = lines[0].Trim();

                var elemente = lines[1].Trim().Split(' ');

                int[] elementeInt = new int[int.Parse(nrElemente)];

                for (int i = 0; i < int.Parse(nrElemente); i++)
                {
                    elementeInt[i] = int.Parse(elemente[i]);
                }

                return elementeInt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int[,] CitireFisierMatrice(string path, int inceput, int final, int rows, int columns)
        {
            try
            {
                var lines = File.ReadAllLines(path);

                int[,] linesSplit = new int[rows, columns];

                if (inceput != final)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            linesSplit[i, j] = int.Parse(lines[inceput-1].Split(' ')[j]);
                        }

                        inceput++;
                    }
                }

                return linesSplit;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int[] CitireFisierPrim(string path)
        {
            try
            {
                var lines = File.ReadAllLines(path);

                int[] elementeInt = new int[lines.Length];

                for (int i = 0; i < lines.Length; i++)
                {
                    elementeInt[i] = int.Parse(lines[i]);
                }

                return elementeInt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string[] ConvertArrayIntToString(int[] array)
        {
            try
            {
                var arr = new string[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    arr[i] = array[i].ToString();
                }

                return arr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string[] ConverMatrixTostringArray(int[,] matrix, int l, int c)
        {
            string[] linii = new string[l];

            for(int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    linii[i] += matrix[i, j];
                }
            }

            return linii;
        }

        public void ScriereFisier(string path, string[] elemente)
        {
            try
            {
                File.WriteAllLines(path, elemente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ScriereFisier(string path, int[] elemente)
        {
            try
            {
                var elementeString = ConvertArrayIntToString(elemente);
                File.WriteAllLines(path, elementeString);
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }

        public void ScriereFisier(string path, int elemente)
        {
            try
            {
                string[] elementeString = new string[1];
                elementeString[0] = elemente.ToString();
                File.WriteAllLines(path, elementeString);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public void ScriereFisier(string path, int[,] matrice, int l, int c)
        {
            try
            {
                var result = ConverMatrixTostringArray(matrice, l, c);
                File.WriteAllLines(path, result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
