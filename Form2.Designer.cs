namespace FilePumper
{
    partial class Form2
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
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            pumpToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            sizeBox = new TextBox();
            kilobyteButton = new RadioButton();
            megabyteButton = new RadioButton();
            gigabyteButton = new RadioButton();
            pumpButton = new Button();
            filePath = new TextBox();
            openFileDialog = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(305, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fileToolStripMenuItem1, pumpToolStripMenuItem, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.O;
            fileToolStripMenuItem1.Size = new Size(147, 22);
            fileToolStripMenuItem1.Text = "Open";
            fileToolStripMenuItem1.Click += fileToolStripMenuItem1_Click;
            // 
            // pumpToolStripMenuItem
            // 
            pumpToolStripMenuItem.Name = "pumpToolStripMenuItem";
            pumpToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            pumpToolStripMenuItem.Size = new Size(147, 22);
            pumpToolStripMenuItem.Text = "Pump";
            pumpToolStripMenuItem.Click += pumpToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            quitToolStripMenuItem.Size = new Size(147, 22);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // sizeBox
            // 
            sizeBox.Location = new Point(12, 41);
            sizeBox.Name = "sizeBox";
            sizeBox.PlaceholderText = "Size";
            sizeBox.Size = new Size(100, 23);
            sizeBox.TabIndex = 1;
            // 
            // kilobyteButton
            // 
            kilobyteButton.AutoSize = true;
            kilobyteButton.Checked = true;
            kilobyteButton.Location = new Point(12, 79);
            kilobyteButton.Name = "kilobyteButton";
            kilobyteButton.Size = new Size(68, 19);
            kilobyteButton.TabIndex = 2;
            kilobyteButton.TabStop = true;
            kilobyteButton.Text = "Kilobyte";
            kilobyteButton.UseVisualStyleBackColor = true;
            // 
            // megabyteButton
            // 
            megabyteButton.AutoSize = true;
            megabyteButton.Location = new Point(12, 104);
            megabyteButton.Name = "megabyteButton";
            megabyteButton.Size = new Size(78, 19);
            megabyteButton.TabIndex = 3;
            megabyteButton.Text = "Megabyte";
            megabyteButton.UseVisualStyleBackColor = true;
            // 
            // gigabyteButton
            // 
            gigabyteButton.AutoSize = true;
            gigabyteButton.Location = new Point(12, 129);
            gigabyteButton.Name = "gigabyteButton";
            gigabyteButton.Size = new Size(72, 19);
            gigabyteButton.TabIndex = 4;
            gigabyteButton.Text = "Gigabyte";
            gigabyteButton.UseVisualStyleBackColor = true;
            // 
            // pumpButton
            // 
            pumpButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pumpButton.Location = new Point(218, 212);
            pumpButton.Name = "pumpButton";
            pumpButton.Size = new Size(75, 23);
            pumpButton.TabIndex = 5;
            pumpButton.Text = "Pump";
            pumpButton.UseVisualStyleBackColor = true;
            pumpButton.Click += pumpButton_Click;
            // 
            // filePath
            // 
            filePath.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            filePath.Location = new Point(12, 212);
            filePath.Name = "filePath";
            filePath.PlaceholderText = "File Location";
            filePath.ReadOnly = true;
            filePath.Size = new Size(200, 23);
            filePath.TabIndex = 6;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 247);
            Controls.Add(filePath);
            Controls.Add(pumpButton);
            Controls.Add(gigabyteButton);
            Controls.Add(megabyteButton);
            Controls.Add(kilobyteButton);
            Controls.Add(sizeBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "File Pumper";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private TextBox sizeBox;
        private RadioButton kilobyteButton;
        private RadioButton megabyteButton;
        private RadioButton gigabyteButton;
        private Button pumpButton;
        private TextBox filePath;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem pumpToolStripMenuItem;
        private OpenFileDialog openFileDialog;
    }
}