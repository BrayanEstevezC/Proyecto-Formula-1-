using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectof1
{
    internal class MonoPLaza
    {
        public int asiento;
        public string motor;
        public Piloto piloto;

        public MonoPLaza(global::System.String motor)
        {
            this.motor = motor;
        }

        public void AsignarMotor(string Motor)
        {
            Console.WriteLine("Cuantos tiene caballos de fuerza tiene \n");
            
            Console.WriteLine("Los Caballos de fuerza es de " + Motor);
            motor = Motor;
        }
        
        public void AsignarPiloto(Piloto piloto)
        {
            this.piloto = piloto;
        }
        
    }

 }
