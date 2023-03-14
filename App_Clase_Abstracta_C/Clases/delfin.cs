using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Clase_Abstracta_C
{
    class delfin : mamiferos
    {
        public delfin(string nombreDelfin) : base(nombreDelfin)
        {

        }

        public void telepatia()
        {
            Console.WriteLine("Soy capaz de comunicarme por ondar telepatas");
        }
    }
}
