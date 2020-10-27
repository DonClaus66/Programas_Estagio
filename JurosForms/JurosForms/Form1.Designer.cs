namespace JurosForms
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudValorAtual = new System.Windows.Forms.NumericUpDown();
            this.nudAporte = new System.Windows.Forms.NumericUpDown();
            this.nudTaxa = new System.Windows.Forms.NumericUpDown();
            this.nudTempo = new System.Windows.Forms.NumericUpDown();
            this.cbTaxa = new System.Windows.Forms.ComboBox();
            this.cbTempo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudValorFuturo = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorAtual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaxa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorFuturo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(258, 104);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(93, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular Valor";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor Atual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tempo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aporte Mensal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Taxa:";
            // 
            // nudValorAtual
            // 
            this.nudValorAtual.DecimalPlaces = 2;
            this.nudValorAtual.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudValorAtual.Location = new System.Drawing.Point(132, 81);
            this.nudValorAtual.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.nudValorAtual.Name = "nudValorAtual";
            this.nudValorAtual.Size = new System.Drawing.Size(120, 20);
            this.nudValorAtual.TabIndex = 9;
            // 
            // nudAporte
            // 
            this.nudAporte.DecimalPlaces = 2;
            this.nudAporte.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudAporte.Location = new System.Drawing.Point(132, 107);
            this.nudAporte.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.nudAporte.Name = "nudAporte";
            this.nudAporte.Size = new System.Drawing.Size(120, 20);
            this.nudAporte.TabIndex = 10;
            // 
            // nudTaxa
            // 
            this.nudTaxa.DecimalPlaces = 7;
            this.nudTaxa.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTaxa.Location = new System.Drawing.Point(132, 29);
            this.nudTaxa.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.nudTaxa.Name = "nudTaxa";
            this.nudTaxa.Size = new System.Drawing.Size(108, 20);
            this.nudTaxa.TabIndex = 11;
            // 
            // nudTempo
            // 
            this.nudTempo.DecimalPlaces = 2;
            this.nudTempo.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTempo.Location = new System.Drawing.Point(132, 55);
            this.nudTempo.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.nudTempo.Name = "nudTempo";
            this.nudTempo.Size = new System.Drawing.Size(120, 20);
            this.nudTempo.TabIndex = 12;
            // 
            // cbTaxa
            // 
            this.cbTaxa.FormattingEnabled = true;
            this.cbTaxa.Items.AddRange(new object[] {
            "Mensal",
            "Anual"});
            this.cbTaxa.Location = new System.Drawing.Point(258, 29);
            this.cbTaxa.Name = "cbTaxa";
            this.cbTaxa.Size = new System.Drawing.Size(93, 21);
            this.cbTaxa.TabIndex = 13;
            this.cbTaxa.Text = "Anual";
            // 
            // cbTempo
            // 
            this.cbTempo.FormattingEnabled = true;
            this.cbTempo.Items.AddRange(new object[] {
            "Mensal",
            "Anual"});
            this.cbTempo.Location = new System.Drawing.Point(258, 54);
            this.cbTempo.Name = "cbTempo";
            this.cbTempo.Size = new System.Drawing.Size(93, 21);
            this.cbTempo.TabIndex = 14;
            this.cbTempo.Text = "Anual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(237, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "%";
            // 
            // nudValorFuturo
            // 
            this.nudValorFuturo.DecimalPlaces = 2;
            this.nudValorFuturo.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudValorFuturo.Location = new System.Drawing.Point(132, 136);
            this.nudValorFuturo.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.nudValorFuturo.Name = "nudValorFuturo";
            this.nudValorFuturo.Size = new System.Drawing.Size(120, 20);
            this.nudValorFuturo.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Valor Final:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Calcular Aporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(363, 382);
            this.Controls.Add(this.nudValorFuturo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nudTaxa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTempo);
            this.Controls.Add(this.cbTaxa);
            this.Controls.Add(this.nudTempo);
            this.Controls.Add(this.nudAporte);
            this.Controls.Add(this.nudValorAtual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juros Compostos";
            ((System.ComponentModel.ISupportInitialize)(this.nudValorAtual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaxa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorFuturo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudValorAtual;
        private System.Windows.Forms.NumericUpDown nudAporte;
        private System.Windows.Forms.NumericUpDown nudTaxa;
        private System.Windows.Forms.NumericUpDown nudTempo;
        private System.Windows.Forms.ComboBox cbTaxa;
        private System.Windows.Forms.ComboBox cbTempo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudValorFuturo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}

