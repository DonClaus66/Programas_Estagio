using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JurosForms
{
    public partial class Form1 : Form
    {
        Label[] label = new Label[33];
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < label.Length; i++) 
            {
                label[i] = new Label();
                label[i].AutoSize = true;
                label[i].BackColor = System.Drawing.Color.Black;
                label[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label[i].Location = new System.Drawing.Point(10 * (i+2), 360);
                label[i].Name = "label"+i;
                label[i].Size = new System.Drawing.Size(5, 5);
                label[i].Text = "a";
                this.Controls.Add(this.label[i]);
                
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                
                string tipo_taxa = cbTaxa.Text;
                string tipo_tempo = cbTempo.Text;

                double valor_atual = Convert.ToDouble(nudValorAtual.Value);
                double valor_futuro;
                double taxa = Convert.ToDouble(nudTaxa.Value);
                double aporte = Convert.ToDouble(nudAporte.Value);
                double tempo = Convert.ToDouble(nudTempo.Value);
                taxa = taxa / 100.0;

                if (tipo_taxa == "Anual")
                    taxa = Math.Pow((1 + taxa), (1.0 / 12.0)) - 1;
                if (tipo_tempo == "Anual")
                    tempo = tempo * 12;

                valor_futuro = (aporte * (Math.Pow((1 + taxa), tempo) - 1) / taxa) + valor_atual * Math.Pow((1 + taxa), tempo);
                MessageBox.Show("Valor Final=" + valor_futuro.ToString());
                int tempo_aux = 0;
                

                for (int i = 0; i < 33; i++)
                {
                    label[i].Top = 360;
                    label[i].Top -= Convert.ToInt32((200.0*((aporte * (Math.Pow((1 + taxa), tempo_aux) - 1) / taxa) + valor_atual * Math.Pow((1 + taxa), tempo_aux)))/valor_futuro);
                    tempo_aux += Convert.ToInt32(tempo / 33);
                }
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
                string tipo_taxa = cbTaxa.Text;
                string tipo_tempo = cbTempo.Text;

                double valor_atual = Convert.ToDouble(nudValorAtual.Value);
                double valor_futuro = Convert.ToDouble(nudValorFuturo.Value);
                double taxa = Convert.ToDouble(nudTaxa.Value);
                double aporte;
                double tempo = Convert.ToDouble(nudTempo.Value);
                taxa = taxa / 100.0;

                if (tipo_taxa == "Anual")
                    taxa = Math.Pow((1 + taxa), (1.0 / 12.0)) - 1;
                if (tipo_tempo == "Anual")
                    tempo = tempo * 12;

                aporte = (taxa * (valor_futuro - valor_atual * Math.Pow((1 + taxa), tempo))) / (Math.Pow((1 + taxa), tempo) - 1);

                MessageBox.Show("Aporte=" + aporte);
            }
            catch
            {
                MessageBox.Show("Digite um valor válido!");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
