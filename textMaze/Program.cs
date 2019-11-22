using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static textMaze.Maze;

namespace textMaze
{
    public enum Rooms { none, StartRoom, Room, SHallway, LHallway, THallway, Exit };
    public enum Directions { none, North, East, South, West };


    class Program
    {
        static void Main(string[] args)
        {
            GenRooms(15);
            ConnectRooms();
            Player p = new Player();
            p.CurrentRoom = RoomList[0];
            Console.WriteLine(p.CurrentRoom);
            Console.WriteLine(p.CurrentRoom.ID);
            MoveRooms(p);
            Console.WriteLine(p.CurrentRoom.ID);
            Console.ReadKey();
        }

        //private static Random RNG = new Random();
    }

    class Maze
    {
        public static List<Room> RoomList = new List<Room>();


        public static Random RNG = new Random();
        private static int numOfRooms = 0;
        public static void GenRooms(int roomCount)
        {
            for (int i = 0; i < roomCount; i++)
            {
                Room newRoom = new Room();
                switch (RNG.Next(0, 8))
                {
                    case 0: case 1: case 2: newRoom = new Room(numOfRooms); break;
                    case 3: case 4: newRoom = new SHallway(numOfRooms); break;
                    case 5: case 6: newRoom = new LHallway(numOfRooms); break;
                    case 7: newRoom = new THallway(numOfRooms); break;
                }

                RoomList.Add(newRoom);
                numOfRooms++;
            }
        }

        public static void ConnectRooms()
        {
            for (int h = 0; h < 2; h++)
            {
                for (int i = 0; i < RoomList.Count; i++)
                {
                    if (RoomList[i].ToID.Count < 4)
                    {
                        while (true)
                        {
                            int x = RNG.Next(0, RoomList.Count);
                            if (RoomList[i] != RoomList[x])
                            {
                                RoomList[i].ToID.Add(x);
                                break;
                            }
                    
                        }
                    }
                }
            }

            for (int k = 0; k < RoomList.Count; k++)
            {
                for (int j = 0; j < RoomList.Count; j++)
                {
                    if (RoomList[j].ToID.Contains(k) && !RoomList[k].ToID.Contains(j))
                    {
                        RoomList[k].ToID.Add(j);
                    }
                }
            }
        }

        public static void MoveRooms(Player p)
        {
            Room currentRoom = p.CurrentRoom;

            switch (currentRoom.ToID.Count)
            {
                case 1: Console.WriteLine("This seems to be a dead end, the only way out is the way you came in."); break;
                case 2: Console.WriteLine("There only seems to be one other way out of this room."); break;
                case 3: Console.WriteLine("There are 2 other ways out, as well as the way you just came."); break;
                case 4: Console.WriteLine("There are exits on all sides, 4 in total."); break;
            }

            Console.WriteLine("Which door would you like to take?");
            switch(Console.ReadLine())
            {
                case "one": currentRoom = RoomList[currentRoom.ID+1]; Console.WriteLine("AHHHH");  break;
                case "two": currentRoom = RoomList[3]; break;
                case "three": currentRoom = RoomList[4]; break;
                case "four": currentRoom = RoomList[5]; break;
            }
            Console.WriteLine(currentRoom);
            Console.WriteLine(currentRoom.ID);
            MoveRooms(p);
        }
    }

    abstract class BaseRoom
    {
        public int ID { get; set; }
        public abstract string Description { get; set; }

        //Sets a random description for each room based on the given descriptions
        public static Random ranGen = new Random();
        public string RandomDesc(string desc1, string desc2)
        {
            switch (ranGen.Next(0, 4))
            {
                case 0: case 3: return desc1;
                case 1: case 2: return desc2;
            }
            throw new Exception();
        }

        //How many doors in each room
        public List<Directions> RoomDirections = new List<Directions>();
        public void RandDir()
        {
            for (int i = 0; i < 4; i++)
            {
                switch(ranGen.Next(0, 4)) {
                    case 0: RoomDirections.Add(Directions.North); break;
                    case 1: RoomDirections.Add(Directions.East); break;
                    case 2: RoomDirections.Add(Directions.South); break;
                    case 3: RoomDirections.Add(Directions.West); break;
                }
            }
            RoomDirections.Add(Directions.North);
        }

        public List<int> ToID = new List<int>();

        public override string ToString()
        {
            StringBuilder sb2 = new StringBuilder("{");
            foreach (int k in ToID) sb2.Append(k + ", ");
            sb2.Append("}");

            return $"{Description}";// {ID} {sb2.ToString()}";
        }
    }

    class Room : BaseRoom
    {
        public Room() { }
        public Room(int ID)
        {
            Description = RandomDesc("Room description", "Room description");
            this.ID = ID;
            RandDir();
        }
        public override string Description { get; set; }

        public bool Exit { get; set; }
    }

    class SHallway : Room
    {
        public SHallway(int ID)
        {
            Description = RandomDesc("Room description", "Room description");
            this.ID = ID;
        }
        public override string Description { get; set; }
    }

    class LHallway : Room
    {
        public LHallway(int ID)
        {
            Description = RandomDesc("Room description", "Room description");
            this.ID = ID;
        }
        public override string Description { get; set; }
    }

    class THallway : Room
    {
        public THallway(int ID)
        {
            Description = RandomDesc("Room description", "Room description");
            this.ID = ID;
        }
        public override string Description { get; set; }
    }

    class Player
    {
        public Room CurrentRoom { get; set; }

    }
}