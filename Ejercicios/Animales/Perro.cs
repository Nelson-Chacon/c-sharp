using System;
namespace Animales
{   
    class Perro:Mamifero
    {
        public Perro(string nombre,string sexo,string edad,string patas,string reproduccion,string desplazamiento,bool comer)
        {
            Nombre=nombre;
            Sexo=sexo;
            Edad=edad;
            Patas=patas;
            Reproduccion=reproduccion;
            Desplazamiento=desplazamiento;
            Comer=comer;
            
            
        }
        public Perro()
        {
            
        }
        public void caracteristica()
        {
            Console.WriteLine("Ladrar");
        }
    }
}
