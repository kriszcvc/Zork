using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Zork;
using System.Runtime.CompilerServices;

namespace Zork.Builder
{
    internal class GameViewModel : INotifyPropertyChanged
    {        
        public event PropertyChangedEventHandler PropertyChanged;

        public BindingList<Room> Rooms { get; set; }

        public Game Game
        {
            set
            {
                if (_Game != value)
                {
                    _Game = value;
                    if (_Game != null)
                    {
                        Rooms = new BindingList<Room>(_Game.World.Rooms);
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }

        public GameViewModel (Game Game = null)
        {

        }

        public Game _Game;
    }
}
