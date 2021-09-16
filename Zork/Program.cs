using System;

namespace Zork
{
    class Program
    {
        private static string Location
        {
            get
            {
                return Rooms[LocationRow, LocationColumn];
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork");

            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.Write($"{Rooms[LocationRow, LocationColumn]}\n\n>");
                command = ToCommand(Console.ReadLine().Trim());

                string outputString;
                switch (command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for playing!";
                        break;

                    case Commands.LOOK:
                        outputString = "This is an open field west of a white house, with a boarded front door. \nA rubber mat saying 'Welcome to Zork!' lies by the door.";
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        if (Move(command))
                        {
                            outputString = $"You moved {command}.";
                        }
                        else
                        {
                            outputString = "The way is shut!";
                        }
                        break;

                    default:
                        outputString = "Unknown command.";
                        break;
                }

                Console.WriteLine(outputString);
            }
        }

        private static bool Move(Commands command)
        {
            bool didMove = false;

            switch (command)
            {
                case Commands.NORTH:
                    if (LocationRow < Rooms.GetLength(1) - 1)
                    {
                        LocationRow++;
                        didMove = true;
                    }
                    break;

                case Commands.SOUTH:
                    if (LocationRow > 0)
                    {
                        LocationRow--;
                        didMove = true;
                    }
                    break;

                case Commands.EAST:
                    if (LocationColumn < Rooms.GetLength(1) - 1)
                    {
                        LocationColumn++;
                        didMove = true;
                    }
                    break;

                case Commands.WEST:
                    if (LocationColumn > 0)
                    {
                        LocationColumn--;
                        didMove = true;
                    }
                    break;
            }

            return didMove;
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

        private static readonly string[,] Rooms =
        {
            { "Rocky Trail", "South of House", "Canyon View" },
            { "Forest", "West of House", "Behind House" },
            { "Dense Woods", "North of House", "Clearing" }
        };

        private static int LocationRow = 1;
        private static int LocationColumn = 1;
    }
}