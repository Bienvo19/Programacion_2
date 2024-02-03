using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaDeClase.Dependencia
{
    public class Administrador:Docente
    {
        public Administrador(string name, int age, string charge, string especialidad) : base(name, age, charge, especialidad)
        {

        }
    }
}
