using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Clase_Abstracta_C
{
    class gato : mamiferos
    {
        public gato(string nombreGato) : base(nombreGato)
        {

        }

        public void flexibilidad()
        {
            Console.WriteLine("Soy capaz de entrer en agujeros pequeños");
        }
    }
}
