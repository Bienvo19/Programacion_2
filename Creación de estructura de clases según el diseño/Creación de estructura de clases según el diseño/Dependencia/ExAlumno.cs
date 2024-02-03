using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArquitecturaDeClase.Dependencia
{
    public class ExAlumno : MiembrosDeLaComunidad
    {
        public string Carrear { get; set; }
        public int AñoGraduacion { get; set; }

        public ExAlumno(string name, int age, string carrear, int añoGraduacion)
            : base(name, age)
        {
            Carrear = carrear;
            AñoGraduacion = añoGraduacion;  
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"ExAlumno: {Name}, Edad: {Age}, Carrera: {Carrear}, Año de graduacion {AñoGraduacion}");
        }
    }
}
