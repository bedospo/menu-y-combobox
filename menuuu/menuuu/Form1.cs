using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menuuu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                this.Close();
            }
            {
                MessageBox.Show("Este programa fue creado por Miguel Escobedo", "Acerca de... Menu_1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            private void borrarColor()
            {
                rojoToolStripMenuItem.Checked = false;
                azulToolStripMenuItem.Checked = false;
            }

            private void AzulToolStripMenuItem_Click(object sender, EventArgs e)
            {
                borrarColor();
                label1.ForeColor = Color.Blue;
                azulToolStripMenuItem.Checked = true;
            }

            private void RojoToolStripMenuItem_Click(object sender, EventArgs e)
            {
                borrarColor();
                label1.ForeColor = Color.Red;
                rojoToolStripMenuItem.Checked = true;
            }

            private void TimesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
            {
                comicSansToolStripMenuItem.Checked = false;
                label1.Font = new Font("Times New Roman", 14, label1.Font.Style);
                timesNewRomanToolStripMenuItem.Checked = true;
            }

            private void ComicSansToolStripMenuItem_Click(object sender, EventArgs e)
            {
                comicSansToolStripMenuItem.Checked = true;
                label1.Font = new Font("Comic Sans MS", 14, label1.Font.Style);
                timesNewRomanToolStripMenuItem.Checked = false;
            }
        }
    }
}
   
