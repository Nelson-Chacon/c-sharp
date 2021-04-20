namespace UNAHVS
{
  class DeptoAdministracion:Asignaturas
  {

      public DeptoAdministracion(string codigo, string nombre, string nombreMaestro,string hora, int cupos)
      {
      Codigo=codigo; 
      Nombre=nombre;
      NombreMaestro=nombreMaestro;
      Hora=hora;
      Cupos=cupos;
      }
  }

}