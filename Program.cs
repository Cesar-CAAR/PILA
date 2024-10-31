using System;

namespace Proyecto_de_Pila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // La iniciamos en null
            Pila miPila = null; 
            int opcion = 0;

            while (opcion != 5)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Elige una de las siguientes opciones");
                Console.WriteLine();
                Console.WriteLine("1.- Ingresa el tamaño");
                Console.WriteLine("2.- Push");
                Console.WriteLine("3.- Pop");
                Console.WriteLine("4.- Print");
                Console.WriteLine("5.- Salir");
                Console.WriteLine();
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el tamaño máximo de la pila:");
                        int MAX = Convert.ToInt32(Console.ReadLine());
                        miPila = new Pila(MAX);
                        Console.WriteLine("");
                        break;



                    case 2:
                        Console.WriteLine("Ingrese el número a agregar a la pila:");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        miPila.Push(num);
                        break;



                    case 3:
                        int eliminado = miPila.Pop();
                        if (eliminado != -1)
                        {
                            Console.WriteLine($"Eliminado {eliminado}");
                        }
                        else
                        {
                            Console.WriteLine("-1");
                        }
                        break;



                    case 4:
                        miPila.Print();
                        break;



                    case 5:
                        Console.WriteLine("Saliendo...");
                        break;



                    default:
                        Console.WriteLine("Ingrese la opción correcta");
                        break;
                }
            }
        }
    }
}