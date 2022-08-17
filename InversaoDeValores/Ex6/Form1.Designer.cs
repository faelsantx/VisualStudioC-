namespace Ex6
{
    partial class Ex6
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtTrocaA = new System.Windows.Forms.TextBox();
            this.btnTroca = new System.Windows.Forms.Button();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTrocaB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(178, 3);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(47, 20);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(178, 29);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(47, 20);
            this.txtB.TabIndex = 1;
            // 
            // txtTrocaA
            // 
            this.txtTrocaA.Location = new System.Drawing.Point(178, 131);
            this.txtTrocaA.Name = "txtTrocaA";
            this.txtTrocaA.Size = new System.Drawing.Size(47, 20);
            this.txtTrocaA.TabIndex = 2;
            // 
            // btnTroca
            // 
            this.btnTroca.Location = new System.Drawing.Point(178, 55);
            this.btnTroca.Name = "btnTroca";
            this.btnTroca.Size = new System.Drawing.Size(47, 23);
            this.btnTroca.TabIndex = 3;
            this.btnTroca.Text = "Troca";
            this.btnTroca.UseVisualStyleBackColor = true;
            this.btnTroca.Click += new System.EventHandler(this.btnTroca_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(12, 9);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(109, 13);
            this.labelA.TabIndex = 4;
            this.labelA.Text = "Digite o valor para A: ";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(12, 36);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(106, 13);
            this.labelB.TabIndex = 5;
            this.labelB.Text = "Digite o valor para B:";
            this.labelB.Click += new System.EventHandler(this.labelB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor trocado de A:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Valor trocado de B:";
            // 
            // txtTrocaB
            // 
            this.txtTrocaB.Location = new System.Drawing.Point(178, 157);
            this.txtTrocaB.Name = "txtTrocaB";
            this.txtTrocaB.Size = new System.Drawing.Size(47, 20);
            this.txtTrocaB.TabIndex = 8;
            // 
            // Ex6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTrocaB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.btnTroca);
            this.Controls.Add(this.txtTrocaA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "Ex6";
            this.Text = "Ex6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtTrocaA;
        private System.Windows.Forms.Button btnTroca;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTrocaB;
    }
}

