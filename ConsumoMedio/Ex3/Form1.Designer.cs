namespace Ex3
{
    partial class Ex3
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
            this.btnMedia = new System.Windows.Forms.Button();
            this.txtDist = new System.Windows.Forms.TextBox();
            this.txtComb = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.labelDist = new System.Windows.Forms.Label();
            this.labelCombustivel = new System.Windows.Forms.Label();
            this.labelMedia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(259, 141);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(100, 23);
            this.btnMedia.TabIndex = 0;
            this.btnMedia.Text = "Calcule";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // txtDist
            // 
            this.txtDist.Location = new System.Drawing.Point(259, 48);
            this.txtDist.Name = "txtDist";
            this.txtDist.Size = new System.Drawing.Size(100, 20);
            this.txtDist.TabIndex = 1;
            // 
            // txtComb
            // 
            this.txtComb.Location = new System.Drawing.Point(259, 84);
            this.txtComb.Name = "txtComb";
            this.txtComb.Size = new System.Drawing.Size(100, 20);
            this.txtComb.TabIndex = 2;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(259, 197);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(100, 20);
            this.txtMedia.TabIndex = 3;
            // 
            // labelDist
            // 
            this.labelDist.AutoSize = true;
            this.labelDist.Location = new System.Drawing.Point(71, 55);
            this.labelDist.Name = "labelDist";
            this.labelDist.Size = new System.Drawing.Size(141, 13);
            this.labelDist.TabIndex = 4;
            this.labelDist.Text = "Digite a distância percorrida:";
            // 
            // labelCombustivel
            // 
            this.labelCombustivel.AutoSize = true;
            this.labelCombustivel.Location = new System.Drawing.Point(71, 91);
            this.labelCombustivel.Name = "labelCombustivel";
            this.labelCombustivel.Size = new System.Drawing.Size(136, 13);
            this.labelCombustivel.TabIndex = 5;
            this.labelCombustivel.Text = "Digite o combustível gasto:";
            // 
            // labelMedia
            // 
            this.labelMedia.AutoSize = true;
            this.labelMedia.Location = new System.Drawing.Point(71, 204);
            this.labelMedia.Name = "labelMedia";
            this.labelMedia.Size = new System.Drawing.Size(170, 13);
            this.labelMedia.TabIndex = 6;
            this.labelMedia.Text = " A média de combustível gasto foi:";
            // 
            // Ex3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMedia);
            this.Controls.Add(this.labelCombustivel);
            this.Controls.Add(this.labelDist);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.txtComb);
            this.Controls.Add(this.txtDist);
            this.Controls.Add(this.btnMedia);
            this.Name = "Ex3";
            this.Text = "Ex3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.TextBox txtDist;
        private System.Windows.Forms.TextBox txtComb;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label labelDist;
        private System.Windows.Forms.Label labelCombustivel;
        private System.Windows.Forms.Label labelMedia;
    }
}

