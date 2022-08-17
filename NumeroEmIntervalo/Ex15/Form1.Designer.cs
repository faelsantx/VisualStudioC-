namespace Ex15
{
    partial class Ex15
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
            this.txtInt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(238, 17);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(79, 20);
            this.txtN1.TabIndex = 0;
            this.txtN1.TextChanged += new System.EventHandler(this.txtN1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite um número:";
            // 
            // txtInt
            // 
            this.txtInt.Location = new System.Drawing.Point(238, 92);
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(79, 20);
            this.txtInt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "No intervalo entre 100 e 200 esse número:";
            // 
            // btnInt
            // 
            this.btnInt.Location = new System.Drawing.Point(238, 53);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(79, 23);
            this.btnInt.TabIndex = 4;
            this.btnInt.Text = "Intervalo";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // Ex15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtN1);
            this.Name = "Ex15";
            this.Text = "Ex15";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInt;
    }
}

