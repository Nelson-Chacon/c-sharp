using System;
public class Persona
{
    public int Codigo { get; set; }

    public string Nombre { get; set; }


    void EnviarNotificacion()
    {
        Console.WriteLine("Correo enviado a: "+" "+Nombre);
    }
}