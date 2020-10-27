using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrianguloPascal
{
    public partial class Form1 : Form
    {
        public List<Panel> Paineis = new List<Panel>();
        public List<Label> Labels = new List<Label>();
        public Form1()
        {
            InitializeComponent();

            Paineis.Add(panel1);
            Paineis.Add(panel2);
            Paineis.Add(panel3);
            Paineis.Add(panel4);
            Paineis.Add(panel5);
            Paineis.Add(panel6);
            Paineis.Add(panel7);
            Paineis.Add(panel8);

            Labels.Add(lbl1);
            Labels.Add(lbl2);
            Labels.Add(lbl3);
            Labels.Add(lbl4);
            Labels.Add(lbl5);
            Labels.Add(lbl6);
            Labels.Add(lbl7);
            Labels.Add(lbl8);
            Labels.Add(lbl9);
            Labels.Add(lbl10);
            Labels.Add(lbl11);
            Labels.Add(lbl12);
            Labels.Add(lbl13);
            Labels.Add(lbl14);
            Labels.Add(lbl15);
            Labels.Add(lbl16);
            Labels.Add(lbl17);
            Labels.Add(lbl18);
            Labels.Add(lbl19);
            Labels.Add(lbl20);
            Labels.Add(lbl21);
            Labels.Add(lbl22);
            Labels.Add(lbl23);
            Labels.Add(lbl24);
            Labels.Add(lbl25);
            Labels.Add(lbl26);
            Labels.Add(lbl27);
            Labels.Add(lbl28);
            Labels.Add(lbl29);
            Labels.Add(lbl30);
            Labels.Add(lbl31);
            Labels.Add(lbl32);
            Labels.Add(lbl33);
            Labels.Add(lbl34);
            Labels.Add(lbl35);
            Labels.Add(lbl36);

        }

        private void btnQuadrado_Click(object sender, EventArgs e)
        {
            try
            {
                if (byte.Parse(mtxtLinhas.Text) < 9)
                {
                    byte linhas = byte.Parse(mtxtLinhas.Text);
                    int aux = 0;
                    foreach (Panel A in Paineis)
                        A.Visible = false;
                    foreach (Control CON in this.Controls)
                    {
                        if (CON.GetType() == typeof(Panel))
                        {
                            foreach (Label Lab in CON.Controls)
                            {
                                var path = new System.Drawing.Drawing2D.GraphicsPath();
                                Rectangle pathRect = new Rectangle(0, 0, Lab.Width, Lab.Height);
                                path.AddRectangle(pathRect);

                                Lab.Region = new Region(path);
                            }
                        }
                    }
                    foreach (Panel A in Paineis)
                    {
                        if (aux == Convert.ToInt32(mtxtLinhas.Text))
                            break;
                        A.Visible = true;
                        aux++;

                    }
                }
                else
                    MessageBox.Show("Digite um valor válido!");
            }
            catch
            {
                MessageBox.Show("Digite um valor válido!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (byte.Parse(mtxtLinhas.Text) < 9)
                {
                    byte linhas = byte.Parse(mtxtLinhas.Text);
                    int aux = 0;
                    foreach (Panel A in Paineis)
                        A.Visible = false;
                    foreach (Control CON in this.Controls)
                    {
                        if (CON.GetType() == typeof(Panel))
                        {
                            foreach (Label Lab in CON.Controls)
                            {
                                var path = new System.Drawing.Drawing2D.GraphicsPath();
                                path.AddEllipse(0, 0, Lab.Width, Lab.Height);

                                Lab.Region = new Region(path);
                            }
                        }
                    }
                    foreach (Panel A in Paineis)
                    {
                        if (aux == Convert.ToInt32(mtxtLinhas.Text))
                            break;
                        A.Visible = true;
                        aux++;

                    }
                }
                else
                    MessageBox.Show("Digite um valor válido!");
            }
            catch
            {
                MessageBox.Show("Digite um valor válido!");
            }
        }
    }
}
