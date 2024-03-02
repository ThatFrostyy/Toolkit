namespace IconChanger
{
    partial class Form4
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            filePath = new TextBox();
            saveButton = new Button();
            filePicture = new PictureBox();
            iconPicture = new PictureBox();
            iconButton = new Button();
            iconPath = new TextBox();
            fileButton = new Button();
            deleteButton = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)filePicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPicture).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(402, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(146, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(146, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            quitToolStripMenuItem.Size = new Size(146, 22);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // filePath
            // 
            filePath.Location = new Point(68, 52);
            filePath.Name = "filePath";
            filePath.PlaceholderText = "File Location";
            filePath.ReadOnly = true;
            filePath.Size = new Size(225, 23);
            filePath.TabIndex = 1;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.Location = new Point(315, 217);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 2;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // filePicture
            // 
            filePicture.BorderStyle = BorderStyle.FixedSingle;
            filePicture.Location = new Point(12, 38);
            filePicture.Name = "filePicture";
            filePicture.Size = new Size(50, 50);
            filePicture.TabIndex = 3;
            filePicture.TabStop = false;
            // 
            // iconPicture
            // 
            iconPicture.BorderStyle = BorderStyle.FixedSingle;
            iconPicture.Location = new Point(12, 119);
            iconPicture.Name = "iconPicture";
            iconPicture.Size = new Size(50, 50);
            iconPicture.TabIndex = 4;
            iconPicture.TabStop = false;
            // 
            // iconButton
            // 
            iconButton.Location = new Point(299, 128);
            iconButton.Name = "iconButton";
            iconButton.Size = new Size(91, 30);
            iconButton.TabIndex = 5;
            iconButton.Text = "Choose Icon";
            iconButton.UseVisualStyleBackColor = true;
            iconButton.Click += iconButton_Click;
            // 
            // iconPath
            // 
            iconPath.Location = new Point(68, 131);
            iconPath.Name = "iconPath";
            iconPath.PlaceholderText = "Icon Location";
            iconPath.ReadOnly = true;
            iconPath.Size = new Size(225, 23);
            iconPath.TabIndex = 6;
            // 
            // fileButton
            // 
            fileButton.Location = new Point(299, 48);
            fileButton.Name = "fileButton";
            fileButton.Size = new Size(91, 30);
            fileButton.TabIndex = 7;
            fileButton.Text = "Choose File";
            fileButton.UseVisualStyleBackColor = true;
            fileButton.Click += fileButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteButton.Location = new Point(234, 217);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 252);
            Controls.Add(deleteButton);
            Controls.Add(fileButton);
            Controls.Add(iconPath);
            Controls.Add(iconButton);
            Controls.Add(iconPicture);
            Controls.Add(filePicture);
            Controls.Add(saveButton);
            Controls.Add(filePath);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Icon Changer";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)filePicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private TextBox filePath;
        private Button saveButton;
        private PictureBox filePicture;
        private PictureBox iconPicture;
        private Button iconButton;
        private TextBox iconPath;
        private Button fileButton;
        private Button deleteButton;
    }
}