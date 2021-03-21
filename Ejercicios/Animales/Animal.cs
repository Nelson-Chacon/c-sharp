using System;
namespace Animales
{
    abstract class Animal
    {
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public string  Edad{ get; set; }

        public bool Comer { get; set; }


    public void Alimentacion()
    {
        Comer = true;
       
    }


    }
    
    
}