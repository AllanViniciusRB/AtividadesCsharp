namespace Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnCalcular = new Button();
            BtnExit = new Button();
            RdnCpf = new RadioButton();
            RdnCnpj = new RadioButton();
            TxtResultado = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // BtnCalcular
            // 
            BtnCalcular.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCalcular.Location = new Point(269, 263);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(95, 39);
            BtnCalcular.TabIndex = 0;
            BtnCalcular.Text = "Validar";
            BtnCalcular.UseVisualStyleBackColor = true;        
            // 
            // BtnExit
            // 
            BtnExit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnExit.Location = new Point(436, 263);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(97, 39);
            BtnExit.TabIndex = 1;
            BtnExit.Text = "Sair";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // RdnCpf
            // 
            RdnCpf.AutoSize = true;
            RdnCpf.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            RdnCpf.Location = new Point(226, 107);
            RdnCpf.Name = "RdnCpf";
            RdnCpf.Size = new Size(157, 31);
            RdnCpf.TabIndex = 2;
            RdnCpf.TabStop = true;
            RdnCpf.Text = "Validar CPF";
            RdnCpf.UseVisualStyleBackColor = true;
            // 
            // RdnCnpj
            // 
            RdnCnpj.AutoSize = true;
            RdnCnpj.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            RdnCnpj.Location = new Point(415, 107);
            RdnCnpj.Name = "RdnCnpj";
            RdnCnpj.Size = new Size(171, 31);
            RdnCnpj.TabIndex = 3;
            RdnCnpj.TabStop = true;
            RdnCnpj.Text = "Validar CNPJ";
            RdnCnpj.UseVisualStyleBackColor = true;
            // 
            // TxtResultado
            // 
            TxtResultado.Location = new Point(241, 171);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(329, 57);
            TxtResultado.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(212, 37);
            label1.Name = "label1";
            label1.Size = new Size(388, 43);
            label1.TabIndex = 5;
            label1.Text = "Validador de CPF E CNPJ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(TxtResultado);
            Controls.Add(RdnCnpj);
            Controls.Add(RdnCpf);
            Controls.Add(BtnExit);
            Controls.Add(BtnCalcular);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCalcular;
        private Button BtnExit;
        private RadioButton RdnCpf;
        private RadioButton RdnCnpj;
        private TextBox TxtResultado;
        private Label label1;
    }
}