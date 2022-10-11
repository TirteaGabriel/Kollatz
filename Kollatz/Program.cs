using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kollatz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lungimea secventei Kollatz
            /* int n=10;
            int k = 1;
            Console.Write($"{n} ");
            while (n!= 1)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                    k++;
                }
                else
                {
                    n = 3 * n + 1;
                }
                    Console.Write($"{n} ");
            }
            Console.WriteLine();
            Console.WriteLine("Lungimea secventei este:" + k);
            */


            //Cea mai mare valoare din secventa Kollatz
            /* int n =1000;
            int maxim = 0;
            Console.Write($"{n} ");
            while (n != 1)
            {
                if (n % 2 == 0)
                    n = n / 2;
                else
                    n = 3 * n + 1;
                if(n > maxim)
                    maxim = n;
                Console.Write(n + " ");
            }
            Console.WriteLine("Cea mai mare valoare este:" + maxim);
            */


            //Numarul cu cea mai lunga secventa Kollatz din [a,b]
            /* int a=10,b=20;
            int maxim = 0;
            int numarul = 0;
            for(int i = a; i <= b; i++)
            {
                int k = 0;
                int aux = i;
                Console.Write(aux + " ");
                while (aux != 1)
                {
                    if(aux % 2 == 0)
                    {
                        aux = aux / 2;
                        k++;
                    }
                    else
                    {
                        aux = 3 * aux + 1;
                        k++;
                    }
                    if(k > maxim)
                    {
                        maxim = k;
                        numarul = i;
                    }
                    Console.Write(aux + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Numarul este:" + numarul);
            */
            Console.ReadKey();
        }
    }
}
