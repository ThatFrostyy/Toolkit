namespace VideoConverter
{
    partial class Form5
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
            downloadButton = new Button();
            youtubeLink = new TextBox();
            label1 = new Label();
            label2 = new Label();
            downloadPath = new TextBox();
            mp3Box = new CheckBox();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            downlaodToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            downloadBar = new ProgressBar();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // downloadButton
            // 
            downloadButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            downloadButton.Location = new Point(263, 251);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size(75, 23);
            downloadButton.TabIndex = 0;
            downloadButton.Text = "Download";
            downloadButton.UseVisualStyleBackColor = true;
            downloadButton.Click += button1_Click;
            // 
            // youtubeLink
            // 
            youtubeLink.Location = new Point(12, 47);
            youtubeLink.Name = "youtubeLink";
            youtubeLink.PlaceholderText = "Video Link";
            youtubeLink.Size = new Size(326, 23);
            youtubeLink.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 2;
            label1.Text = "Video Link";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(88, 15);
            label2.TabIndex = 4;
            label2.Text = "Download Path";
            // 
            // downloadPath
            // 
            downloadPath.Location = new Point(12, 105);
            downloadPath.Name = "downloadPath";
            downloadPath.PlaceholderText = "Download Path";
            downloadPath.Size = new Size(245, 23);
            downloadPath.TabIndex = 3;
            // 
            // mp3Box
            // 
            mp3Box.AutoSize = true;
            mp3Box.Location = new Point(12, 143);
            mp3Box.Name = "mp3Box";
            mp3Box.Size = new Size(50, 19);
            mp3Box.TabIndex = 5;
            mp3Box.Text = "MP3";
            mp3Box.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(263, 104);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(350, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { downlaodToolStripMenuItem, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // downlaodToolStripMenuItem
            // 
            downlaodToolStripMenuItem.Name = "downlaodToolStripMenuItem";
            downlaodToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            downlaodToolStripMenuItem.Size = new Size(180, 22);
            downlaodToolStripMenuItem.Text = "Download";
            downlaodToolStripMenuItem.Click += downlaodToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            quitToolStripMenuItem.Size = new Size(180, 22);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // downloadBar
            // 
            downloadBar.Location = new Point(12, 251);
            downloadBar.Name = "downloadBar";
            downloadBar.Size = new Size(245, 23);
            downloadBar.TabIndex = 8;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 286);
            Controls.Add(downloadBar);
            Controls.Add(button1);
            Controls.Add(mp3Box);
            Controls.Add(label2);
            Controls.Add(downloadPath);
            Controls.Add(label1);
            Controls.Add(youtubeLink);
            Controls.Add(downloadButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YouTube Converter";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button downloadButton;
        private TextBox youtubeLink;
        private Label label1;
        private Label label2;
        private TextBox downloadPath;
        private CheckBox mp3Box;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem downlaodToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ProgressBar downloadBar;
    }
}