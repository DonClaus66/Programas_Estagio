namespace DetectarChar
{
    partial class mtbCaracter
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerif = new System.Windows.Forms.Button();
            this.txtCaracter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o Caracter";
            // 
            // btnVerif
            // 
            this.btnVerif.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerif.Location = new System.Drawing.Point(103, 168);
            this.btnVerif.Name = "btnVerif";
            this.btnVerif.Size = new System.Drawing.Size(151, 48);
            this.btnVerif.TabIndex = 2;
            this.btnVerif.Text = "Verificar";
            this.btnVerif.UseVisualStyleBackColor = true;
            this.btnVerif.Click += new System.EventHandler(this.btnVerif_Click);
            // 
            // txtCaracter
            // 
            this.txtCaracter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCaracter.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaracter.Location = new System.Drawing.Point(149, 89);
            this.txtCaracter.MaxLength = 1;
            this.txtCaracter.Name = "txtCaracter";
            this.txtCaracter.Size = new System.Drawing.Size(58, 47);
            this.txtCaracter.TabIndex = 4;
            this.txtCaracter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbCaracter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 245);
            this.Controls.Add(this.txtCaracter);
            this.Controls.Add(this.btnVerif);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "mtbCaracter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificar Char";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerif;
        private System.Windows.Forms.TextBox txtCaracter;
    }
}

