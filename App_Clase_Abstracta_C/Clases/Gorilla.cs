using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Clase_Abstracta_C
{
    class gorila : mamiferos, INumPatas
    {
        public int numpatas()
        {
            return 2;
        }

        public gorila(string nombreGorila) : base(nombreGorila)
        {

        }

        public void fuerza()
        {
            Console.WriteLine("Tengo fuerza sobre humana");
        }
    }
}
