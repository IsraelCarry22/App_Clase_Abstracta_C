using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Clase_Abstracta_C
{
    class pez : animales
    {
        protected String NombrePez;

        public pez(String nombrepez)
        {
            this.NombrePez = nombrepez;
        }

        public override void getNombre()
        {
            Console.WriteLine("El nomnbre del animal es: " + NombrePez);
        }
    }
}
