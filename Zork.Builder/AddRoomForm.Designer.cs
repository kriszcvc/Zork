
namespace Zork.Builder
{
    partial class addRoomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.roomDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.roomDescriptionLabel = new System.Windows.Forms.Label();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.addRoomOKButton = new System.Windows.Forms.Button();
            this.addRoomCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // roomDescriptionTextBox
            // 
            this.roomDescriptionTextBox.Location = new System.Drawing.Point(20, 92);
            this.roomDescriptionTextBox.Multiline = true;
            this.roomDescriptionTextBox.Name = "roomDescriptionTextBox";
            this.roomDescriptionTextBox.Size = new System.Drawing.Size(530, 66);
            this.roomDescriptionTextBox.TabIndex = 3;
            this.roomDescriptionTextBox.TextChanged += new System.EventHandler(this.roomDescriptionTextBox_TextChanged);
            // 
            // roomDescriptionLabel
            // 
            this.roomDescriptionLabel.AutoSize = true;
            this.roomDescriptionLabel.Location = new System.Drawing.Point(17, 75);
            this.roomDescriptionLabel.Name = "roomDescriptionLabel";
            this.roomDescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.roomDescriptionLabel.TabIndex = 2;
            this.roomDescriptionLabel.Text = "Description:";
            this.roomDescriptionLabel.Click += new System.EventHandler(this.roomDescriptionLabel_Click);
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.Location = new System.Drawing.Point(20, 37);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(178, 20);
            this.roomNameTextBox.TabIndex = 1;
            this.roomNameTextBox.TextChanged += new System.EventHandler(this.roomNameTextBox_TextChanged);
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Location = new System.Drawing.Point(17, 20);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(38, 13);
            this.roomNameLabel.TabIndex = 0;
            this.roomNameLabel.Text = "Name:";
            // 
            // addRoomOKButton
            // 
            this.addRoomOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addRoomOKButton.Enabled = false;
            this.addRoomOKButton.Location = new System.Drawing.Point(20, 178);
            this.addRoomOKButton.Name = "addRoomOKButton";
            this.addRoomOKButton.Size = new System.Drawing.Size(80, 23);
            this.addRoomOKButton.TabIndex = 4;
            this.addRoomOKButton.Text = "OK";
            this.addRoomOKButton.UseVisualStyleBackColor = true;
            this.addRoomOKButton.Click += new System.EventHandler(this.roomListAddButton_Click);
            // 
            // addRoomCancelButton
            // 
            this.addRoomCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addRoomCancelButton.Location = new System.Drawing.Point(118, 178);
            this.addRoomCancelButton.Name = "addRoomCancelButton";
            this.addRoomCancelButton.Size = new System.Drawing.Size(80, 23);
            this.addRoomCancelButton.TabIndex = 5;
            this.addRoomCancelButton.Text = "Cancel";
            this.addRoomCancelButton.UseVisualStyleBackColor = true;
            this.addRoomCancelButton.Click += new System.EventHandler(this.addRoomCancelButton_Click);
            // 
            // addRoomForm
            // 
            this.AcceptButton = this.addRoomOKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.addRoomCancelButton;
            this.ClientSize = new System.Drawing.Size(565, 222);
            this.Controls.Add(this.addRoomCancelButton);
            this.Controls.Add(this.roomDescriptionTextBox);
            this.Controls.Add(this.roomDescriptionLabel);
            this.Controls.Add(this.roomNameTextBox);
            this.Controls.Add(this.roomNameLabel);
            this.Controls.Add(this.addRoomOKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "addRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox roomDescriptionTextBox;
        private System.Windows.Forms.Label roomDescriptionLabel;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.Button addRoomOKButton;
        private System.Windows.Forms.Button addRoomCancelButton;
    }
}