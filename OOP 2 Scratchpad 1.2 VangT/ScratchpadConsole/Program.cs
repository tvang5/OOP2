using System;
using Airports;

namespace ScratchpadConsole
{
    /// <summary>
    /// Class which is used to represent a program's console.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The console that is used to interact with the scratchpad.
        /// </summary>
        /// <param name="args">String array that represents the command-line arguments.</param>
        public static void Main(string[] args)
        {
            Console.Title = "Object-Oriented Programming 2: Scratchpad";

            bool exit = false;

            while (!exit)
            {
                Console.Write("]");

                string command = Console.ReadLine();

                switch (command)
                {
                    case "exit":
                        exit = true;

                        break;
                    case "new":
                        Airport dfw = new Airport();

                        break;
                    default:
                        Console.WriteLine("Invalid command entered.");

                        break;
                }
            }
        }
    }
}
