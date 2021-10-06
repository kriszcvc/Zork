using System;
using System.IO;
using System.Collections.Generic;

namespace Zork
{
    internal class Program
    {
        public static Room CurrentRoom
        {
            get
            {
                return Rooms[LocationRow, LocationColumn];
            }
        }

        static void Main(string[] args)
        {
            const string roomDescriptionsFilename = "Rooms.txt";
            InitializeRoomDescriptions(roomDescriptionsFilename);

            Console.WriteLine("Welcome to Zork");

            Room previousRoom = null;
            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.WriteLine(CurrentRoom.Name);

                if (previousRoom != CurrentRoom)
                {
                    Console.WriteLine(CurrentRoom.Description);
                    previousRoom = CurrentRoom;
                }

                Console.Write("> ");
                command = ToCommand(Console.ReadLine().Trim());

                switch (command)
                {
                    case Commands.QUIT:
                        Console.WriteLine("Thank you for playing!");
                        break;

                    case Commands.LOOK:
                        Console.WriteLine(CurrentRoom.Description);
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        if (Move(command) == false)
                        {
                            Console.WriteLine("The way is shut!");
                        }                        
                        break;

                    default:
                        Console.WriteLine("Unknown command.");
                        break;
                }
            }
        }

        private static bool Move(Commands command)
        {
            Assert.IsTrue(IsDirection(command), "Invalid Direction.");

            bool isValidMove = true;
            switch (command)
            {
                case Commands.NORTH when LocationRow < Rooms.GetLength(0) - 1: LocationRow++;
                    break;

                case Commands.SOUTH when LocationRow > 0: LocationRow--;
                    break;

                case Commands.EAST when LocationColumn < Rooms.GetLength(1) - 1: LocationColumn++;
                    break;

                case Commands.WEST when LocationColumn > 0: LocationColumn--;
                    break;

                default:
                    isValidMove = false;
                    break;
            }

            return isValidMove;
        }

        private static Commands ToCommand(string commandString)
        {
            if (Enum.TryParse<Commands>(commandString, true, out Commands result))
            {
                return result;
            }

            else
            {
                return Commands.UNKNOWN;
            }
        }

        private static bool IsDirection(Commands command)
        {
            return Directions.Contains(command);
        }

        private static void InitializeRoomDescriptions(string roomDescriptionsFilename)
        {
            var roomMap = new Dictionary<string, Room>();
            foreach (Room room in Rooms)
            {
                roomMap.Add(room.Name, room);
            }

            string[] lines = File.ReadAllLines(roomDescriptionsFilename);
            foreach (string line in lines)
            {
                const string delimiter = "##";
                const int expectedFieldCount = 2;

                string[] fields = line.Split(delimiter);
                Assert.IsTrue(fields.Length == expectedFieldCount, "Invalid record");

                (string name, string description) = (fields[(int)Fields.Name], fields[(int)Fields.Description]);
                roomMap[name].Description = description;
            }

            roomMap["Rocky Trail"].Description = "You are on a rock-strewn trail.";
            roomMap["South of House"].Description = "You are facing the south side of a white house. There is no door here, and all the windows are barred.";
            roomMap["Canyon View"].Description = "You are at the top of the Great Canyon on its south wall.";
            roomMap["Forest"].Description = "This is a forest, with trees in all directions around you.";
            roomMap["West of House"].Description = "This is an open field west of a white house, with a boarded front door.";
            roomMap["Behind House"].Description = "You are behind the white house. In one corner of the house there is a small window which is slightly ajar.";
            roomMap["Dense Woods"].Description = "This is a dimly lit forest, with large trees all around. To the east, there appears to be sunlight.";
            roomMap["North of House"].Description = "You are facing the north side of a white house. There is no door here, and all the windows are barred.";
            roomMap["Clearing"].Description = "You are in a clearing, with a forest surrounding you on the west and south.";
        }

        private static readonly Room[,] Rooms =
        {
            { new Room("Rocky Trail"), new Room("South of House"), new Room("Canyon View") },
            { new Room("Forest"), new Room("West of House"), new Room("Behind House") },
            { new Room("Dense Woods"), new Room("North of House"), new Room("Clearing") }
        };

        private static readonly List<Commands> Directions = new List<Commands>
        {
            Commands.NORTH,
            Commands.SOUTH,
            Commands.EAST,
            Commands.WEST
        };

        private enum Fields
        {
            Name = 0,
            Description = 1
        }

        private static int LocationRow = 1;
        private static int LocationColumn = 1;
    }
}