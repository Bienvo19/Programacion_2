using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaDeClase.Dependencia
{
    public class Estudiante : MiembrosDeLaComunidad
    {
        public string Carrear { get; set; }

        public Estudiante(string name, int age, string carrear)
            : base(name, age)
        {
            Carrear = carrear;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Estudiante: {Name}, Edad: {Age}, Carrera: {Carrear}");
        }
    }
}
