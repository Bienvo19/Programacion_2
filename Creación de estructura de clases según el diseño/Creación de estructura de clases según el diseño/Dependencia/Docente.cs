using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaDeClase.Dependencia
{
    public class Docente:Empleado
    {
        public string Subjet { get; set; }
        public Docente(string name, int age, string charge, string subjet): base(name,age,charge)
        {
         Subjet = subjet;
        }
    }
}
