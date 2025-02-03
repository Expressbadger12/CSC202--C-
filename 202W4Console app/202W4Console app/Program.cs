using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 30; //Intergers: whole numbers, negative and positive, but no fractions or decimals
            double myDoubleNumber = 3.14; // float/double (double can hold 16 numbers float just 7ish): integers with decimals
            char myLetterGrade = 'A'; // char or characters are single lettters in single'' quotes
            bool graduated = false; // boolean: true or false
            string myText = "Welcome to C# class cSC202*****_*"; //string: "anything"



            //if statement
            Console.WriteLine("Enter number1");
            int number1;
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2");
            int number2;
            number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2)
            {
                Console.WriteLine("number1 is greater than number2");
            }
            else if (number1 < number2)
            {
                Console.WriteLine("number2 is greater than number1");
            }
            else
            {
                Console.WriteLine("number 1 is equal to number 2");
            }
            /*
                        int time = 5;
                        if (time < 10)
                        {
                            Console.WriteLine("Good morning");
                        } else if (time <20)
                        {
                            Console.WriteLine("Good Day");
                        }else
                        {
                            Console.WriteLine("Good evening");
                        }
                      */




            /*
             //user input output
                        Console.WriteLine("What is your name?");
                        string userName;
                        userName = Console.ReadLine();
                        //= means assigning == checks if its equal
                        Console.WriteLine("Your name is: " + userName);

                        Console.WriteLine("What is your age?");
                        int userAge;
                        userAge = Convert.ToInt32(Console.ReadLine());
                        //= means assigning == checks if its equal
                        Console.WriteLine("You are " + userAge + " years old");
            */

        }
    }
}