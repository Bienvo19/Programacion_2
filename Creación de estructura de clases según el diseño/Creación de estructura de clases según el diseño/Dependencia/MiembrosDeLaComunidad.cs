using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaDeClase.Dependencia
{
    public abstract class MiembrosDeLaComunidad
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public MiembrosDeLaComunidad(string name, int age) 
        {
            Name = name;  
            Age = age;
        }
        public abstract void MostrarInformacion();
    }

}
