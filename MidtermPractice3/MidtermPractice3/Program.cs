using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermPractice3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter the cost of your power bill each month 
            //if the power bill average is under 200 output good job saving power
          
            //if 300 to 500 +, let user choose one way to save power from list 
            //if invalid response to choices, let try again once.

            int counter;
            counter = 1;
            Console.WriteLine("\tPower Saving Application");
            Console.WriteLine();//blank

            string billInput;
            double bills;
            double sum = 0;

            double average;
            string choice;

            while (counter >= 1 && counter <= 12)
            {
                Console.Write("Please enter the amount of your power bill for {0}: ", counter);

                billInput = Console.ReadLine();

                bills = double.Parse(billInput);
                sum = sum + bills;
                counter++;
            }

            Console.WriteLine();//blank
            average = sum / 12;

            if (average < 200)
            {
                Console.WriteLine("Your average cost is {0:C}.  Good Job!", average);
            }

            else if (average >= 200 && average < 300)
            {
                Console.WriteLine("Your average cost is {0:C}.", average);


            }

            else if (average >= 300 && average < 400)
            {
                Console.WriteLine("Your average cost is {0:C}.", average);


            }

            else if (average >= 400 && average < 500)
            {
                Console.WriteLine("Your average cost is {0:C}.", average);

            }

            else if (average >= 500)
            {
                Console.WriteLine("Your average cost is {0:C}.", average);

            }

            Console.WriteLine();//blank
            if (average >=300)

            {
                Console.WriteLine("Choose how you want to save power from the following:");
                Console.WriteLine("(A) save power by cutting off lights.");
                Console.WriteLine("(B) save power by getting new energy effcient appliances.");
                Console.WriteLine("(C) save power by watching less tv.");
                Console.WriteLine("(D) save power by shutting off the main power source during the day.");

                choice = Console.ReadLine();
                
                switch (choice)
                { case "A":
                    case "a":
                        Console.WriteLine("You have chosen to save power by cutting off lights.");
                        break;

                    case "B":
                    case "b":
                        Console.WriteLine("You have chosen to save power by getting new energy effcient appliances.");
                        break;

                    case "C":
                    case "c":
                        Console.WriteLine("You have chosen to save power by watching less tv. ");
                        break;

                    case "D":
                    case "d":
                        Console.WriteLine("You have chosen to save power by shutting off the main power source during the day." );
                        break;

                    default:
                        Console.WriteLine("Invalid response.");
                        Console.WriteLine("Choose how you want to save power from the following:");
                        Console.WriteLine("(A) save power by cutting off lights.");
                        Console.WriteLine("(B) save power by getting new energy effcient appliances.");
                        Console.WriteLine("(C) save power by watching less tv.");
                        Console.WriteLine("(D) save power by shutting off the main power source during the day.");

                        choice = Console.ReadLine();

                        if (choice == "A" || choice == "a")
                        { Console.WriteLine("You have chosen to save power by cutting off lights."); }
                        else if (choice == "B" || choice == "b")
                        { Console.WriteLine("You have chosen to save power by getting new energy effcient appliances."); }
                        else if (choice== "C" || choice == "c")
                        { Console.WriteLine("You have chosen to save power by watching less tv."); }
                        else if (choice == "D" ||choice == "d")
                        { Console.WriteLine("You have chosen to save power by shutting off the main power source during the day."); }
                        else
                        { Console.WriteLine("Invalid response.  Goodbye."); }


                        break;
                }

            }




                Console.ReadKey();

           
        }
    }
}
