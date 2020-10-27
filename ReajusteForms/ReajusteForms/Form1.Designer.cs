namespace ReajusteForms
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
            this.salarioNaoAjustado = new System.Windows.Forms.TextBox();
            this.salarioReajustado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // salarioNaoAjustado
            // 
            this.salarioNaoAjustado.Enabled = false;
            this.salarioNaoAjustado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salarioNaoAjustado.Location = new System.Drawing.Point(32, 73);
            this.salarioNaoAjustado.Multiline = true;
            this.salarioNaoAjustado.Name = "salarioNaoAjustado";
            this.salarioNaoAjustado.Size = new System.Drawing.Size(452, 313);
            this.salarioNaoAjustado.TabIndex = 1;
            // 
            // salarioReajustado
            // 
            this.salarioReajustado.Enabled = false;
            this.salarioReajustado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salarioReajustado.Location = new System.Drawing.Point(509, 73);
            this.salarioReajustado.Multiline = true;
            this.salarioReajustado.Name = "salarioReajustado";
            this.salarioReajustado.Size = new System.Drawing.Size(452, 313);
            this.salarioReajustado.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Salários não ajustados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(653, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Salários ajustados:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 409);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salarioReajustado);
            this.Controls.Add(this.salarioNaoAjustado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reajuste Salarial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox salarioNaoAjustado;
        private System.Windows.Forms.TextBox salarioReajustado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

