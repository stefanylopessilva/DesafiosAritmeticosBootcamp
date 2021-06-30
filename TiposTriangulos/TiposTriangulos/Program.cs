using System;
using System.Linq;

public class Desafio
    {
        public static void Main()
        {
            string[] s = Console.ReadLine().Split(' ');
            double[] arrayDouble = s.Select(Double.Parse).ToArray();
            Array.Sort(arrayDouble);
            Array.Reverse(arrayDouble);
            double a = arrayDouble[0];
            double b = arrayDouble[1];
            double c = arrayDouble[2];
            double potencia = 2;

            if (a >= b + c)
                Console.WriteLine("NAO FORMA TRIANGULO");
            else if (Math.Pow(a, potencia) == (Math.Pow(b, potencia) + Math.Pow(c, potencia)))
                Console.WriteLine("TRIANGULO RETANGULO");
            else if (Math.Pow(a, potencia) > (Math.Pow(b, potencia) + Math.Pow(c, potencia)))
            Console.WriteLine("TRIANGULO OBTUSANGULO");
            else if (Math.Pow(a, potencia) < (Math.Pow(b, potencia) + Math.Pow(c, potencia)))
                Console.WriteLine("TRIANGULO ACUTANGULO");
            if (a == b && a == c)
                Console.WriteLine("TRIANGULO EQUILATERO");
            if ((a == b && b != c) || (b == c && a != c) || (a == c && a != b))
            Console.WriteLine("TRIANGULO ISOSCELES");

            Console.ReadLine();
        }
    }
