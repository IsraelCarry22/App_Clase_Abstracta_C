using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace App_Clase_Abstracta_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            humano persona = new humano("Ana");
            Console.WriteLine("Numero de piernas es: " + persona.numpatas());

            pez main = new pez("Pepe");
            main.getNombre();

            Console.ReadKey();
        }
    }
}
