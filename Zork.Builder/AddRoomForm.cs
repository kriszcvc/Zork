using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zork.Builder
{
    public partial class addRoomForm : Form
    {
        public string RoomName
        {
            get => roomNameTextBox.Text;
            set => roomNameTextBox.Text = value;
        }

        public string RoomDescription
        {
            get => roomDescriptionTextBox.Text;
            set => roomDescriptionTextBox.Text = value;
        }

        public addRoomForm()
        {
            InitializeComponent();
        }

        private void roomDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            addRoomOKButton.Enabled = !string.IsNullOrEmpty(RoomDescription);
        }

        private void roomDescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void roomListAddButton_Click(object sender, EventArgs e)
        {

        }

        private void addRoomCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void roomNameTextBox_TextChanged(object sender, EventArgs e)
        {
            addRoomOKButton.Enabled = !string.IsNullOrEmpty(RoomName);
        }
    }
}
