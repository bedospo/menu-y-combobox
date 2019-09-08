using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int bandera;


            private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
                int indice = cbAlimentos.SelectedIndex;
                label1.Text = indice.ToString();
                label2.Text = cbAlimentos.Items[indice].ToString();

            }


            private void Form1_Load(object sender, EventArgs e)
            {
                cbAlimentos.Items.Add("Pozole");
                cbAlimentos.Items.Add("Tostadas de Pata");

            }


            private void Boton_Click(object sender, EventArgs e)
            {
                cbAlimentos.Items.Add(textBox1.Text);
                textBox1.Clear();
            }


            private void TextBox1_TextChanged(object sender, EventArgs e)
            {


            }


            private void Boton_KeyPress(object sender, KeyPressEventArgs e)
            {
                bandera = 1;
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    Boton_Click(sender, e);
                    textBox1.Focus();
                }
            }
        }
    }


}
    }
}
