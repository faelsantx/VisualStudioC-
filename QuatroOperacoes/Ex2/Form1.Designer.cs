namespace Ex2
{
    partial class Ex2
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.labelN1 = new System.Windows.Forms.Label();
            this.labelN2 = new System.Windows.Forms.Label();
            this.labelRst = new System.Windows.Forms.Label();
            this.labelFrase = new System.Windows.Forms.Label();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(186, 46);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 20);
            this.txtN1.TabIndex = 0;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(186, 88);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 20);
            this.txtN2.TabIndex = 1;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(186, 217);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 2;
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(186, 142);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(29, 23);
            this.btnSoma.TabIndex = 3;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(238, 142);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(29, 23);
            this.btnSub.TabIndex = 4;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(238, 171);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(29, 23);
            this.btnDivisao.TabIndex = 6;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // labelN1
            // 
            this.labelN1.AutoSize = true;
            this.labelN1.Location = new System.Drawing.Point(41, 53);
            this.labelN1.Name = "labelN1";
            this.labelN1.Size = new System.Drawing.Size(126, 13);
            this.labelN1.TabIndex = 7;
            this.labelN1.Text = "Digite o primeiro número :";
            // 
            // labelN2
            // 
            this.labelN2.AutoSize = true;
            this.labelN2.Location = new System.Drawing.Point(41, 95);
            this.labelN2.Name = "labelN2";
            this.labelN2.Size = new System.Drawing.Size(131, 13);
            this.labelN2.TabIndex = 8;
            this.labelN2.Text = "Digite o segundo número: ";
            // 
            // labelRst
            // 
            this.labelRst.AutoSize = true;
            this.labelRst.Location = new System.Drawing.Point(41, 224);
            this.labelRst.Name = "labelRst";
            this.labelRst.Size = new System.Drawing.Size(58, 13);
            this.labelRst.TabIndex = 9;
            this.labelRst.Text = "Resultado:";
            // 
            // labelFrase
            // 
            this.labelFrase.AutoSize = true;
            this.labelFrase.Location = new System.Drawing.Point(41, 156);
            this.labelFrase.Name = "labelFrase";
            this.labelFrase.Size = new System.Drawing.Size(111, 13);
            this.labelFrase.TabIndex = 10;
            this.labelFrase.Text = "Selecione a operação";
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Location = new System.Drawing.Point(186, 171);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(29, 23);
            this.btnMultiplicacao.TabIndex = 11;
            this.btnMultiplicacao.Text = "*";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // Ex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.labelFrase);
            this.Controls.Add(this.labelRst);
            this.Controls.Add(this.labelN2);
            this.Controls.Add(this.labelN1);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Name = "Ex2";
            this.Text = "Ex2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Label labelN1;
        private System.Windows.Forms.Label labelN2;
        private System.Windows.Forms.Label labelRst;
        private System.Windows.Forms.Label labelFrase;
        private System.Windows.Forms.Button btnMultiplicacao;
    }
}

