using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeerTeclado
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("               Calculadora");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1 = Suma");
            Console.WriteLine("2 = Resta");
            Console.WriteLine("3 = Multiplicar");
            Console.WriteLine("4 = Dividir");
            while (true)
            {
                try
                {
                
                Console.Write("Selecciona una opcion:");
                
                string opcion = Console.ReadLine();
                int seleccion = int.Parse(opcion);
                
                    if(seleccion > 4)
                        {
                            Console.WriteLine("Esta opcion no existe");
                        }
                        
                    switch (seleccion)
                        {

                            case (1):
                                Console.WriteLine("Suma de dos números");
                                Console.Write("Ingresa número 1: ");
                                string dato = Console.ReadLine();
                                int n1 = int.Parse(dato);

                                Console.Write("Ingresa número 2: ");
                                dato = Console.ReadLine();
                                int n2 = int.Parse(dato);

                                int suma = n1 + n2;
                                Console.WriteLine("El resultado es: {0}", suma);
                                Console.ReadKey();
                                break;

                            case (2):
                                Console.WriteLine("Resta de dos números");
                                Console.Write("Ingresa número 1: ");
                                string datoR = Console.ReadLine();
                                int n1r = int.Parse(datoR);

                                Console.Write("Ingresa número 2: ");
                                datoR = Console.ReadLine();
                                int n2r = int.Parse(datoR);

                                int resta = n1r - n2r;
                                Console.WriteLine("El resultado es: {0}", resta);
                                Console.ReadKey();
                                break;

                            case (3):
                                Console.WriteLine("Multiplicacion de dos números");
                                Console.Write("Ingresa número 1: ");
                                string datoM = Console.ReadLine();
                                int n1m = int.Parse(datoM);

                                Console.Write("Ingresa número 2: ");
                                datoM = Console.ReadLine();
                                int n2m = int.Parse(datoM);

                                int multiplicacion = n1m * n2m;
                                Console.WriteLine("El resultado es: {0}", multiplicacion);
                                Console.ReadKey();
                                break;

                            case (4):
                                Console.WriteLine("Resta de dos números");
                                Console.Write("Ingresa número 1: ");
                                string datoD = Console.ReadLine();
                                int n1d = int.Parse(datoD);

                                Console.Write("Ingresa número 2: ");
                                datoD = Console.ReadLine();
                                int n2d = int.Parse(datoD);

                                int division = n1d / n2d;
                                Console.WriteLine("El resultado es: {0}", division);
                                Console.ReadKey();
                                break;
                            }
                        }
                catch (Exception)
                    {
                        Console.WriteLine("Opcion no valida, solo acepta numeros");
                        Console.ReadKey();
                    }
            }
        }
    }
}
