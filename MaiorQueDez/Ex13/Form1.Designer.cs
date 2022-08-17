namespace Ex13
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
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(240, 14);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(75, 20);
            this.txtN1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite um número:";
            // 
            // txtMM
            // 
            this.txtMM.Location = new System.Drawing.Point(240, 69);
            this.txtMM.Name = "txtMM";
            this.txtMM.Size = new System.Drawing.Size(75, 20);
            this.txtMM.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Comparado ao número 10, esse número é:";
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(240, 40);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 6;
            this.btnVer.Text = "----------";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtN1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVer;
    }
}

