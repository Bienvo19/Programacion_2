using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaDeClase.Dependencia
{
    public class Administrativo:Empleado
    {
        public Administrativo(string name, int age, string charge) : base(name, age, charge)
        {
            
        }
    }
}
