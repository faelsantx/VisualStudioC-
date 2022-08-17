namespace Ex14
{
    partial class Ex14
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
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtMaior = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMaior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(165, 14);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(72, 20);
            this.txtN1.TabIndex = 0;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(165, 40);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(72, 20);
            this.txtN2.TabIndex = 1;
            // 
            // txtMaior
            // 
            this.txtMaior.Location = new System.Drawing.Point(165, 112);
            this.txtMaior.Name = "txtMaior";
            this.txtMaior.Size = new System.Drawing.Size(72, 20);
            this.txtMaior.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite um número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Digite outro número:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "O maior entre eles é:";
            // 
            // btnMaior
            // 
            this.btnMaior.Location = new System.Drawing.Point(165, 77);
            this.btnMaior.Name = "btnMaior";
            this.btnMaior.Size = new System.Drawing.Size(72, 23);
            this.btnMaior.TabIndex = 6;
            this.btnMaior.Text = "Ver o maior";
            this.btnMaior.UseVisualStyleBackColor = true;
            this.btnMaior.Click += new System.EventHandler(this.btnMaior_Click);
            // 
            // Ex14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMaior);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaior);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Name = "Ex14";
            this.Text = "Ex14";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtMaior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMaior;
    }
}

