using Vestris.ResourceLib;

namespace IconChanger
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Open()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "exe files (*.exe)|*.exe";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        filePath.Text = openFileDialog.FileName;

                        Icon? icon = Icon.ExtractAssociatedIcon(filePath.Text);
                        filePicture.Image = icon.ToBitmap();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error opening file: {ex.Message}");
                    }
                }
            }
        }

        private void Save()
        {
            using (ResourceInfo vi = new ResourceInfo())
            {
                if (!string.IsNullOrEmpty(filePath.Text) && !string.IsNullOrEmpty(iconPath.Text))
                {
                    try
                    {
                        IconFile iconFile = new IconFile(iconPath.Text);
                        IconDirectoryResource iconResource = new IconDirectoryResource(iconFile);

                        iconResource.SaveTo(filePath.Text);

                        MessageBox.Show("Icon successfully changed.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error while saving icon: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("You must fill in all the fields!");
                }
            }
        }

        private void DeleteIcon()
        {
            using (ResourceInfo vi = new ResourceInfo())
            {
                try
                {
                    IconDirectoryResource iconResource = new IconDirectoryResource();
                    iconResource.DeleteFrom(filePath.Text);

                    MessageBox.Show("Icon successfully deleted.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while deleting icon: {ex.Message}");
                }
            }
        }

        private void ClearBoxes()
        {
            filePath.Clear();
            iconPath.Clear();
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            ClearBoxes();
            Open();
        }

        private void iconButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "ico files (*.ico)|*.ico";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        iconPath.Text = openFileDialog.FileName;

                        Icon newIcon = new Icon(iconPath.Text);
                        iconPicture.Image = newIcon.ToBitmap();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error while opening icon: {ex.Message}");
                    }
                }
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteIcon();
            ClearBoxes();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Save();
            ClearBoxes();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearBoxes();
            Open();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
