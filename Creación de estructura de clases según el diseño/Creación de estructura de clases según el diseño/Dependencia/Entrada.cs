using ArquitecturaDeClase.Dependencia;
using System;

namespace ArquitecturaDeClase.Dependencia
{
    class Dependencia
    {
        static void Main(string[] args) 
        {
            MiembrosDeLaComunidad miembro = new Estudiante("Fulanito", 24, "Ing. Civil");
            miembro.MostrarInformacion();
        }
    }
}
