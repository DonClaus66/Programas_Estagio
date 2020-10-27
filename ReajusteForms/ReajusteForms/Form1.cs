using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ReajusteForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int i = 0;
            string[,] Dados = new string[10, 2];
            using (StreamReader sr = new StreamReader("salarios.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Dados[i, 0] = line.Substring(0, line.IndexOf(","));
                    Dados[i, 1] = line.Substring(line.IndexOf(",") + 1).Trim();
                    salarioNaoAjustado.Text += Dados[i, 0] + "," + Dados[i, 1] + Environment.NewLine;
                    double salario = double.Parse(Dados[i, 1]);
                    if (salario < 300)
                        salario += salario * 0.5;
                    else if (salario >= 300 && salario < 700)
                        salario += salario * 0.4;
                    else
                        salario += salario * 0.3;
                    Dados[i, 1] = Convert.ToString(salario);
                    salarioReajustado.Text += Dados[i, 0] + "," + Dados[i, 1] + Environment.NewLine;
                    i++;
                }
            }
            using (StreamWriter sw = new StreamWriter("salariosnovos.txt"))
            {
                for (int j = 0; j < 10; j++)
                    sw.WriteLine(Dados[j, 0] + "," + Dados[j, 1]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
