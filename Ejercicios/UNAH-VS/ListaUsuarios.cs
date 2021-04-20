using System;
using System.Collections.Generic;
using System.Linq;

namespace UNAH_VS
{
    class ListaUsuarios
    {
        public List<Alumnos> ListaAlumnos{ get; set; }

        public ListaUsuarios()
        {
            ListaAlumnos = new List<Alumnos>();
            Alumnos();
        }

private void Alumnos(){

         Alumnos a = new Alumnos("20192001567","Jose Alberto Perez","Informatica Administrativa");
            Alumnos b = new Alumnos ("20202000864","Maria Jose Fernandez","Informatica Administrativa");
            Alumnos c = new Alumnos ("20122003477","Juana Alejandra Martinez","Informatica Administrativa");
            Alumnos d = new Alumnos ("20122002587","Marcos Daniel Soza","Informatica Administrativa");
            Alumnos e = new Alumnos ("20142000555","Manuel Orlando Sandoval","Informatica Administrativa");
            Alumnos f = new Alumnos("20172000556","Eduard David Osorio","Administracion de Empresa");
            Alumnos g = new Alumnos ("20192000545","Maximo Marco Hernandez","Administracion de Empresa");
            Alumnos h = new Alumnos ("20202000355","Ramona Victoria Parra","Administracion de Empresa");
            Alumnos i = new Alumnos ("20132000565","Margarita de Jesus Zambrano","Administracion de Empresa");
            Alumnos j = new Alumnos ("20012000255","Lucila Maria Perez",   "Economia");
            Alumnos k = new Alumnos ("20182000055","Juan Bautista Zurita","Economia");
            Alumnos l = new Alumnos ("20192000975","Luis Javier Collado","Economia");
            Alumnos m = new Alumnos ("20202000565","Vanesa Rivero",      "Economia");
            Alumnos n = new Alumnos ("20212000576","Maria Estrella Peña","Economia");
            Alumnos o = new Alumnos ("20192000542","Leonardo Cantero","Economia");
            
            ListaAlumnos.Add(a);
            ListaAlumnos.Add(b);
            ListaAlumnos.Add(c);
            ListaAlumnos.Add(d);
            ListaAlumnos.Add(e);
            ListaAlumnos.Add(f);
            ListaAlumnos.Add(g);
            ListaAlumnos.Add(h);
            ListaAlumnos.Add(i);
            ListaAlumnos.Add(j);
            ListaAlumnos.Add(l);
            ListaAlumnos.Add(m);
            ListaAlumnos.Add(n);
            ListaAlumnos.Add(o);
            
        }
        public void listaUsuarios()
        {
            Console.Clear();
            Console.Clear();
            Console.WriteLine("================================================================================");
            Console.WriteLine("                              LISTA DE USUARIOS");
            Console.WriteLine("=================================================================================");

            Console.WriteLine("=================================================================================");
            Console.WriteLine("Numero de Cuenta           |     Nombre y Apellido            |       Carrera");
            Console.WriteLine("=================================================================================");
            var usuariosOrdenados= ListaAlumnos.OrderBy(usr => usr.Carrera);
            foreach (var usuarios in usuariosOrdenados)
            {
                Console.WriteLine(usuarios.NCuenta +"     |        "+usuarios.Nombre+"      -> "+usuarios.Carrera );
            }
            Console.ReadLine();
        }
    }   
}