using System;


namespace _01_Inventario
{
    class Program
    {
    
    static void Main(string[] args)
        {

            string opcion="";
            Inventario inventario =new Inventario();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE INVENTARIO");
                Console.WriteLine("**********************");
                Console.WriteLine("");
                Console.WriteLine("1-> Productos");
                Console.WriteLine("2-> Ingreso de inventario");
                Console.WriteLine("3-> Salida de inventario");
                Console.WriteLine("4-> Producto con defectos de fabrica");
                Console.WriteLine("5-> Cambiar productos con defectos");
                Console.WriteLine("0-> Salir");
                Console.WriteLine("Seleccione una opcion: ");
                opcion=Console.ReadLine(); 

                switch (opcion)
                {
                    case "1":
                    {
                        Console.Clear();
                        inventario.listarProductos();
                        Console.ReadLine();
                        break;
                    }
                    case "2":
                    {
                        Console.Clear();
                        inventario.ingreso_inventario();
                        Console.ReadLine();
                        break;
                    }
                    case "3":
                    {
                        Console.Clear();
                        inventario.salida_inventario();
                        break;
                    }
                    case "4":
                    {
                        Console.Clear();
                        inventario.productoMalo();
                        break;
                    }
                    case "5":
                    {
                        Console.Clear();
                        inventario.productoCambio();
                        break;
                    }
                    
                    default:
                    break;
                }
                if (opcion=="0")
                {
                    break;
                }
                
            }
            
        }
    }
}
