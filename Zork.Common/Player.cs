using Newtonsoft.Json;
using System;

namespace Zork
{
    public class LocationChangedEventArgs : EventArgs
    {
        public Room PreviousLocation { get; }

        public Room CurrentLocation { get; }

        public LocationChangedEventArgs(Room previousLocation, Room currentLocation)
        {
            PreviousLocation = previousLocation;
            CurrentLocation = currentLocation;
        }
    }

    public class Player
    {
        public event EventHandler<LocationChangedEventArgs> LocationChanged;
        public event EventHandler<int> MovesChanged;
        public event EventHandler<int> ScoreChanged;

        public World World { get; }

        [JsonIgnore]
        public Room Location
        {
            get => _location;
            private set
            {
                if (_location != value)
                {
                    Room previousLocation = _location;
                    _location = value;
                    LocationChanged?.Invoke(this, new LocationChangedEventArgs(previousLocation, _location));
                }
            }
        }

        public int Moves
        {
            get => _moves;
            set
            {
                if (_moves != value)
                {
                    _moves = value;
                    MovesChanged?.Invoke(this, _moves);
                }
            }
        }

        public int Score
        {
            get => _score;
            set
            {
                if (_score != value)
                {
                    _score = value;
                    ScoreChanged?.Invoke(this, _score);
                }
            }
        }

        public Player(World world, string startingLocation)
        {
            Assert.IsTrue(world != null);
            Assert.IsTrue(world.RoomsByName.ContainsKey(startingLocation));

            World = world;
            Location = world.RoomsByName[startingLocation];
        }

        public bool Move(Directions direction)
        {
            bool isValidMove = Location.Neighbors.TryGetValue(direction, out Room destination);
            if (isValidMove)
            {
                Location = destination;
            }

            return isValidMove;
        }

        private Room _location;
        private int _moves;
        private int _score;
    }
}