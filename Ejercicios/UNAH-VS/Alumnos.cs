using System;

namespace UNAH_VS
{
    class Alumnos
    {
        public string NCuenta { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }

        public Alumnos(string cuenta, string nombre, string carrera)
        {
            NCuenta=cuenta;
            Nombre=nombre;
            Carrera=carrera;
        }
    }

}