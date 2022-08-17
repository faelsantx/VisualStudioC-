namespace Ex7
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
            this.labelGraus = new System.Windows.Forms.Label();
            this.labelFah = new System.Windows.Forms.Label();
            this.txtGraus = new System.Windows.Forms.TextBox();
            this.txtFah = new System.Windows.Forms.TextBox();
            this.btnConversao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGraus
            // 
            this.labelGraus.AutoSize = true;
            this.labelGraus.Location = new System.Drawing.Point(3, 14);
            this.labelGraus.Name = "labelGraus";
            this.labelGraus.Size = new System.Drawing.Size(158, 13);
            this.labelGraus.TabIndex = 0;
            this.labelGraus.Text = "Digite a temperatura em Celsius:";
            // 
            // labelFah
            // 
            this.labelFah.AutoSize = true;
            this.labelFah.Location = new System.Drawing.Point(3, 69);
            this.labelFah.Name = "labelFah";
            this.labelFah.Size = new System.Drawing.Size(208, 13);
            this.labelFah.TabIndex = 1;
            this.labelFah.Text = "A temperatura convertida em Fahrenheit é:";
            // 
            // txtGraus
            // 
            this.txtGraus.Location = new System.Drawing.Point(220, 7);
            this.txtGraus.Name = "txtGraus";
            this.txtGraus.Size = new System.Drawing.Size(66, 20);
            this.txtGraus.TabIndex = 2;
            // 
            // txtFah
            // 
            this.txtFah.Location = new System.Drawing.Point(220, 62);
            this.txtFah.Name = "txtFah";
            this.txtFah.Size = new System.Drawing.Size(66, 20);
            this.txtFah.TabIndex = 3;
            // 
            // btnConversao
            // 
            this.btnConversao.Location = new System.Drawing.Point(220, 33);
            this.btnConversao.Name = "btnConversao";
            this.btnConversao.Size = new System.Drawing.Size(66, 23);
            this.btnConversao.TabIndex = 4;
            this.btnConversao.Text = "Conversão";
            this.btnConversao.UseVisualStyleBackColor = true;
            this.btnConversao.Click += new System.EventHandler(this.btnConversao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConversao);
            this.Controls.Add(this.txtFah);
            this.Controls.Add(this.txtGraus);
            this.Controls.Add(this.labelFah);
            this.Controls.Add(this.labelGraus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGraus;
        private System.Windows.Forms.Label labelFah;
        private System.Windows.Forms.TextBox txtGraus;
        private System.Windows.Forms.TextBox txtFah;
        private System.Windows.Forms.Button btnConversao;
    }
}

