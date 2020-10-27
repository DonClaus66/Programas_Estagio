using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DetectarChar
{
    public partial class mtbCaracter : Form
    {
        public mtbCaracter()
        {
            InitializeComponent();
        }

        private void btnVerif_Click(object sender, EventArgs e)
        {
            char caracter = Char.Parse(txtCaracter.Text);
            if (caracter > 64 && caracter < 91)
                MessageBox.Show("String Maiúscula");
            else if (caracter > 96 && caracter < 123)
                MessageBox.Show("String Minúscula");
            else if (caracter > 47 && caracter < 58)
                MessageBox.Show("Digito");
            else
                MessageBox.Show("Símbolo Especial");
        }
    }
}
