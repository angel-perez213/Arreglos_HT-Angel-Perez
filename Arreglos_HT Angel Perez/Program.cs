using System;

namespace Arreglos_HT_Angel_Perez
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vector Valores
            int[] valores = { 85, 96, 65, 70, 55, 45, 62, 95, 74, 100, 74, 83, 93 };

            // Mostrar posiciones de valores primos
            Console.WriteLine("Posiciones de los valores primos:");
            for (int i = 0; i < valores.Length; i++)
            {
                if (EsPrimo(valores[i]))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();

            // Mostrar posiciones de valores múltiplos de 5
            Console.WriteLine("Posiciones de los valores múltiplos de 5:");
            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] % 5 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();

            // Encontrar el menor valor del arreglo
            int min = valores[0];
            for (int i = 1; i < valores.Length; i++)
            {
                if (valores[i] < min)
                {
                    min = valores[i];
                }
            }
            Console.WriteLine("El menor valor del arreglo es: " + min);

            // Vector de N posiciones con valores de 0 a 20
            int n = 10;
            int[] vector = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                vector[i] = random.Next(0, 21);
            }

            // Mostrar cantidad de valores en los rangos 0-5, 6-10, 11-15, 16-20
            int[] conteoRangos = new int[4];
            for (int i = 0; i < n; i++)
            {
                if (vector[i] >= 0 && vector[i] <= 5)
                {
                    conteoRangos[0]++;
                }
                else if (vector[i] >= 6 && vector[i] <= 10)
                {
                    conteoRangos[1]++;
                }
                else if (vector[i] >= 11 && vector[i] <= 15)
                {
                    conteoRangos[2]++;
                }
                else if (vector[i] >= 16 && vector[i] <= 20)
                {
                    conteoRangos[3]++;
                }
            }
            Console.WriteLine("Cantidad de valores en los rangos 0-5, 6-10, 11-15, 16-20:");
            Console.WriteLine(conteoRangos[0] + " " + conteoRangos[1] + " " + conteoRangos[2] + " " + conteoRangos[3]);
        }

        // Función para determinar si un número es primo
        static bool EsPrimo(int num)
        {
            if (num < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
