using System;
namespace UNAHVS
{
  class Matriculados
  {

      ClasesAdministracion a = new ClasesAdministracion();
      ClasesEconomia b = new ClasesEconomia();
      ListaClases c =new ListaClases();
      public void Matricula()
      {
    Console.Clear(); 
    a.matriculadoAdministracion();
    Console.WriteLine();
    b.matriculadoEconomia();
    Console.WriteLine();
    c.matriculadoInformatica();
    Console.ReadLine();

      }
  }

}