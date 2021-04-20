using System;

namespace UNAHVS
{
    class Usuarios
    {
        public string NCuenta { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }



        public Usuarios(string cuenta, string nombre, string carrera)
        {
            NCuenta=cuenta;
            Nombre=nombre;
            Carrera=carrera;
        }
    }

}