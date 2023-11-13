using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeropar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sacar la suma de los numeros pares de un rango de valores que el usuario indique 
            int n1, n2, total = 0;//n1 inicio del rango y n2 es el fin del rango.
            bool banderaN1=false, banderaN2=false;
            Console.WriteLine("Ingrese el valor de N1");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de N2");
            n2 = int.Parse(Console.ReadLine());

            if (n1>=0 && n1<n2)
            {
                banderaN1 = true;
            }
            else
            {
                Console.WriteLine("N1 no cumple con la condicion");
            }

            if (n2>n1)
            {
                banderaN2 = true;
            }
            else
            {
                Console.WriteLine("N2 no cumple con la condicion");
            }

            if ((banderaN1 && banderaN2))
            {
                for (int i = n1; i <= n2; i++)
                {
                    if (i % 2==0)
                    {
                        total = total + i;
                    }
                }
            }   Console.WriteLine("La suma de los numeros pares dentro del rango es: " + total);
        }
    }
}
