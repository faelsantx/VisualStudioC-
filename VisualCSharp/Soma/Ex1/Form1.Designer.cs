namespace Ex1
{
    partial class Ex1
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
            this.labelN1 = new System.Windows.Forms.Label();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.labelN2 = new System.Windows.Forms.Label();
            this.btnSoma = new System.Windows.Forms.Button();
            this.txtRst = new System.Windows.Forms.TextBox();
            this.labelRst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(158, 48);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(46, 20);
            this.txtN1.TabIndex = 0;
            this.txtN1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelN1
            // 
            this.labelN1.AutoSize = true;
            this.labelN1.Location = new System.Drawing.Point(12, 55);
            this.labelN1.Name = "labelN1";
            this.labelN1.Size = new System.Drawing.Size(126, 13);
            this.labelN1.TabIndex = 1;
            this.labelN1.Text = "Digite o primeiro número: ";
            this.labelN1.Click += new System.EventHandler(this.label_Click);
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(158, 74);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(46, 20);
            this.txtN2.TabIndex = 2;
            // 
            // labelN2
            // 
            this.labelN2.AutoSize = true;
            this.labelN2.Location = new System.Drawing.Point(12, 81);
            this.labelN2.Name = "labelN2";
            this.labelN2.Size = new System.Drawing.Size(131, 13);
            this.labelN2.TabIndex = 3;
            this.labelN2.Text = "Digite o segundo número :";
            this.labelN2.Click += new System.EventHandler(this.labelN2_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(158, 100);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(46, 23);
            this.btnSoma.TabIndex = 4;
            this.btnSoma.Text = "Soma";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // txtRst
            // 
            this.txtRst.Location = new System.Drawing.Point(158, 144);
            this.txtRst.Name = "txtRst";
            this.txtRst.Size = new System.Drawing.Size(46, 20);
            this.txtRst.TabIndex = 5;
            // 
            // labelRst
            // 
            this.labelRst.AutoSize = true;
            this.labelRst.Location = new System.Drawing.Point(12, 151);
            this.labelRst.Name = "labelRst";
            this.labelRst.Size = new System.Drawing.Size(58, 13);
            this.labelRst.TabIndex = 6;
            this.labelRst.Text = "Resultado:";
            // 
            // Ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRst);
            this.Controls.Add(this.txtRst);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.labelN2);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.labelN1);
            this.Controls.Add(this.txtN1);
            this.Name = "Ex1";
            this.Text = "Ex1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label labelN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label labelN2;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.TextBox txtRst;
        private System.Windows.Forms.Label labelRst;
    }
}

