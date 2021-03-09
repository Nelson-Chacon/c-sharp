using System;

namespace Ejercicio10_Ordenes
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c=new Cliente(123 ,"Maria" , "213123" );
            c.EnviarNotificacion();
        }
    }
}
