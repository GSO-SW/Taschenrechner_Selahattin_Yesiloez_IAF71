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

            string choice = "";

            char op = ' ';
            double zahl1 = 0;
            double zahl2 = 0;
            int Exponent = 0;
            do
            {
                Console.Clear();

                Console.Write("Welche Rechenoperation möchten Sie durchführen : + / * - oder P für eine Potenz Rechnung\n Eingabe : ");
                op = Convert.ToChar(Console.ReadLine());
                
                Console.Write("Geben Sie eine Zahl ein: ");
                zahl1 = Convert.ToDouble(Console.ReadLine());
                if (op != 'p' && op != 'P') {
                    Console.Write("Geben Sie eine zweite Zahl : ");
                    zahl2 = Convert.ToDouble(Console.ReadLine());
                }
                else if (op == 'p' || op == 'P')
                {
                    Console.Write("Geben Sie bitte den Exponent ein : ");
                    Exponent = Convert.ToInt32(Console.ReadLine());

                }
                switch (op)
                {
                    case '+':
                        Console.Write("\n\nDas Ergebnis : {0}", zahl1 + zahl2);
                        break;
                    case '-':
                        Console.Write("\n\nDas Ergebnis : {0}", zahl1 - zahl2);
                        break;
                    case '*':
                        Console.Write("\n\nDas Ergebnis : {0}", zahl1 * zahl2);
                        break;
                    case '/':
                        Console.Write("\n\nDas Ergebnis : {0}", zahl1 / zahl2);
                        break;
                    case 'P':
                        double a = zahl1;
                        for (int i = 0; i < Exponent - 1; i++)
                        {
                            a = a * zahl1; 
                        } 
                        Console.Write("\n\nDas Ergebnis : {0}", a);
                        break;
                    case 'p':
                        double b = zahl1;
                        for (int i = 0; i < Exponent - 1; i++)
                        {
                            b = b * zahl1;
                        }
                        Console.Write("\n\nDas Ergebnis : {0}", b);
                        break;

                }

                

                
                Console.Write("\n\nErneut : J\\N");
                Console.Write(" Entscheidung : ");
                choice = Console.ReadLine();
            } while (choice == "J" || choice == "j");
        

        }  
    }
}
