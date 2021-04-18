using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App1.LayerLogic
{
    

    public class Empleado
    {

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string[] Colec;


        public Empleado(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;

        }

    }
}
