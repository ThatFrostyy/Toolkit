namespace AssemblyModifier
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            clearAssemblyInfoToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            filePath = new TextBox();
            productBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            companyBox = new TextBox();
            label3 = new Label();
            descBox = new TextBox();
            label4 = new Label();
            commentsBox = new TextBox();
            label5 = new Label();
            versionBox = new TextBox();
            label6 = new Label();
            copyrightBox = new TextBox();
            saveButton = new Button();
            label7 = new Label();
            idBox = new TextBox();
            pictureBox1 = new PictureBox();
            toolTip1 = new ToolTip(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(373, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, clearAssemblyInfoToolStripMenuItem, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(220, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(220, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // clearAssemblyInfoToolStripMenuItem
            // 
            clearAssemblyInfoToolStripMenuItem.Name = "clearAssemblyInfoToolStripMenuItem";
            clearAssemblyInfoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            clearAssemblyInfoToolStripMenuItem.Size = new Size(220, 22);
            clearAssemblyInfoToolStripMenuItem.Text = "Clear Assembly Info";
            clearAssemblyInfoToolStripMenuItem.Click += clearAssemblyInfoToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            quitToolStripMenuItem.Size = new Size(220, 22);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // filePath
            // 
            filePath.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            filePath.Location = new Point(12, 252);
            filePath.Name = "filePath";
            filePath.PlaceholderText = "File Location";
            filePath.ReadOnly = true;
            filePath.Size = new Size(268, 23);
            filePath.TabIndex = 1;
            // 
            // productBox
            // 
            productBox.Location = new Point(12, 53);
            productBox.Name = "productBox";
            productBox.PlaceholderText = "Product Name";
            productBox.Size = new Size(100, 23);
            productBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 3;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 35);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 5;
            label2.Text = "Company Name";
            // 
            // companyBox
            // 
            companyBox.Location = new Point(261, 53);
            companyBox.Name = "companyBox";
            companyBox.PlaceholderText = "Company Name";
            companyBox.Size = new Size(100, 23);
            companyBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 35);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 7;
            label3.Text = "Description";
            // 
            // descBox
            // 
            descBox.Location = new Point(136, 53);
            descBox.Name = "descBox";
            descBox.PlaceholderText = "Description";
            descBox.Size = new Size(100, 23);
            descBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 105);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 13;
            label4.Text = "Comments";
            // 
            // commentsBox
            // 
            commentsBox.Location = new Point(136, 123);
            commentsBox.Name = "commentsBox";
            commentsBox.PlaceholderText = "Comments";
            commentsBox.Size = new Size(100, 23);
            commentsBox.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(261, 105);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 11;
            label5.Text = "Product Version";
            // 
            // versionBox
            // 
            versionBox.Location = new Point(261, 123);
            versionBox.Name = "versionBox";
            versionBox.PlaceholderText = "Product Version";
            versionBox.Size = new Size(100, 23);
            versionBox.TabIndex = 10;
            versionBox.KeyPress += versionBox_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 105);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 9;
            label6.Text = "Copyright";
            // 
            // copyrightBox
            // 
            copyrightBox.Location = new Point(12, 123);
            copyrightBox.Name = "copyrightBox";
            copyrightBox.PlaceholderText = "Copyright";
            copyrightBox.Size = new Size(100, 23);
            copyrightBox.TabIndex = 8;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.Location = new Point(286, 252);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 14;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(29, 205);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 16;
            label7.Text = "Languge ID";
            // 
            // idBox
            // 
            idBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            idBox.Location = new Point(12, 223);
            idBox.MaxLength = 4;
            idBox.Name = "idBox";
            idBox.PlaceholderText = "ID";
            idBox.Size = new Size(32, 23);
            idBox.TabIndex = 15;
            idBox.Text = "0";
            idBox.KeyPress += idBox_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Toolkit.Properties.Resources.information;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(12, 202);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 287);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(idBox);
            Controls.Add(saveButton);
            Controls.Add(label4);
            Controls.Add(commentsBox);
            Controls.Add(label5);
            Controls.Add(versionBox);
            Controls.Add(label6);
            Controls.Add(copyrightBox);
            Controls.Add(label3);
            Controls.Add(descBox);
            Controls.Add(label2);
            Controls.Add(companyBox);
            Controls.Add(label1);
            Controls.Add(productBox);
            Controls.Add(filePath);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Assembly Modifier";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private TextBox filePath;
        private TextBox productBox;
        private Label label1;
        private Label label2;
        private TextBox companyBox;
        private Label label3;
        private TextBox descBox;
        private Label label4;
        private TextBox commentsBox;
        private Label label5;
        private TextBox versionBox;
        private Label label6;
        private TextBox copyrightBox;
        private ToolStripMenuItem saveToolStripMenuItem;
        private Button saveButton;
        private ToolStripMenuItem clearAssemblyInfoToolStripMenuItem;
        private Label label7;
        private TextBox idBox;
        private PictureBox pictureBox1;
        private ToolTip toolTip1;
    }
}