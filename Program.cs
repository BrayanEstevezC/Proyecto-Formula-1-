using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectof1
{
    class program
    {
        static void Main(string[] args)
        {
            Piloto ChecoPerez = new Piloto(12);
            ChecoPerez.AsignarNombre();
            string v6="HONA RB18 1.6B";
            Deportivo deportivo = new Deportivo();
            deportivo.AsignarMotor(v6);
            deportivo.AsignarPiloto(ChecoPerez);
            Console.ReadKey();
            
        }
    }
}