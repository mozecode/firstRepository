using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {// enter password and only accept incorrect passwords 3 times before outputting goodbye.
            //if password is correct, input name, age, and base cost per month of an insurance policy.  If the age of the 
         //patient is over 40, double the cost of the insurance policy.  If age is over 50, triple.
         //If over 60, quadruple.  If over 65, output a message saying "You need to sign up for 
         //Medicare"  If any of the information is entered incorrectly, output an error message and 
         //allow them to re-enter. At end, calculate cost per year for patient.

            string firstName, ageInput, password;
            int age, count;
            double cost, totalCost;
            count = 1;

            Console.Write("Please enter your password: ");
            password = Console.ReadLine();
            Console.Clear();

            
            while (password != "Qwerty999!" && count < 3)
            {
                Console.WriteLine("Error.  Incorrect password entered.  Please try again: ");
                Console.Write("Please enter your password: ");
                password = Console.ReadLine();
                count++;
                Console.Clear();

                if (password != "Qwerty999!" && count >= 3)
                {
                    Console.WriteLine("Goodbye.");
                    Console.ReadKey();

                }

            }

           
            if (password == "Qwerty999!")
            { Console.Write("Please enter patient name: ");

                firstName = Console.ReadLine();
                Console.WriteLine();//blank

                Console.Write("Please enter age of patient: ");

                ageInput = Console.ReadLine();
                age = int.Parse(ageInput);
                Console.WriteLine();//blank 


                cost = 100;
                Console.WriteLine();//blank


                if (age >= 40 && age < 50)
                {
                    cost = cost * 2;

                }
                else if (age >= 50 && age < 60)

                {
                    cost = cost * 3;
                }

                else if (age >= 60 && age < 65)
                {
                    cost = cost * 4;
                }

                else if (age >= 65)
                {
                    Console.WriteLine("Please sign up for Medicare.");
                }

                totalCost = cost * 12;

                if (age < 65)

                {
                    Console.WriteLine("{0}, your cost per month is {1:C}.  Your cost per year is {2:C}.", firstName, cost, totalCost);


                }

                // Write a program in C# Sharp to display the n terms of even natural number and 
                //their sum.

                Console.WriteLine( ); //blank
                string numberInput;
                int number, minNumber, sum;
                minNumber = 2;
                sum = 0;

                Console.WriteLine("Please input a number:  ");
                numberInput = Console.ReadLine();
                number = int.Parse(numberInput);

                while (minNumber <= number)
                {
                    Console.Write("{0}  ", minNumber);

                    minNumber = minNumber + 2;
                    sum = sum + minNumber;
                }
               
                Console.WriteLine("The sum of the even numbers up to and including {0} is {1}.", number, sum-number);
                
                Console.ReadKey();
            }
        }
    }
}
