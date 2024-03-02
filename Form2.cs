namespace FilePumper
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Pump()
        {
            if (string.IsNullOrEmpty(filePath.Text))
            {
                MessageBox.Show("You must select a file!");
                return;
            }

            if (int.TryParse(sizeBox.Text, out int size))
            {
                try
                {
                    int multiplier = kilobyteButton.Checked ? 1024 : megabyteButton.Checked ? 1024 * 1024 : 1024 * 1024 * 1024;
                    int pumpSize = size * multiplier;
                    using (FileStream fs = new FileStream(filePath.Text, FileMode.Append))
                    {
                        for (int i = 0; i < pumpSize; i++)
                        {
                            fs.WriteByte(0);
                        }
                    }
                    MessageBox.Show($"Successfully pumped file: {filePath.Text}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while pumping the file: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Invalid size input. Please enter a number.");
            }
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            filePath.Clear();

            openFileDialog.Filter = "All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath.Text = openFileDialog.FileName;
            }
        }

        private void pumpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pump();
        }

        private void pumpButton_Click(object sender, EventArgs e)
        {
            Pump();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
