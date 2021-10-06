using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

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
            const string roomDescriptionsFilename = @"Zork\Rooms.json";
            InitializeRooms(roomDescriptionsFilename);

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

        private static void InitializeRooms(string roomDescriptionsFilename) =>
            Rooms = JsonConvert.DeserializeObject<Room[,]>(File.ReadAllText(roomDescriptionsFilename));

        private static Room[,] Rooms;

        private static readonly List<Commands> Directions = new List<Commands>
        {
            Commands.NORTH,
            Commands.SOUTH,
            Commands.EAST,
            Commands.WEST
        };

        private static int LocationRow = 1;
        private static int LocationColumn = 1;
    }
}