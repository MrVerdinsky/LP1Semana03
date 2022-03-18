using System;

namespace PercorreString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user for string
            //Ask user a character
            //Print string without character chosen
           
            while (true)
            {
                bool valueString = false;
                bool valueChar = false;
                string inputString = " ";
                string newString = " ";
                char validChar = ' ';

                //Cycle that asks the user for a string
                while (!valueString)
                {
                    Console.Write("Insert String: ");
                    inputString = Console.ReadLine();
                    if(inputString != " ") valueString = true;
                    if(inputString == "exit") System.Environment.Exit(0);
                }

                //Cycle that asks the user for a char
                while (!valueChar)
                {
                    string inputChar;
                    Console.Write("Insert Char to Eliminate: ");
                    if (!char.TryParse(inputChar = Console.ReadLine(), out validChar))
                    {
                        Console.WriteLine("Invalid Value");
                    }
                    else valueChar = true; 
                }

                //Cycle that goes along the input string
                //and removes all the chars equal to the chosen one
                for (int i = 0; i < inputString.Length; i++)
                {
                    
                    if (inputString[i] == validChar) continue;

                    else newString += inputString[i];


                }
                Console.WriteLine("");
                Console.WriteLine($"Input String: {inputString}");
                Console.WriteLine($"Input Char: {validChar}");
                Console.WriteLine($"New String with Char Removed: {newString}");
                Console.WriteLine("");
            }

        }
    }
}
