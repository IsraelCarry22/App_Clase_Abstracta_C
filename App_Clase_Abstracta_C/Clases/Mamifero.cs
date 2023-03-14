using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Clase_Abstracta_C
{
    class mamiferos : animales
    {
        private String nombreServivo;

        public mamiferos(string nombre)
        {
            this.nombreServivo = nombre;
        }

        public void pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }

        public void cuidar_bebes()
        {
            Console.WriteLine("Crio a mis bebes asta que se validen por si mismas");
        }

        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }

        public void nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }

        public override void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es: " + nombreServivo);
        }
    }
}
