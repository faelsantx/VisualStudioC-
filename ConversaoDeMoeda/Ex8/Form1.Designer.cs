namespace Ex8
{
    partial class Ex8
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
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtReal = new System.Windows.Forms.TextBox();
            this.labelDolar = new System.Windows.Forms.Label();
            this.labelQtd = new System.Windows.Forms.Label();
            this.labelReal = new System.Windows.Forms.Label();
            this.btnConversao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(213, 3);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(75, 20);
            this.txtDolar.TabIndex = 0;
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(213, 29);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(75, 20);
            this.txtQtd.TabIndex = 1;
            // 
            // txtReal
            // 
            this.txtReal.Location = new System.Drawing.Point(213, 84);
            this.txtReal.Name = "txtReal";
            this.txtReal.Size = new System.Drawing.Size(75, 20);
            this.txtReal.TabIndex = 2;
            // 
            // labelDolar
            // 
            this.labelDolar.AutoSize = true;
            this.labelDolar.Location = new System.Drawing.Point(12, 9);
            this.labelDolar.Name = "labelDolar";
            this.labelDolar.Size = new System.Drawing.Size(113, 13);
            this.labelDolar.TabIndex = 3;
            this.labelDolar.Text = "Digite o valor do dólar:";
            // 
            // labelQtd
            // 
            this.labelQtd.AutoSize = true;
            this.labelQtd.Location = new System.Drawing.Point(12, 35);
            this.labelQtd.Name = "labelQtd";
            this.labelQtd.Size = new System.Drawing.Size(162, 13);
            this.labelQtd.TabIndex = 4;
            this.labelQtd.Text = "Digite quantos dólares você tem:";
            // 
            // labelReal
            // 
            this.labelReal.AutoSize = true;
            this.labelReal.Location = new System.Drawing.Point(12, 91);
            this.labelReal.Name = "labelReal";
            this.labelReal.Size = new System.Drawing.Size(95, 13);
            this.labelReal.TabIndex = 5;
            this.labelReal.Text = "O valor em reais é:";
            // 
            // btnConversao
            // 
            this.btnConversao.Location = new System.Drawing.Point(213, 55);
            this.btnConversao.Name = "btnConversao";
            this.btnConversao.Size = new System.Drawing.Size(75, 23);
            this.btnConversao.TabIndex = 6;
            this.btnConversao.Text = "Conversão";
            this.btnConversao.UseVisualStyleBackColor = true;
            this.btnConversao.Click += new System.EventHandler(this.btnConversao_Click);
            // 
            // Ex8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConversao);
            this.Controls.Add(this.labelReal);
            this.Controls.Add(this.labelQtd);
            this.Controls.Add(this.labelDolar);
            this.Controls.Add(this.txtReal);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.txtDolar);
            this.Name = "Ex8";
            this.Text = "Ex8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtReal;
        private System.Windows.Forms.Label labelDolar;
        private System.Windows.Forms.Label labelQtd;
        private System.Windows.Forms.Label labelReal;
        private System.Windows.Forms.Button btnConversao;
    }
}

