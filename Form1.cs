using FilePumper;
using AssemblyModifier;
using IconChanger;
using VideoConverter;

namespace Toolkit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void filePumperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void assemblyModifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void iconChangerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void crypterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you need any help with using or finding your way around the Toolkit, join our Discord: https://discord.gg/r64hfFbzGa", "About Toolkit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void reportABugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you want to report any bugs, you can do so in our Discord: https://discord.gg/r64hfFbzGa", "Report a Bug", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
