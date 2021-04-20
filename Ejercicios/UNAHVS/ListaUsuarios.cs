using System;
using System.Collections.Generic;
using System.Linq;

namespace UNAHVS
{
    class ListaUsuarios
    {
        public List<Usuarios> ListadeUsuarios { get; set; }


        public ListaUsuarios()
        {
            ListadeUsuarios = new List<Usuarios>(); 
            usuarios();
        }

        private void usuarios()
        {
            Usuarios a = new Usuarios ("20192001567","Jose Alberto Perez","Informatica Administrativa");
            Usuarios b = new Usuarios ("20202000864","Maria Jose Fernandez","Informatica Administrativa");
            Usuarios c = new Usuarios ("20122003477","Juana Alejandra Martinez","Informatica Administrativa");
            Usuarios d = new Usuarios ("20122002587","Marcos Daniel Soza","Informatica Administrativa");
            Usuarios e = new Usuarios ("20142000555","Manuel Orlando Sandoval","Informatica Administrativa");
            Usuarios f = new Usuarios ("20172000556","Eduard David Osorio","Administracion de Empresa");
            Usuarios g = new Usuarios ("20192000545","Maximo Marco Hernandez","Administracion de Empresa");
            Usuarios h = new Usuarios ("20202000355","Ramona Victoria Parra","Administracion de Empresa");
            Usuarios i = new Usuarios ("20132000565","Margarita de Jesus Zambrano","Administracion de Empresa");
            Usuarios j = new Usuarios ("20012000255","Lucila Maria Perez",   "Economia");
            Usuarios k = new Usuarios ("20182000055","Juan Bautista Zurita","Economia");
            Usuarios l = new Usuarios ("20192000975","Luis Javier Collado","Economia");
            Usuarios m = new Usuarios ("20202000565","Vanesa Rivero",      "Economia");
            Usuarios n = new Usuarios ("20212000576","Maria Estrella Peña","Economia");
            Usuarios o = new Usuarios ("20192000542","Leonardo Cantero","Economia");
            
            ListadeUsuarios.Add(a);
            ListadeUsuarios.Add(b);
            ListadeUsuarios.Add(c);
            ListadeUsuarios.Add(d);
            ListadeUsuarios.Add(e);
            ListadeUsuarios.Add(f);
            ListadeUsuarios.Add(g);
            ListadeUsuarios.Add(h);
            ListadeUsuarios.Add(i);
            ListadeUsuarios.Add(j);
            ListadeUsuarios.Add(l);
            ListadeUsuarios.Add(m);
            ListadeUsuarios.Add(n);
            ListadeUsuarios.Add(o);
            
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
            var usuariosOrdenados= ListadeUsuarios.OrderBy(usr => usr.Carrera);
            foreach (var usuarios in usuariosOrdenados)
            {
                Console.WriteLine(usuarios.NCuenta +"     |        "+usuarios.Nombre+"      -> "+usuarios.Carrera );
            }
            Console.ReadLine();
        }
       












    }
}