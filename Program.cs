using System;

namespace formula_bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {            
            double A, B, C, x1, x2, delta;
            string[] entrada;

            entrada = Console.ReadLine().Split(' ');
            A = double.Parse(entrada[0]);
            B = double.Parse(entrada[1]);
            C = double.Parse(entrada[2]);

            delta = (Math.Pow(B,2)) - (4 * A * C);

            if ( delta < 0 || A == 0) {
                Console.WriteLine("Impossivel calcular");
            }
            else {
            
                x1 = (-B + Math.Sqrt(delta)) / (2 * A);
                x2 = (-B - Math.Sqrt(delta)) / (2 * A);

                Console.WriteLine("R1 = " + x1.ToString("F5"));
                Console.WriteLine("R2 = " + x2.ToString("F5"));
            }    
        }   
    }
}
