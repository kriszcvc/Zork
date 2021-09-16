using System;

namespace Zork
{
    class Program
    {
        private static string Location
        {
            get
            {
                return Rooms[LocationColumn];
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork");

            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.Write($"{Rooms[LocationColumn]}\n\n>");
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
                        outputString = "The way is shut!";
                        break;

                    case Commands.EAST:
                        if (LocationColumn < Rooms.Length - 1)
                        {
                            LocationColumn++;
                            outputString = $"You moved {command}.";
                        }
                        else
                        {
                            outputString = "The way is shut!";
                        }
                        break;

                    case Commands.WEST:
                        if (LocationColumn > 0)
                        {
                            LocationColumn--;
                            outputString = $"You moved {command}.";
                        }
                        else
                        {
                            outputString = "The way is shut!";
                        }
                        break;

                    default:
                        outputString = "Unrecognized command.";
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
                case Commands.SOUTH:
                    break;

                case Commands.EAST:
                    if (LocationColumn < Rooms.Length - 1)
                    {
                        LocationColumn++;
                        didMove = true;
                    }
                    break;

                case Commands.WEST:
                    if (LocationColumn > 0)
                    {

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

        private static string[] Rooms = { "Forest", "West of House", "Behind House", "Clearing", "Canyon View" };

        private static int LocationColumn = 1;
    }
}