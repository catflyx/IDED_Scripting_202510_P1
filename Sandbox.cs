using System;
using System.Collections.Generic; // Necesario para Stack, Queue, List
using TestProject1;

namespace TestProject1
{
    internal class Sandbox
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de números aleatorios para la pila:");
            int cantidad = int.Parse(Console.ReadLine());

            // Generar pila aleatoria
            Stack<uint> pila = TestMethods.GenerateRandomStack(cantidad);

            Console.WriteLine("\nPila generada:");
            foreach (var num in pila)
                Console.Write($"{num} ");
            Console.WriteLine();

            // Probar StackFirstPrime
            uint primerPrimo = TestMethods.StackFirstPrime(pila);
            Console.WriteLine($"\nPrimer primo encontrado: {primerPrimo}");

            // Probar RemoveFirstPrime
            Stack<uint> pilaSinPrimo = TestMethods.RemoveFirstPrime(new Stack<uint>(pila));
            Console.WriteLine("\nPila sin el primer primo:");
            foreach (var num in pilaSinPrimo)
                Console.Write($"{num} ");
            Console.WriteLine();

            // Probar CreateQueueFromStack
            Queue<uint> cola = TestMethods.CreateQueueFromStack(pila);
            Console.WriteLine("\nCola creada desde la pila:");
            foreach (var num in cola)
                Console.Write($"{num} ");
            Console.WriteLine();

            // Probar StackToList
            List<uint> lista = TestMethods.StackToList(pila);
            Console.WriteLine("\nLista creada desde la pila:");
            foreach (var num in lista)
                Console.Write($"{num} ");
            Console.WriteLine();

            //Lista numero cualquiera
            bool espar = false; int sizeLista = 0;
            while (espar == false)
            {
                Console.WriteLine("\nIngrese el tamaño de la lista (debe ser par):");
                sizeLista = int.Parse(Console.ReadLine());

                if (sizeLista % 2 != 0)
                {
                    espar = false;
                }
                else
                {
                    espar = true;
                }
            }

            List<int> listaRandom = TestMethods.GenerateRandomList(sizeLista);

            Console.WriteLine("\nLista generada:");
            foreach (var num in listaRandom)
                Console.Write($"{num} ");
            Console.WriteLine();

            // Ordenar y mostrar lista ordenada
            listaRandom.Sort();
            Console.WriteLine("\nLista ordenada:");
            foreach (var num in listaRandom)
                Console.Write($"{num} ");
            Console.WriteLine();

            Console.WriteLine("\nIngrese el número a buscar después de ordenar:");
            int numeroBuscar = int.Parse(Console.ReadLine());

            bool encontrado = TestMethods.FoundElementAfterSorted(listaRandom, numeroBuscar);

            Console.WriteLine(encontrado
                ? $"El número {numeroBuscar} SÍ está en la lista después de ordenar."
                : $"El número {numeroBuscar} NO está en la lista después de ordenar.");
        }
    }
}
