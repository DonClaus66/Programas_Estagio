namespace SPCSAC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nudSaldoDevedor = new System.Windows.Forms.NumericUpDown();
            this.nudTaxa = new System.Windows.Forms.NumericUpDown();
            this.nudPrestacoes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.dataGrid2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAnual = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSaldoDevedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaxa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrestacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // nudSaldoDevedor
            // 
            this.nudSaldoDevedor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudSaldoDevedor.DecimalPlaces = 2;
            this.nudSaldoDevedor.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudSaldoDevedor.Location = new System.Drawing.Point(335, 39);
            this.nudSaldoDevedor.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudSaldoDevedor.Name = "nudSaldoDevedor";
            this.nudSaldoDevedor.Size = new System.Drawing.Size(120, 20);
            this.nudSaldoDevedor.TabIndex = 0;
            // 
            // nudTaxa
            // 
            this.nudTaxa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudTaxa.DecimalPlaces = 7;
            this.nudTaxa.Location = new System.Drawing.Point(587, 39);
            this.nudTaxa.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTaxa.Name = "nudTaxa";
            this.nudTaxa.Size = new System.Drawing.Size(120, 20);
            this.nudTaxa.TabIndex = 1;
            // 
            // nudPrestacoes
            // 
            this.nudPrestacoes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudPrestacoes.Location = new System.Drawing.Point(461, 39);
            this.nudPrestacoes.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPrestacoes.Name = "nudPrestacoes";
            this.nudPrestacoes.Size = new System.Drawing.Size(120, 20);
            this.nudPrestacoes.TabIndex = 2;
            this.nudPrestacoes.ValueChanged += new System.EventHandler(this.nudPrestacoes_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Saldo Devedor:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Taxa:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prestações:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCalcular.Location = new System.Drawing.Point(514, 65);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.AllowUserToAddRows = false;
            this.dataGrid1.AllowUserToDeleteRows = false;
            this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Location = new System.Drawing.Point(12, 94);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.Size = new System.Drawing.Size(536, 304);
            this.dataGrid1.TabIndex = 7;
            // 
            // dataGrid2
            // 
            this.dataGrid2.AllowUserToAddRows = false;
            this.dataGrid2.AllowUserToDeleteRows = false;
            this.dataGrid2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid2.Location = new System.Drawing.Point(554, 94);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.ReadOnly = true;
            this.dataGrid2.Size = new System.Drawing.Size(536, 304);
            this.dataGrid2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "SPC";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1062, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "SAC";
            // 
            // cbAnual
            // 
            this.cbAnual.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbAnual.AutoSize = true;
            this.cbAnual.Location = new System.Drawing.Point(714, 39);
            this.cbAnual.Name = "cbAnual";
            this.cbAnual.Size = new System.Drawing.Size(53, 17);
            this.cbAnual.TabIndex = 11;
            this.cbAnual.Text = "Anual";
            this.cbAnual.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 410);
            this.Controls.Add(this.cbAnual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGrid2);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudPrestacoes);
            this.Controls.Add(this.nudTaxa);
            this.Controls.Add(this.nudSaldoDevedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPC SAC";
            ((System.ComponentModel.ISupportInitialize)(this.nudSaldoDevedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaxa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrestacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudSaldoDevedor;
        private System.Windows.Forms.NumericUpDown nudTaxa;
        private System.Windows.Forms.NumericUpDown nudPrestacoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dataGrid1;
        private System.Windows.Forms.DataGridView dataGrid2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbAnual;
    }
}

