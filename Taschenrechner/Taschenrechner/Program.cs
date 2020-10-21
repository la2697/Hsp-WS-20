using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Versuch Taschenrechner");

            Console.WriteLine("Gebe zwei Zahlen");

            Console.Write("erste Zahl:  ");

            double zahl1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Zweite Zahl:  ");

           

            double zahl2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Was soll getan werden? * = multiplizieren + = addieren - = subtrahieren / = dividieren n");

            char eingabe = Convert.ToChar(Console.ReadLine());


            switch (eingabe)

            {

                case '*':

                    Console.WriteLine( + (zahl1) + " * " + (zahl2) + " ist: " + (zahl1 * zahl2));

                    break;

                case '+':

                    Console.WriteLine( + (zahl1) + " + " + (zahl2) + " ist: " + (zahl1 + zahl2));

                    break;

                case '-':

                    Console.WriteLine( + (zahl1) + " - " + (zahl2) + " ist: " + (zahl1 - zahl2));

                    break;

                case '/':

                    Console.WriteLine( + (zahl1) + " / " + (zahl2) + " ist: " + (zahl1 / zahl2));

                    break;



                default:

                    Console.WriteLine("Nur *,+,-,/ eingeben");

                    break;

            }



            Console.ReadLine();
        }
    }
}
