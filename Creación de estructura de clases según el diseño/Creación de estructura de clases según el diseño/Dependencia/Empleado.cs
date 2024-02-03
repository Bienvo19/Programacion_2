using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaDeClase.Dependencia
{
    public class Empleado:MiembrosDeLaComunidad
    {
        public string Charge { get; set; }

        public Empleado(string name, int age, string charge): base(name, age)
        {
            Charge = charge;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Empleado: Name: {Name}, Age: {Age}, Charge: {Charge}");
        }
    }
}
