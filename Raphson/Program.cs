using System;

namespace Newton_Raphson
{
    class Program
    {
    	
        static void Main(string[] args)
        {
            double xstart = -1.5;
            NewtonRaphson(xstart);
               
            Console.ReadKey();
        }

        static void NewtonRaphson(double startvalue)
        {
            const int cMaxIterations = 15;
            double Xn, Xn1 = 0.0;
            Console.WriteLine("Resolução pelo método de Newton Raphson");
            Console.WriteLine();
            Console.WriteLine("===========================");
            Console.WriteLine("Interação: " + 0);

            Console.WriteLine("x = " + startvalue);
            Console.WriteLine("f(x) = " + FunX(startvalue));
            Console.WriteLine("f'(x) = " + DevFunX(startvalue));
            Console.WriteLine("===========================");
            
            Xn = startvalue;

            for (int i = 1; i < cMaxIterations; i++)
            {
                Xn1 = Xn - FunX(Xn) / DevFunX(Xn); // Função da iteração

                //Console.WriteLine("|     {0,-10} | {1,15:0.00000} | {2,15:0.00000} | {3,15:0.00000} |       ", iter, Xn1, FunX(Xn1), DevFuncX(Xn1));
            	Console.WriteLine("Interação: " + i);    
                Console.WriteLine("x = " + Xn1);
	            Console.WriteLine("f(x) = " + FunX(Xn1));
	            Console.WriteLine("f'(x) = " + DevFunX(Xn1));
	            Console.WriteLine("===========================");
                
                if (Math.Abs(Xn - Xn1) < 0.0000001)
                {
                    Console.WriteLine("A raíz é: " + Xn1);
                    break;
                }
                else
                {
                    Xn = Xn1;
                }
            }
        }

        // Definição da função x^3 -5x + 5
        static double FunX(double x)
        {
            return Math.Pow(x, 3) - 5.0 * x + 5.0;
        }

        // Derivada da função x^3 -5x + 5: 3x^2 -5
        static double DevFunX(double x)
        {
            return 3.0 * Math.Pow(x, 2) - 5.0;
        }     
    }
}