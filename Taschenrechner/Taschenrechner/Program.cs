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

            char op = 'a';

            do
            {
                Console.Clear();

                Console.Write("Welche Rechenoperation möchten Sie durchführen : + : * - \n Eingabe : ");
                op = Convert.ToChar(Console.ReadLine());

                Console.Write("Geben Sie die erste Zahl : ");
                int zahl1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Geben Sie die zweite Zahl : ");
                int zahl2 = Convert.ToInt32(Console.ReadLine());
                
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
                }

                

                
                Console.Write("\n\nErneut : J\\N");
                Console.Write(" Entscheidung : ");
                choice = Console.ReadLine();
            } while (choice == "J" || choice == "j");
        

        }  
    }
}
