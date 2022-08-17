namespace Ex4
{
    partial class Ex4
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.txtVendas = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelSal = new System.Windows.Forms.Label();
            this.labelVendas = new System.Windows.Forms.Label();
            this.labelFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(213, 11);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(213, 53);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(100, 20);
            this.txtSal.TabIndex = 1;
            // 
            // txtVendas
            // 
            this.txtVendas.Location = new System.Drawing.Point(213, 95);
            this.txtVendas.Name = "txtVendas";
            this.txtVendas.Size = new System.Drawing.Size(100, 20);
            this.txtVendas.TabIndex = 2;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(213, 176);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(100, 20);
            this.txtFinal.TabIndex = 3;
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(213, 134);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(100, 23);
            this.btnCalculo.TabIndex = 4;
            this.btnCalculo.Text = "--------";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 18);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(138, 13);
            this.labelNome.TabIndex = 5;
            this.labelNome.Text = "Digite o nome do vendedor:";
            // 
            // labelSal
            // 
            this.labelSal.AutoSize = true;
            this.labelSal.Location = new System.Drawing.Point(11, 60);
            this.labelSal.Name = "labelSal";
            this.labelSal.Size = new System.Drawing.Size(109, 13);
            this.labelSal.TabIndex = 6;
            this.labelSal.Text = "Digite seu salário fixo:";
            // 
            // labelVendas
            // 
            this.labelVendas.AutoSize = true;
            this.labelVendas.Location = new System.Drawing.Point(12, 102);
            this.labelVendas.Name = "labelVendas";
            this.labelVendas.Size = new System.Drawing.Size(179, 13);
            this.labelVendas.TabIndex = 7;
            this.labelVendas.Text = "Digite o total de vendas em dinheiro:";
            // 
            // labelFinal
            // 
            this.labelFinal.AutoSize = true;
            this.labelFinal.Location = new System.Drawing.Point(12, 183);
            this.labelFinal.Name = "labelFinal";
            this.labelFinal.Size = new System.Drawing.Size(108, 13);
            this.labelFinal.TabIndex = 8;
            this.labelFinal.Text = "Seu salário final é de:";
            // 
            // Ex4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelFinal);
            this.Controls.Add(this.labelVendas);
            this.Controls.Add(this.labelSal);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtVendas);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.txtNome);
            this.Name = "Ex4";
            this.Text = "Ex4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.TextBox txtVendas;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelSal;
        private System.Windows.Forms.Label labelVendas;
        private System.Windows.Forms.Label labelFinal;
    }
}

