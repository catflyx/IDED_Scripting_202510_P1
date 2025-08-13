using System;
using System.Collections.Generic;

namespace TestProject1
{
    internal class TestMethods
    {
        internal static uint StackFirstPrime(Stack<uint> stack)
        {
            Stack<uint> tempStack = new Stack<uint>();
            uint firstPrime = 0;

            while (stack.Count > 0)
            {
                uint current = stack.Pop();
                tempStack.Push(current);
                if (EsPrimo(current))
                {
                    firstPrime = current;
                    break;
                }
            }

            // Restaurar la pila original
            while (tempStack.Count > 0)
            {
                stack.Push(tempStack.Pop());
            }

            return firstPrime;
        }

        internal static Stack<uint> RemoveFirstPrime(Stack<uint> stack)
        {
            Stack<uint> tempStack = new Stack<uint>();
            bool found = false;

            while (stack.Count > 0)
            {
                uint current = stack.Pop();
                if (!found && EsPrimo(current))
                {
                    found = true;
                    continue;
                }
                tempStack.Push(current);
            }

            Stack<uint> resultStack = new Stack<uint>();
            while (tempStack.Count > 0)
            {
                resultStack.Push(tempStack.Pop());
            }

            return resultStack;
        }

        internal static Queue<uint> CreateQueueFromStack(Stack<uint> stack)
        {
            Queue<uint> queue = new Queue<uint>();
            var array = stack.ToArray(); // índice 0 es el tope

            // Recorrer el array desde 0 hasta final para mantener el orden que ves en la pila
            for (int i = 0; i < array.Length; i++)
            {
                queue.Enqueue(array[i]);
            }

            return queue;
        }

        internal static List<uint> StackToList(Stack<uint> stack)
        {
            List<uint> list = new List<uint>();
            var array = stack.ToArray(); // índice 0 es el tope

            // Recorrer igual que la pila, desde 0 hasta final para mantener orden
            for (int i = 0; i < array.Length; i++)
            {
                list.Add(array[i]);
            }

            return list;
        }

        private static bool EsPrimo(uint num)
        {
            if (num < 2) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            for (uint i = 3; i * i <= num; i += 2)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        internal static bool FoundElementAfterSorted(List<int> list, int value)
        {
            list.Sort(); // Ordena ascendentemente
            return list.BinarySearch(value) >= 0;
        }

        internal static Stack<uint> GenerateRandomStack(int cantidad)
        {
            Random rnd = new Random();
            Stack<uint> stack = new Stack<uint>();

            for (int i = 0; i < cantidad; i++)
            {
                stack.Push((uint)rnd.Next(0, 100)); // números entre 0 y 99
            }

            return stack;
        }

        internal static List<int> GenerateRandomList(int size)
        {
            if (size % 2 != 0)
                throw new ArgumentException("El tamaño de la lista debe ser par.");

            Random rnd = new Random();
            List<int> list = new List<int>();

            for (int i = 0; i < size; i++)
            {
                list.Add(rnd.Next(0, 100)); // números entre 0 y 99
            }

            return list;
        }
    }
}
