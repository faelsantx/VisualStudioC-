namespace Ex9
{
    partial class Ex9
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtRendimento = new System.Windows.Forms.TextBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelRendimento = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(198, 11);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(75, 20);
            this.txtValor.TabIndex = 0;
            // 
            // txtRendimento
            // 
            this.txtRendimento.Location = new System.Drawing.Point(198, 66);
            this.txtRendimento.Name = "txtRendimento";
            this.txtRendimento.Size = new System.Drawing.Size(75, 20);
            this.txtRendimento.TabIndex = 1;
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(10, 18);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(127, 13);
            this.labelValor.TabIndex = 2;
            this.labelValor.Text = "Digite o valor depositado:";
            // 
            // labelRendimento
            // 
            this.labelRendimento.AutoSize = true;
            this.labelRendimento.Location = new System.Drawing.Point(10, 73);
            this.labelRendimento.Name = "labelRendimento";
            this.labelRendimento.Size = new System.Drawing.Size(179, 13);
            this.labelRendimento.TabIndex = 3;
            this.labelRendimento.Text = "O valor do rendimento mensal foi de:";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(198, 37);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "------";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Ex9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.labelRendimento);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.txtRendimento);
            this.Controls.Add(this.txtValor);
            this.Name = "Ex9";
            this.Text = "Ex9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtRendimento;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelRendimento;
        private System.Windows.Forms.Button btn1;
    }
}

