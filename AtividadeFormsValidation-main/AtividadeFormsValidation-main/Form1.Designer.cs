namespace AtividadeFORMS
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnValid = new System.Windows.Forms.Button();
            this.TxtResu = new System.Windows.Forms.TextBox();
            this.RbnCPF = new System.Windows.Forms.RadioButton();
            this.RbnCNPJ = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // BtnValid
            // 
            this.BtnValid.Location = new System.Drawing.Point(296, 265);
            this.BtnValid.Name = "BtnValid";
            this.BtnValid.Size = new System.Drawing.Size(202, 54);
            this.BtnValid.TabIndex = 0;
            this.BtnValid.Text = "Validar";
            this.BtnValid.UseVisualStyleBackColor = true;
            // 
            // TxtResu
            // 
            this.TxtResu.Location = new System.Drawing.Point(298, 180);
            this.TxtResu.Name = "TxtResu";
            this.TxtResu.Size = new System.Drawing.Size(200, 20);
            this.TxtResu.TabIndex = 3;
            // 
            // RbnCPF
            // 
            this.RbnCPF.AutoSize = true;
            this.RbnCPF.Location = new System.Drawing.Point(272, 134);
            this.RbnCPF.Name = "RbnCPF";
            this.RbnCPF.Size = new System.Drawing.Size(45, 17);
            this.RbnCPF.TabIndex = 4;
            this.RbnCPF.TabStop = true;
            this.RbnCPF.Text = "CPF";
            this.RbnCPF.UseVisualStyleBackColor = true;
            // 
            // RbnCNPJ
            // 
            this.RbnCNPJ.AutoSize = true;
            this.RbnCNPJ.Location = new System.Drawing.Point(462, 134);
            this.RbnCNPJ.Name = "RbnCNPJ";
            this.RbnCNPJ.Size = new System.Drawing.Size(52, 17);
            this.RbnCNPJ.TabIndex = 5;
            this.RbnCNPJ.TabStop = true;
            this.RbnCNPJ.Text = "CNPJ";
            this.RbnCNPJ.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RbnCNPJ);
            this.Controls.Add(this.RbnCPF);
            this.Controls.Add(this.TxtResu);
            this.Controls.Add(this.BtnValid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnValid;
        private System.Windows.Forms.TextBox TxtResu;
        private System.Windows.Forms.RadioButton RbnCPF;
        private System.Windows.Forms.RadioButton RbnCNPJ;
    }
}

