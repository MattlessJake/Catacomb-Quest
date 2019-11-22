using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Catacomb Quest";
            Console.WriteLine("Welcome to Catacomb Quest");
            Console.WriteLine("To see the list of game commands type [ /help ]");
            
            string command;
            bool quitNow = false;
            while (!quitNow)
            {
           
                command = Console.ReadLine();
                switch (command)

                {

                    case "/help":
                        Console.WriteLine("List of Game Commands:");
                        Console.WriteLine("<Movement>: North, East, South, West");
                        Console.WriteLine("<Other>: Look, Search");
                        break;

                    case "/look":
                        Console.WriteLine("You looked inside the room");
                        break;
                    case "/search":
                        Console.WriteLine("Searching...");
                        break;
                   
                    default:
                        Console.WriteLine("Unknown Command, type [ /help ] for the list of commands");
                        break;




                }
            }
        } 
    }
}
