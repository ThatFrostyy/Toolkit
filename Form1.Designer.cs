namespace Toolkit
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            filePumperToolStripMenuItem = new ToolStripMenuItem();
            assemblyModifierToolStripMenuItem = new ToolStripMenuItem();
            iconChangerToolStripMenuItem = new ToolStripMenuItem();
            converterToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            reportABugToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(490, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.ShortcutKeys = Keys.Control | Keys.Q;
            toolStripMenuItem2.Size = new Size(140, 22);
            toolStripMenuItem2.Text = "Quit";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { filePumperToolStripMenuItem, assemblyModifierToolStripMenuItem, iconChangerToolStripMenuItem, converterToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(46, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // filePumperToolStripMenuItem
            // 
            filePumperToolStripMenuItem.Name = "filePumperToolStripMenuItem";
            filePumperToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            filePumperToolStripMenuItem.Size = new Size(215, 22);
            filePumperToolStripMenuItem.Text = "File Pumper";
            filePumperToolStripMenuItem.Click += filePumperToolStripMenuItem_Click;
            // 
            // assemblyModifierToolStripMenuItem
            // 
            assemblyModifierToolStripMenuItem.Name = "assemblyModifierToolStripMenuItem";
            assemblyModifierToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            assemblyModifierToolStripMenuItem.Size = new Size(215, 22);
            assemblyModifierToolStripMenuItem.Text = "Metadata Editor";
            assemblyModifierToolStripMenuItem.Click += assemblyModifierToolStripMenuItem_Click;
            // 
            // iconChangerToolStripMenuItem
            // 
            iconChangerToolStripMenuItem.Name = "iconChangerToolStripMenuItem";
            iconChangerToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;
            iconChangerToolStripMenuItem.Size = new Size(215, 22);
            iconChangerToolStripMenuItem.Text = "Icon Changer";
            iconChangerToolStripMenuItem.Click += iconChangerToolStripMenuItem_Click;
            // 
            // converterToolStripMenuItem
            // 
            converterToolStripMenuItem.Name = "converterToolStripMenuItem";
            converterToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.T;
            converterToolStripMenuItem.Size = new Size(215, 22);
            converterToolStripMenuItem.Text = "YouTube Converter";
            converterToolStripMenuItem.Click += crypterToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, reportABugToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(142, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // reportABugToolStripMenuItem
            // 
            reportABugToolStripMenuItem.Name = "reportABugToolStripMenuItem";
            reportABugToolStripMenuItem.Size = new Size(142, 22);
            reportABugToolStripMenuItem.Text = "Report a Bug";
            reportABugToolStripMenuItem.Click += reportABugToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 269);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tookit";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem filePumperToolStripMenuItem;
        private ToolStripMenuItem assemblyModifierToolStripMenuItem;
        private ToolStripMenuItem iconChangerToolStripMenuItem;
        private ToolStripMenuItem converterToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem reportABugToolStripMenuItem;
    }
}
