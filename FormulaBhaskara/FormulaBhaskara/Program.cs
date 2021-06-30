using System;

public class minhaClasse
{
    public static void Main(string[] args)
    {
        double a, b, c, delta, r1, r2, raiz;
        string[] valor = Console.ReadLine().Split();

        a = Convert.ToDouble(valor[0]);
        b = Convert.ToDouble(valor[1]);
        c = Convert.ToDouble(valor[2]);

        delta = (Math.Pow(b, 2) - (4 * a * c));
        raiz = Math.Sqrt(delta);

        if (a != 0 && raiz >= 0 )
        {
            r1 = (-b + raiz) / (2 * a);
            r2 = (-b - raiz) / (2 * a);
            Console.WriteLine("R1 = {0}", r1.ToString("0.00000"));
            Console.WriteLine("R2 = {0}", r2.ToString("0.00000"));
        }
        else
        {
            Console.WriteLine("Impossivel calcular");
        }
    }
}
