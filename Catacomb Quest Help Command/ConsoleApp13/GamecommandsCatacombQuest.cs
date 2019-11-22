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
            Console.WriteLine("Welcome to Catacomb Quest!");
            Console.WriteLine("~ To see the list of commands type [ /help ]!");
             
           
            string command;
            bool quitNow = false;
            while (!quitNow)
            {
           
                command = Console.ReadLine();
                switch (command)

                {
                    case "/help":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("List of Game Commands: \n<Movement>: /north, /east, /south, /west \n<Other>: /look, /search, /backpack, /direction\n~ /north - move North\n~ /east - move East\n~ /south - move South\n~ /west - move West\n~ /look - checks to see if there is any objects in the room\n~ /search - searches the room for any objects\n~ /backpack - Inventory, everytime you pickup an item you will be asked wheter you want to keep it or not, kept items go into your backpack\n~ /direction - check to see which direction you are facing (N,E,S,W)");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case "/look":
                        Console.WriteLine("You looked inside the room");
                        break;
                    case "/search":
                        Console.WriteLine("Searching...");
                        break;
                    case "/backpack":
                        Console.WriteLine("You opened up your backpack, the contents of your backpack are: ");
                        break;
                    case "/direction":
                        Console.WriteLine("You are facing $");
                        break;
                    default:
                        // outputs this if the command typed in doesn't exist
                        Console.WriteLine("The command doesn't exist! Type [ /help ] to see the list of commands!");
                        break;




                }
            }
        } 
    }
}
