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

        

           
           
            
            string rechnung = "";
            List<string> rechnungsdetails = new List<string>();
            double endErgebnis = 0;
            do
            {
                Console.Clear();

                Console.Write("Geben Sie ihre Rechnung an : ");
                rechnung = Console.ReadLine();
                bool check = false;
                for (int i = 0; i < rechnung.Length; i++)
                {
                    if (char.IsDigit(rechnung[i]))
                    {
                        if (check == true)
                        {
                            rechnungsdetails[rechnungsdetails.Count() - 1] += rechnung[i];
                        }
                        else if (check == false)
                        {
                            rechnungsdetails.Add(rechnung[i].ToString());
                        }
                        check = true;
                    }
                    else if (rechnung[i] == ',')
                    {
                        rechnungsdetails[rechnungsdetails.Count() - 1] += rechnung[i];

                    }
                    else if (rechnung[i] == '+' || rechnung[i] == '-' || rechnung[i] == '/' || rechnung[i] == '*')
                    {
                        rechnungsdetails.Add(rechnung[i].ToString());
                        check = false;
                    }
                }

                for (int i = 0; i < rechnungsdetails.Count(); i++)
                {
                    if (rechnungsdetails[i] == '*'.ToString())
                    {
                        if (!char.IsDigit(rechnungsdetails[i + 1][0]))
                        {
                            rechnungsdetails[i + 1] += rechnungsdetails[i + 2];
                            rechnungsdetails.RemoveAt(i + 2);
                        }
                        string ergebnis = (Convert.ToDouble(rechnungsdetails[i - 1]) * Convert.ToDouble(rechnungsdetails[i + 1])).ToString();
                        rechnungsdetails.RemoveAt(i + 1);
                        rechnungsdetails.RemoveAt(i);
                        rechnungsdetails.RemoveAt(i - 1);
                        rechnungsdetails.Insert(i - 1, ergebnis);
                        i = 0;

                    }
                    else if (rechnungsdetails[i] == '/'.ToString())
                    {
                        if (!char.IsDigit(rechnungsdetails[i + 1][0]))
                        {
                            rechnungsdetails[i + 1] += rechnungsdetails[i + 2];
                            rechnungsdetails.RemoveAt(i + 2);
                        }
                        string ergebnis = (Convert.ToDouble(rechnungsdetails[i - 1]) / Convert.ToDouble(rechnungsdetails[i + 1])).ToString();
                        rechnungsdetails.RemoveAt(i + 1);
                        rechnungsdetails.RemoveAt(i);
                        rechnungsdetails.RemoveAt(i - 1);
                        rechnungsdetails.Insert(i - 1, ergebnis);
                        i = 0;
                    }
                }
                

                for (int i = 0; i < rechnungsdetails.Count; i++)
                {
                    if (rechnungsdetails[i] == '+'.ToString())
                    {
                        if (!char.IsDigit(rechnungsdetails[i + 1][0]))
                        {
                            rechnungsdetails[i + 1] += rechnungsdetails[i + 2];
                            rechnungsdetails.RemoveAt(i + 2);
                        }
                        endErgebnis += Convert.ToDouble(rechnungsdetails[i + 1]);
                    }
                    else if (rechnungsdetails[i] == '-'.ToString())
                    {
                        if (!char.IsDigit(rechnungsdetails[i + 1][0]))
                        {
                            rechnungsdetails[i + 1] += rechnungsdetails[i + 2];
                            rechnungsdetails.RemoveAt(i + 2);
                        }
                        endErgebnis -= Convert.ToDouble(rechnungsdetails[i + 1]);
                    }
                    else if (i == 0) 
                    {
                        endErgebnis = Convert.ToDouble(rechnungsdetails[i]);
                    }
                }



                Console.WriteLine(endErgebnis.ToString());

                
                Console.ReadLine();
            } while (true);


        }
    }
}
