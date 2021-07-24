using System;

namespace Reverse_String_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to My Reverse String Project");
            Console.WriteLine("Type a phrase and see what happens!");

            string UserInput = "";
            string Reverse = "";
            int Length = 0;
            //Above I defined variables UserInput & reverse as strings with no contents
            //I alsd defined a variable named Length as an integer which is 0
            //Below is my Readline command/function with its output named UserInput
            UserInput = Console.ReadLine();

            //Calculate length of string UserInput
            //Below I define a variable called Length which is The character length of what is typed minus 1
            //.Length is a property of a string or integer
            Length = UserInput.Length - 1;

            //The next step is to run a loop
            //This loop will run long as the value of Length is greater than or == to 0
            //Each time this loop runs it subtracts 1 from Length
            //This loop also changes the value of Reverse each time it runs which is a blank string to start
            //The 1st loop it displays the last character of the typed phrase based on the index value of what was typed
            //The 2nd loop displays the characters from the previous loop + the 2nd,3rd,4th... to last character as the index value will be 1 less as Length is getting smaller
            while (Length >= 0)
            {
                Reverse = Reverse + UserInput[Length];
                Length--;
            }
            //Displaying the reverse word
            //I don't under stand ("{0}", reverse) part of the code
            Console.WriteLine("{0}", Reverse);

        }
    }
}


/*
SAMPLE CODE/ TEST
  using System;
using System.Globalization;

namespace Reverse_String_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to My Reverse String Project");
            Console.WriteLine("Type a phrase and see what happens!");

            string UserInput = "";
            string reverse = "";

            int Length = 10 + 11 * 10;

            string test = "hello";
            int[] lotterynumbers = { 13, 42, 53, 46, 15 };

            int bla = 2;

            bool userIsDumb = true;
            while (userIsDumb)
            {

                string user = Console.ReadLine();
                if (user.Length > 1)
                {
                    Console.WriteLine(user[1]);
                    userIsDumb = false;
                }
                else
                {
                    Console.WriteLine("no bueno");
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(lotterynumbers[i]);
            }




            string UserInput2 = "hi";

            //Above I defined variables UserInput & reverse as strings with no contents
            //I alsd defined a variable named Length as an integer which is 0
            //Below is my Readline command/function with its output named UserInput
            UserInput = Console.ReadLine();

            int number;
            bool wasConverted = false;

            while (wasConverted == false)
            {
                Console.Write("whaevs");
                UserInput = Console.ReadLine();
                wasConverted = int.TryParse(UserInput, out number);
            }


            //Calculate length of string UserInput
            //Below I define a variable called Length which is The Phrased typed/ UserInput.Length -1
            //I dont understand how (.Length or ."variable) works but it appears to be an operator.
            Length = UserInput.Length - 1;

            string magic = Length.ToString();





            Console.WriteLine(Length);

            //This is a new code block
            //I don't understand it
            while (Length >= 0)
            {

                reverse = reverse + UserInput[Length];
                Length--;
            }
            //Displaying the reverse word
            //I don't under stand ("{0}", reverse) part of the code
            Console.WriteLine("{0}", reverse);

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            System.IO.File.Delete("C:\nudepics");

            //File.Delete("");

        }
    }
}
*/