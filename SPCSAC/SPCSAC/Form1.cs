using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SPCSAC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable Tbl;
        DataTable Tbl2;
        private void btnCalcular_Click(object sender, EventArgs e)
        
        {
            Tbl = new DataTable();
            Tbl.Columns.Add("Parcelas", typeof(int));
            Tbl.Columns.Add("Pagamentos", typeof(double));
            Tbl.Columns.Add("Juros", typeof(double));
            Tbl.Columns.Add("Amortização", typeof(double));
            Tbl.Columns.Add("Saldo Devedor", typeof(double));

            Tbl2 = new DataTable();
            Tbl2.Columns.Add("Parcelas", typeof(int));
            Tbl2.Columns.Add("Pagamentos", typeof(double));
            Tbl2.Columns.Add("Juros", typeof(double));
            Tbl2.Columns.Add("Amortização", typeof(double));
            Tbl2.Columns.Add("Saldo Devedor", typeof(double));

            DataRow Linha;
            DataRow Linha2;

            try
            {
                double PagSPC;
                double saldo = Convert.ToDouble(nudSaldoDevedor.Value);
                double taxa = Convert.ToDouble(nudTaxa.Value)/100.0;
                int prestacoes = Convert.ToInt32(nudPrestacoes.Value);
                double SaldoDevedorAnteriorSPC = saldo;
                double SaldoDevedorAnteriorSAC = saldo;

                double amortizacaoSAC = saldo / Convert.ToDouble(prestacoes);
                if(cbAnual.Checked)
                    taxa = Math.Pow((1+taxa),(1.0/12.0))-1;
                PagSPC = saldo*(Math.Pow((1+taxa),prestacoes)*taxa)/(Math.Pow((1+taxa),prestacoes)-1);

                using (StreamWriter sw = new StreamWriter("SPCSAC.txt"))
                {
                    sw.WriteLine("SPC:");
                    for (int i = 0; i <= prestacoes; i++)
                    {
                        Linha = Tbl.NewRow();

                        if (i == 0)
                        {
                            sw.WriteLine(i + ";0;0;0;" + saldo);
                            Linha[0] = i;
                            Linha[1] = 0;
                            Linha[2] = 0;
                            Linha[3] = 0;
                            Linha[4] = 0;
                            Tbl.Rows.Add(Linha);

                            
                        }
                        else
                        {
                            double juros = SaldoDevedorAnteriorSPC * taxa;
                            double amortizacao = PagSPC - juros;
                            SaldoDevedorAnteriorSPC -= amortizacao;
                            if (SaldoDevedorAnteriorSPC < 0.00000001)
                                SaldoDevedorAnteriorSPC = 0;
                            sw.WriteLine("{0};{1};{2};{3};{4}", i, Math.Round(PagSPC,2), Math.Round(juros,2), Math.Round(amortizacao,2), Math.Round(SaldoDevedorAnteriorSPC,2));
                            Linha[0] = i;
                            Linha[1] = Math.Round(PagSPC, 2);
                            Linha[2] = Math.Round(juros, 2);
                            Linha[3] = Math.Round(amortizacao, 2);
                            Linha[4] = Math.Round(SaldoDevedorAnteriorSPC, 2);
                            Tbl.Rows.Add(Linha);
                        }
                    }
                    dataGrid1.DataSource = Tbl;
                    sw.WriteLine("SAC:");
                    for (int j = 0; j <= prestacoes; j++)
                    {
                        Linha2 = Tbl2.NewRow();
                        if (j == 0)
                        {
                            sw.WriteLine(j + ";0;0;0;" + saldo);
                            Linha2[0] = j;
                            Linha2[1] = 0;
                            Linha2[2] = 0;
                            Linha2[3] = 0;
                            Linha2[4] = 0;
                            Tbl2.Rows.Add(Linha2);
                        }
                        else
                        {
                            double juros = taxa * SaldoDevedorAnteriorSAC;
                            double PagSAC = juros + amortizacaoSAC;
                            SaldoDevedorAnteriorSAC -= amortizacaoSAC;
                            if (SaldoDevedorAnteriorSAC < 0.0000001)
                                SaldoDevedorAnteriorSAC = 0;
                            sw.WriteLine("{0};{1};{2};{3};{4}", j, Math.Round(PagSAC, 2), Math.Round(juros, 2), Math.Round(amortizacaoSAC, 2), Math.Round(SaldoDevedorAnteriorSAC, 2));
                            Linha2[0] = j;
                            Linha2[1] = Math.Round(PagSAC, 2);
                            Linha2[2] = Math.Round(juros, 2);
                            Linha2[3] = Math.Round(amortizacaoSAC, 2);
                            Linha2[4] = Math.Round(SaldoDevedorAnteriorSAC, 2);
                            Tbl2.Rows.Add(Linha2);
                        }
                    }
                    dataGrid2.DataSource = Tbl2;
                }
            }
            catch
            {
                MessageBox.Show("Digite valores válidos!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        
        private void nudPrestacoes_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
