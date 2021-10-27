using System;
using System.Collections.Generic;

namespace Miniräknare
{
    class Program
    {


        static void Main(string[] args)
        {
            bool goAgain = true;
            
            char operatori;
            double num1;
            double num2;
            double sum = 0;
            List<string> inputs = new List<string> { };
            //Bättre att göra en lista utanför i en metod istället? Hur kopplar jag den isf?

            /*string CalcHistory()
            {
                List<string> inputs = new List<string> { };

            }
            */
            NameInput();
            Calculation();
  

            double Calculation()
            {
                Console.WriteLine("Du får här skriva in två tal, och sedan operator. Tryck på valfri tangent för att fortsätta: ");
                Console.ReadKey();

                while (goAgain)
                {
                    Operatori();

                    //VARFÖR FUNKAR INTE TEXT FORMATERINGEN: ("{0}+{1}={2}, num1, num2, sum)" i Add funktionen?
                    if (operatori == '+')
                    {
                        sum = num1 + num2;
                       

                        inputs.Add(Convert.ToString(num1 + "+" + num2 + "=" + sum));
                        
                    }
                    else if (operatori == '-')
                    {
                        sum = num1 - num2;
                        

                        inputs.Add(Convert.ToString(num1 + "-" + num2 + "=" + sum));
                    }
                    else if (operatori == '*')
                    {
                        sum = num1 * num2;
                        

                        inputs.Add(Convert.ToString(num1 + "*" + num2 + "=" + sum));
                      

                    }
                    else
                    {
                        sum = num1 / num2;
                        

                        inputs.Add(Convert.ToString(num1 + "/" + num2 + "=" + sum));


                    }
                    GoAgain();
                }
                
                return sum;
            }

            void Sums()
            {
                
                Console.WriteLine("");
                Console.WriteLine("Dina uträkningar blev följande: ");
                foreach (var item in inputs)
                {
                    Console.WriteLine(item + " ");
                }
               
            }
            string NameInput()
            {
                string name;
                Console.WriteLine("Kalkylator retardo 2.4");
                Console.WriteLine("Skriv in ditt namn: ");
                name = Console.ReadLine();
                Console.WriteLine("Hej {0}, välkommen till kalkylatorn!", name);
                return name;
            }
            char Operatori()
            {
                
                Console.WriteLine("Skriv in tal1:");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Skriv in tal2:");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Skriv in vilken operator du vill använd: + ,-, *, /.");

                operatori = Convert.ToChar(Console.ReadLine());
                return operatori;
            }
            bool GoAgain()
            {
                
                Console.WriteLine("Vill du göra en ny uträkning? (OBS Stor bokstav!) Y/N");
                char goAgains = Convert.ToChar(Console.ReadLine());
                if(goAgains == 'Y')
                {
                    goAgain = true;
                }
                else
                {
                    goAgain = false;
                    Console.WriteLine("Vill du se dina uträkningar? Y/N");
                    char countAgain = Convert.ToChar(Console.ReadLine());
                    if(countAgain == 'Y')
                    {
                        Sums();
                        GoAgain();
                    }
                    else
                    {
                        Console.WriteLine("Vill du göra en ny uträkning, eller vill du avsluta 1= Ny uträkning 2 = Avsluta");
                        int terminate = Convert.ToInt32(Console.ReadLine());
                        if(terminate == 1)
                        {
                            GoAgain();
                        }
                        else
                        {
                            Console.WriteLine("slut"); // TERMINATE?!
                        }
                    }

                }
                return goAgain;
            }




            /* Console.WriteLine("Dina uträkningar blev följande: ");
                foreach (var item in inputs)
                {
                    Console.WriteLine(item + " ");
              // HUR SPARAR JAG NER CALC HISTORY TILL METOD? BEST PRACTICE-TÄNK? ÄR DET DUMT ATT GÖRA SÅHÄR?CalcHistory() = inputs.Add(Convert.ToString(num1 + "*" + num2 + "=" + sum));
                }
               */


        }
    }
}
