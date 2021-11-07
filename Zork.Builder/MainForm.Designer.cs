
namespace Zork.Builder
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.MenuStrip mainMenuStrip;
            System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
            System.Windows.Forms.ToolStripSeparator fileSeparatorToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.roomsGroupBox = new System.Windows.Forms.GroupBox();
            this.roomListDeleteButton = new System.Windows.Forms.Button();
            this.roomListAddButton = new System.Windows.Forms.Button();
            this.roomListBox = new System.Windows.Forms.ListBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.roomDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.roomDescriptionLabel = new System.Windows.Forms.Label();
            mainMenuStrip = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fileSeparatorToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mainMenuStrip.SuspendLayout();
            this.roomsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            fileToolStripMenuItem,
            this.editToolStripMenuItem});
            mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new System.Drawing.Size(800, 24);
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            newToolStripMenuItem,
            openToolStripMenuItem,
            fileSeparatorToolStripMenuItem,
            exitToolStripMenuItem});
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // fileSeparatorToolStripMenuItem
            // 
            fileSeparatorToolStripMenuItem.Name = "fileSeparatorToolStripMenuItem";
            fileSeparatorToolStripMenuItem.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JSON Files|*.json";
            // 
            // roomsGroupBox
            // 
            this.roomsGroupBox.Controls.Add(this.roomListDeleteButton);
            this.roomsGroupBox.Controls.Add(this.roomListAddButton);
            this.roomsGroupBox.Controls.Add(this.roomListBox);
            this.roomsGroupBox.Location = new System.Drawing.Point(12, 27);
            this.roomsGroupBox.Name = "roomsGroupBox";
            this.roomsGroupBox.Size = new System.Drawing.Size(200, 418);
            this.roomsGroupBox.TabIndex = 1;
            this.roomsGroupBox.TabStop = false;
            this.roomsGroupBox.Text = "Rooms";
            // 
            // roomListDeleteButton
            // 
            this.roomListDeleteButton.Location = new System.Drawing.Point(114, 388);
            this.roomListDeleteButton.Name = "roomListDeleteButton";
            this.roomListDeleteButton.Size = new System.Drawing.Size(80, 23);
            this.roomListDeleteButton.TabIndex = 2;
            this.roomListDeleteButton.Text = "Delete";
            this.roomListDeleteButton.UseVisualStyleBackColor = true;
            this.roomListDeleteButton.Click += new System.EventHandler(this.roomListDeleteButton_Click);
            // 
            // roomListAddButton
            // 
            this.roomListAddButton.Location = new System.Drawing.Point(6, 388);
            this.roomListAddButton.Name = "roomListAddButton";
            this.roomListAddButton.Size = new System.Drawing.Size(80, 23);
            this.roomListAddButton.TabIndex = 1;
            this.roomListAddButton.Text = "Add...";
            this.roomListAddButton.UseVisualStyleBackColor = true;
            this.roomListAddButton.Click += new System.EventHandler(this.roomListAddButton_Click);
            // 
            // roomListBox
            // 
            this.roomListBox.DataSource = this.roomsBindingSource;
            this.roomListBox.DisplayMember = "Name";
            this.roomListBox.FormattingEnabled = true;
            this.roomListBox.Location = new System.Drawing.Point(3, 16);
            this.roomListBox.Name = "roomListBox";
            this.roomListBox.Size = new System.Drawing.Size(191, 368);
            this.roomListBox.TabIndex = 0;
            this.roomListBox.ValueMember = "Description";
            this.roomListBox.SelectedIndexChanged += new System.EventHandler(this.roomListBox_SelectedIndexChanged);
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(Zork.Builder.GameViewModel);
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Location = new System.Drawing.Point(234, 43);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(38, 13);
            this.roomNameLabel.TabIndex = 2;
            this.roomNameLabel.Text = "Name:";
            this.roomNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.roomNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true));
            this.roomNameTextBox.Location = new System.Drawing.Point(237, 60);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.ReadOnly = true;
            this.roomNameTextBox.Size = new System.Drawing.Size(178, 20);
            this.roomNameTextBox.TabIndex = 3;
            // 
            // roomDescriptionTextBox
            // 
            this.roomDescriptionTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.roomDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true));
            this.roomDescriptionTextBox.Location = new System.Drawing.Point(237, 120);
            this.roomDescriptionTextBox.Multiline = true;
            this.roomDescriptionTextBox.Name = "roomDescriptionTextBox";
            this.roomDescriptionTextBox.ReadOnly = true;
            this.roomDescriptionTextBox.Size = new System.Drawing.Size(530, 66);
            this.roomDescriptionTextBox.TabIndex = 5;
            this.roomDescriptionTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // roomDescriptionLabel
            // 
            this.roomDescriptionLabel.AutoSize = true;
            this.roomDescriptionLabel.Location = new System.Drawing.Point(234, 103);
            this.roomDescriptionLabel.Name = "roomDescriptionLabel";
            this.roomDescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.roomDescriptionLabel.TabIndex = 4;
            this.roomDescriptionLabel.Text = "Description:";
            this.roomDescriptionLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roomDescriptionTextBox);
            this.Controls.Add(this.roomDescriptionLabel);
            this.Controls.Add(this.roomNameTextBox);
            this.Controls.Add(this.roomNameLabel);
            this.Controls.Add(this.roomsGroupBox);
            this.Controls.Add(mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Zork Builder";
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            this.roomsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox roomsGroupBox;
        private System.Windows.Forms.Button roomListDeleteButton;
        private System.Windows.Forms.Button roomListAddButton;
        private System.Windows.Forms.ListBox roomListBox;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.TextBox roomDescriptionTextBox;
        private System.Windows.Forms.Label roomDescriptionLabel;
    }
}

