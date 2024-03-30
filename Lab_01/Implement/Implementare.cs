using Lab_01.Implement.ImplementMatrici;
using Lab_01.Implement.ImplementMaxim;
using Lab_01.Implement.ImplementPrim;
using Lab_01.Implement.ImplementSort;
using Lab_01.Implement.ImplementValoareLipsa;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01.Implement
{
    public class Implementare
    {
        public Implementare() { }

        public void Main() 
        {
            ImplementareValoareLipsa implementareValoareLipsa = new ImplementareValoareLipsa();
            ImplementareSortBule implementareSortBule = new ImplementareSortBule();
            ImplementarePrim implementarePrim = new ImplementarePrim();
            ImplementareSortMinim implementareSortMinim = new ImplementareSortMinim();
            ImplementareMaxim implementareMaxim = new ImplementareMaxim();
            ImplementareInmultireMatrici implementareInmultireMatrici = new ImplementareInmultireMatrici();
            
            implementareValoareLipsa.Main();
            implementareSortBule.Main();
            implementarePrim.Main();
            implementareSortMinim.Main();
            implementareMaxim.Main();
            implementareInmultireMatrici.Main();
        } 
    }
}
