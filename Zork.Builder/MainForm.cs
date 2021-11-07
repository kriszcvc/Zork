using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zork;
using System.IO;
using Newtonsoft.Json;

namespace Zork.Builder
{
    public partial class MainForm : Form
    {
        internal GameViewModel ViewModel
        {
            get => _ViewModel;
            set
            {
                if (_ViewModel != value)
                {
                    _ViewModel = value;
                    gameViewModelBindingSource.DataSource = _ViewModel;
                }
            }
        }

        private bool IsFileLoaded
        {
            get => _IsFileLoaded;
            set
            {
                _IsFileLoaded = value;
                roomListAddButton.Enabled = _IsFileLoaded;
            }
        }

        public string Filename { get; set; }

        public MainForm()
        {
            InitializeComponent();
            ViewModel = new GameViewModel();
            IsFileLoaded = false;
            roomListDeleteButton.Enabled = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string jsonString = File.ReadAllText(openFileDialog.FileName);
                ViewModel.Game = JsonConvert.DeserializeObject<Game>(jsonString);
                IsFileLoaded = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private GameViewModel _ViewModel;
        private bool _IsFileLoaded;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void roomListAddButton_Click(object sender, EventArgs e)
        {
            using (addRoomForm addRoomForm = new addRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room room = new Room { Name = addRoomForm.RoomName, Description = addRoomForm.RoomDescription };
                    ViewModel.Rooms.Add(room);
                }
            }
        }

        private void roomListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomListDeleteButton.Enabled = roomListBox.SelectedItem != null;
        }

        private void roomListDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this room?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Rooms.Remove((Room)roomListBox.SelectedItem);
                roomListBox.SelectedItem = ViewModel.Rooms.FirstOrDefault();
            }
        }
    }
}
