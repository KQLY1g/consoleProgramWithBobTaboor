using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleProgramWithBobTaboor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                //Writes the given line "What is your name?"
                Console.WriteLine("What is your name?");
                //writes the following right after the prior
                Console.Write("type your first name: ");

                //Used to store a string of text
                string myFirstName;
                //Assigns whatever the user has written to the given string
                myFirstName = Console.ReadLine();

                //String for my last name
                string myLastName;
                //Writes type last name
                Console.Write("Type your last name: ");
                //Assigns whatever the user writes to myLastName
                myLastName = Console.ReadLine();

                //then i add hello myFirstName and myLastName together
                Console.WriteLine("hello, " + myFirstName + " "+ myLastName);
                //Used to pause the program
                Console.ReadLine();
            */
            start:
            Console.WriteLine("Hello, and welcome to my gameshow.");
            Console.Write("please choose a door: 1, 2 or 3: ");

            string valueEntered = Console.ReadLine();
            string message = "";

            if (valueEntered == "1")
                message = "you picked door # 1";
            else if (valueEntered == "2")
                message = "You picked door # 2";
            else if (valueEntered == "3")
                message = "You picked door # 3";
            else
                message = "Sorry, please choose a door.";

            Console.WriteLine(message);
            Console.ReadLine();

            goto start;
        }
    }
}
