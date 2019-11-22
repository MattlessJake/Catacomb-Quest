using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace textadventuregame
{





    class Program
    {


        //public class RoomIdentifier
        //{
        //    public int RoomID { get; set; }
        //    public string RoomName { get; set; }
        //}

        //IList<RoomIdentifier> roomList = new List<RoomIdentifier>()
        //{
        //    new Room() { RoomID = A1, RoomName = " " },

        //};

        public enum Compass
        { North, East, South, West };



        public class TimerLantern
        {
            public string TimerLant { get; set; }
            public static object aTimer;

        }




        public class Maze
        {


        }

        public string Description { get; set; }

        public class Room : Maze
        {
            // Max 4 doors to a room
            // Description

            

        }

        public class Door
        {
            // Needs a NESW function, to determine which way to go

        }

        public class Corridor : Room
        {
            // All Corridors MUST be linked to a Room

        }



        public class ItemObject : Room
        {
            // Max 2 items in a room (must have some sort of identifier of what is in the room(description)

        }

        // ---------------- 
        private class Location
        {

        }

        private class Direction
        {

        }

        public class ObjectItems
        {

        }

        //                                                           ----------- CHEST
        public class Chest
        {
            // determining whether the chest has items inside or not (if no then chest unlootable)
            bool hasItems = true;
            bool noItems = false;

            // mix and max value for chest
            protected const int maxItemChest = 3;
            protected const int minItemChest = 0;


            public class InChest
            {
                // this is for knowing what is inside the chest
                bool whatsInside = true;


            }


            public class OpenChest
            {
                bool isOpen = true;
            }

        }


        //                                                           ----------- LANTERN
        public class Lantern : ObjectItems
        {
            // needs to be some sort of time feature??
            bool LantOn = true;
            bool LantOff = false;


        }
        //                                                           ----------- OIL
        public class Oil : Lantern 
        {
            // you will need oil to light the lantern

        }

        //                                                           ----------- MATCHES
        public class Matches : Lantern
        {
            // matches will be used to light the lantern, AFTER it has oil in it

            bool hasOil = true;
            bool noOil = false;

                

        }

        


        //                                                           ----------- KEY
        public class Key : ObjectItems
        {
            // key to possible open chest

            bool hasKey = true;

        }

        //                                                           ----------- DAGGER
        public class Dagger : ObjectItems
        {
            // NEED a damage system 
        }


        //                                                           ----------- BANDAGES
        public class Bandages
        {
            // when health feature has been made this will heal you
            // max health points
            // min health points
            // max heal power (of bandage)

        }




        public enum WhichLoot
        {
            // List of all Loot names, being set into a drop chance feature
            Dagger, Lantern, Key, Matches, Oil, Bandages

            
        };


        // ------------------ LOOT CHOOSE

        private class GetLoot
        {
            
        }

        public string[] helpMe = { " go North, go South, go East, go West " };





        public class DropChance : ObjectItems
        {
            // % chance of drop, node feature? (put in certain places, for example lantern only spawns in chest)

            protected int[] lootChance = new int[]
            {
                10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 
            };

            protected const int maxChance = 100;

            // Dagger 10%
            // Lantern 40%
            // Key 80%
            // Matches 50%
            // Oil 30%
            // Bandages 50%
            // will somehow be a max item of 3
            
            

        }



        

        public class NodeGenerator: Room
        {
            List<WhichLoot> nodeDefinitions = new List<WhichLoot>();

            public NodeGenerator()
            {
            }

            


        //public Boolean CreateNode()
    }


        public class WherePut : Room
        {
            // this feature is to decide how many objects can be put into a room, which rooms etc (don't want objects in corridors)

            long[] whatToCalc = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, Int64.MaxValue / 2 };

            int newNumber;


        }

        

        private void Action()
        {
            
        }
        public class Sorter
        {
            

            
        }


       





        private class ErrorHandling
        {
            string ErrorCatch = "Catching Errors";

            bool caughtError = true;

        } 





        // ----------- DICTIONARY

            public Dictionary<helpMe, string> helpTxt { get; set; }




        static void Main(string[] args)
        {

            //                                                           ------------------------------------------------------- CHEST


            //                                                           ----------- DOES IT HAVE A KEY?
            //bool hasKey = true;

            //if (hasKey)
            //{
            //    Console.WriteLine("You turn the Key, you hear a faint click ");
            //}

            //else
            //{
            //    Console.WriteLine("The Chest is locked");
            //}


            ////                                                           ----------- IS THE CHEST OPEN?

            //bool isOpen = true;



            //if (isOpen)
            //{
            //    Console.WriteLine("You have opened the Chest ");
            //}

            //else
            //{
            //    Console.WriteLine(" ");
            //}



            ////                                                           ----------- ITEMS IN CHEST
            //int WhatIsIt = 999;

            //switch (WhatIsIt)
            //{
            //    case 1:
            //        Console.WriteLine($"You have found: !");
            //        break;
            //    case 2:
            //        Console.WriteLine($"You have found: !");
            //        break;
            //    case 3:
            //        Console.WriteLine($"You have found: !");
            //        break;
            //    default:
            //        Console.WriteLine(" Nothing in this Chest");
            //        break;
            //}

            ////                                                           ----------- DOES CHEST HAVE ITEMS?
            //int hasItems = 999;

            //switch (hasItems)
            //{
            //    case 1:
            //        Console.WriteLine($" ");
            //        break;
            //    case 2:
            //        Console.WriteLine($" There is no items in this Chest");
            //        break;


            //}




            ////                                                           ------------------------------------------------------- ENDCHEST

            ////                                                           ----------- LANTERN FEATURES
            //string LantOn = "Your Lantern is On";

            //switch (LantOn)
            //{
            //    case "/lantern":
            //        Console.WriteLine("Your Lantern has been turned on");
            //        break;
            //    case "Your Lantern is Off":
            //        Console.WriteLine("Your Lantern has been turned off");
            //        break;
            //}

            //Console.WriteLine(LantOn);
            //Console.ReadKey();


            ////                        ----------- DOES IT HAVE OIL?
            //bool hasOil = true;

            //if (hasOil)
            //{
            //    Console.WriteLine(" Your Lantern has Oil ");
            //}

            //else
            //{
            //    Console.WriteLine(" Your Lantern does not have Oil, you cannot light this");
            //}


            ////                        ----------- DO YOU HAVE MATCHES?
            //bool hasMatches = true;

            //if (hasMatches)
            //{
            //    Console.WriteLine(" Your Lantern has Oil, and you Light the Lantern ");
            //}

            //else
            //{
            //    Console.WriteLine(" You do not have any Matches!");
            //}



            ////                                                           ----------- ITEMS


            ////                        ----------- OBTAINABLE ITEMS

            //var random = new Random();
            ////                                                    LIST OF OBTAINABLE ITEMS  =   Dagger, Lantern, Key, Matches, Oil, Bandages
            //var list = new List<string> { "Dagger", "Lantern", "Key", "Matches", "Oil", "Bandages" };
            //int index = random.Next(list.Count);
            //Console.WriteLine(list[index]);

            //Console.ReadKey();










            ////                                                           ----------- CATCHING ERRORS
            //bool ErrorCatch = true;

            //if (ErrorCatch)
            //{
            //    Console.WriteLine(" An Error has been found in your Code! FIX IMMEDIATLEY");
            //}

            //else
            //{
            //    Console.WriteLine(" ");
            //}







            ////                                                           ----------- NOT RELEVANT CURRENTLY
            //int num;
            //Console.WriteLine("Enter a command: ");
            //num = Convert.ToInt32(Console.ReadLine());










            //Console.WriteLine("Hello. Please state your name.");

            //string name = Console.ReadLine();

            //Console.WriteLine("Hello {0} where would you like to go? 1. North 2. East 3. South 4. West", name);

            //int result;

            //if (int.TryParse(Console.ReadLine(), out result))

            //{

            //    if (result == 1)

            //        Console.WriteLine("You move North", name);

            //    else if (result == 2)

            //        Console.WriteLine("You move East", name);

            //        else if (result == 3)

            //         Console.WriteLine("You move South", name);

            //            else if (result == 4)

            //                Console.WriteLine("You move West", name);

            //    else

            //        Console.WriteLine("Incorrect response");






            //string command;
            //bool quitNow = false;
            //while(!quitNow)
            //{
            //    command = Console.ReadLine();
            //    switch (command)


            //    {
            //        case "/test":

            //        bool ErrorCatch = true;
            //        if (ErrorCatch)
            //        {
            //            Console.WriteLine(" An Error has been found in your Code! FIX IMMEDIATLEY");
            //        }

            //        else
            //        {
            //            Console.WriteLine(" ");
            //        }


            //                break;
            //    }
            //}


            
            string command;
            bool quitNow = false;
            while (!quitNow)
            {
                command = Console.ReadLine();
                switch (command)


                {
                    // ------------------------------------- OPENCHEST
                    case "/open chest":

                        bool ErrorCatch = true;
                        if (ErrorCatch)
                        {
                            Console.WriteLine("You turn the Key, you hear a faint click.");
                        }

                        else
                        {
                            Console.WriteLine("The Chest is locked, find a key.");
                        }


                        break;


                    // ------------------------------------- LANTERN
                    case "/LanternOn ":

                        
                        bool hasMatches = true;
                        bool hasOil = true;
                        bool hasBoth = true;



                        if (hasMatches)
                        {
                            Console.WriteLine( " " );
                        }
                        else
                        {
                            Console.WriteLine("You need Matches to Light this.");
                        }



                        if (hasOil)
                        {
                            Console.WriteLine( " " );
                        }
                        else
                        {
                            Console.WriteLine("You need Oil to Light.");
                        }

                        

                        if (hasMatches && hasOil)
                            
                        {
                            hasBoth = true;
                        }


                        if (hasBoth)
                        {
                            Console.WriteLine("Your Lantern has been turned on.");
                        }
  
                        else
                        {
                            Console.WriteLine("Your Lantern has been turned off.");   
                        }

                        

                        


                        break;
                }





            }
            // ------------------------------------- DOES IT HAVE A KEY?













            Console.ReadKey();


            }
            




            
        }




    }





