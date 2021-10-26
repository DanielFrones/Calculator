using System;
using System.Collections.Generic;

namespace Miniräknare
{
    class Program
    {


        static void Main(string[] args)
        {
            string NameInput()
            {
                string name;
                Console.WriteLine("Skriv in ditt namn: ");
                name = Console.ReadLine();
                Console.WriteLine("Hej {0}, välkommen till kalkylatorn!", name);
                return name;
            }

            string CalcHistory()
            {

            }

            double CalcChosen()
            {

                //VARFÖR FUNKAR INTE TEXT FORMATERINGEN: ("{0}+{1}={2}, num1, num2, sum)" i Add funktionen?
                double sum = 0;
                char operatori;
                double num1;
                double num2;
                char goAgain = 'Y';
                List<string> inputs = new List<string> { };
                Console.WriteLine("Du får här skriva in två tal, och sedan operator. Tryck på valfri tangent för att fortsätta: ");
                Console.ReadKey();
                while (goAgain == 'Y')
                {

                
                Console.WriteLine("Skriv in tal1:");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Skriv in tal2:");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Skriv in vilken operator du vill använd: + ,-, *, /.");

                operatori = Convert.ToChar(Console.ReadLine());
                
                
                if(operatori == '+')
                {
                    sum = num1 + num2;
                    Console.WriteLine("Vill du göra en ny uträkning? Y/N");
                    goAgain = Convert.ToChar(Console.ReadLine());
                    inputs.Add(Convert.ToString(num1 + "+" + num2 + "=" + sum));
                }
                else if (operatori == '-')
                {
                    sum = num1 - num2;
                    Console.WriteLine("Vill du göra en ny uträkning? Y/N");
                    goAgain = Convert.ToChar(Console.ReadLine());
                    inputs.Add(Convert.ToString(num1 + "-" + num2 + "=" + sum));
                }
                else if (operatori == '*')
                {
                    sum = num1 * num2;
                    Console.WriteLine("Vill du göra en ny uträkning? Y/N");
                    goAgain = Convert.ToChar(Console.ReadLine());
                    inputs.Add(Convert.ToString(num1 + "*" + num2 + "=" + sum));
                }
                else
                {
                    sum  = num1 / num2;
                    Console.WriteLine("Vill du göra en ny uträkning? Y/N");
                    goAgain = Convert.ToChar(Console.ReadLine());
                    inputs.Add(Convert.ToString(num1 +"/"+ num2 + "=" + sum));

                    
                }
                }

                Console.WriteLine("Dina uträkningar blev följande: ");
                foreach (var item in inputs)
                {
                    Console.Write(item + " ");
                }


                return sum;

            }

             


            
            

            NameInput();
            CalcChosen();



        }
    }
}
