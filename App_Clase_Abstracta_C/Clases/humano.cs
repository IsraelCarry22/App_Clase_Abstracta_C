using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Clase_Abstracta_C
{
    class humano : mamiferos, INumPatas
    {
        public int numpatas()
        {
            return 2;
        }

        public humano(string nombreHumano) : base(nombreHumano)
        {

        }

        public void estudio()
        {
            Console.WriteLine("Estudio y analizo absolutamente todo");
        }
    }
}
