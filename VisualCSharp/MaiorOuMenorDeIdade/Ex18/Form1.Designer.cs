namespace Ex18
{
    partial class Ex18
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
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtMM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(157, 15);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 0;
            // 
            // txtMM
            // 
            this.txtMM.Location = new System.Drawing.Point(157, 87);
            this.txtMM.Name = "txtMM";
            this.txtMM.Size = new System.Drawing.Size(100, 20);
            this.txtMM.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite a idade da pessoa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Essa pessoa é:";
            // 
            // btnMM
            // 
            this.btnMM.Location = new System.Drawing.Point(157, 41);
            this.btnMM.Name = "btnMM";
            this.btnMM.Size = new System.Drawing.Size(100, 23);
            this.btnMM.TabIndex = 4;
            this.btnMM.Text = "Maior ou menor";
            this.btnMM.UseVisualStyleBackColor = true;
            this.btnMM.Click += new System.EventHandler(this.btnMM_Click);
            // 
            // Ex18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMM);
            this.Controls.Add(this.txtIdade);
            this.Name = "Ex18";
            this.Text = "Ex18";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtMM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMM;
    }
}

