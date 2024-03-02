using Vestris.ResourceLib;

namespace AssemblyModifier
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            toolTip1.SetToolTip(pictureBox1, "To modify the metadata of the executable, the language ID must match the existing one.\nIf you’re uncertain about what to input, leave the current value unchanged.");
        }

        private void Open()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    filePath.Text = openFileDialog.FileName;
                    VersionResource versionResource = new VersionResource();
                    versionResource.LoadFrom(filePath.Text);

                    StringFileInfo stringFileInfo = (StringFileInfo)versionResource["StringFileInfo"];
                    foreach (KeyValuePair<string, StringTableEntry> stringTableEntry in stringFileInfo.Default.Strings)
                    {
                        if (stringTableEntry.Value.Key == "ProductName")
                            productBox.Text = stringTableEntry.Value.StringValue;
                        else if (stringTableEntry.Value.Key == "ProductVersion")
                            versionBox.Text = stringTableEntry.Value.StringValue;
                        else if (stringTableEntry.Value.Key == "Comments")
                            commentsBox.Text = stringTableEntry.Value.StringValue;
                        else if (stringTableEntry.Value.Key == "LegalCopyright")
                            copyrightBox.Text = stringTableEntry.Value.StringValue;
                        else if (stringTableEntry.Value.Key == "FileDescription")
                            descBox.Text = stringTableEntry.Value.StringValue;
                        else if (stringTableEntry.Value.Key == "CompanyName")
                            companyBox.Text = stringTableEntry.Value.StringValue;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while opening file: {ex.Message}");
                }
            }
        }

        private void Save()
        {
            if (!string.IsNullOrEmpty(filePath.Text))
            {
                try
                {
                    VersionResource versionResource = new VersionResource();
                    versionResource.Language = ResourceUtil.NEUTRALLANGID;
                    versionResource.LoadFrom(filePath.Text);

                    versionResource.FileVersion = versionBox.Text;
                    versionResource.ProductVersion = versionBox.Text;

                    StringFileInfo stringFileInfo = new StringFileInfo();
                    versionResource[stringFileInfo.Key] = stringFileInfo;
                    StringTable stringFileInfoStrings = new StringTable();

                    ushort languageId;
                    if (ushort.TryParse(idBox.Text, out languageId))
                    {
                        stringFileInfoStrings.LanguageID = languageId;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Language ID");
                        return;
                    }

                    stringFileInfoStrings.CodePage = 1200;
                    stringFileInfo.Strings.Add(stringFileInfoStrings.Key, stringFileInfoStrings);
                    stringFileInfoStrings["ProductName"] = productBox.Text;
                    stringFileInfoStrings["FileDescription"] = descBox.Text;
                    stringFileInfoStrings["CompanyName"] = companyBox.Text;
                    stringFileInfoStrings["LegalCopyright"] = copyrightBox.Text;
                    stringFileInfoStrings["Comments"] = commentsBox.Text;
                    stringFileInfoStrings["ProductVersion"] = versionBox.Text;

                    VarFileInfo varFileInfo = new VarFileInfo();
                    versionResource[varFileInfo.Key] = varFileInfo;
                    VarTable varFileInfoTranslation = new VarTable("Translation");
                    varFileInfo.Vars.Add(varFileInfoTranslation.Key, varFileInfoTranslation);
                    varFileInfoTranslation[languageId] = 1200;

                    StringTableEntry.ConsiderPaddingForLength = true;
                    versionResource.SaveTo(filePath.Text);

                    MessageBox.Show("Changes sucessfully made.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while saving file: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("You must select a file!");
            }
        }

        private void ClearBoxes()
        {
            productBox.Clear();
            versionBox.Clear();
            companyBox.Clear();
            commentsBox.Clear();
            copyrightBox.Clear(); 
            descBox.Clear();
            filePath.Clear();
        }

        private void idBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void versionBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Save();
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

        private void clearAssemblyInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath.Text))
            {
                try
                {
                    VersionResource versionResource = new VersionResource();
                    versionResource.DeleteFrom(filePath.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while clearing assembly info: {ex.Message}");
                }
                ClearBoxes();
            }
            else
            {
                MessageBox.Show("You must select a file!");
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}