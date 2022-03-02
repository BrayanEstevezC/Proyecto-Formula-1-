using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectof1
{
    public class Piloto
    {
        public string nombre;
        public int AnosExperiencia;

        public Piloto(int anios)
        {
            AnosExperiencia = anios;
        }
        public void AsignarNombre ()
        { 
        Console.WriteLine("El nombre del piloto es ");
            string nombre;
            nombre = Console.ReadLine();
            this.nombre = nombre; 
        }
    }
}
