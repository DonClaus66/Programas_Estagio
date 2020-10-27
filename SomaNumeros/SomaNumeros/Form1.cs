using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SomaNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (int.TryParse(txtNumeros.Text, out a) == false)
                MessageBox.Show("Digite um valor válido!");
            else
            {
                int resultado = 0;
                foreach (char digito in txtNumeros.Text)
                {
                    resultado += int.Parse(digito.ToString());
                }
                MessageBox.Show(resultado.ToString());
            }
        }
    }
}
