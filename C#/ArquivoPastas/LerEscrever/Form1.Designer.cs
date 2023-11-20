namespace LerEscrever
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
            this.btnEscreverTxt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLerTxt = new System.Windows.Forms.Button();
            this.txtConteudo = new System.Windows.Forms.RichTextBox();
            this.btnLerBinary = new System.Windows.Forms.Button();
            this.btnEscreverBinary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEscreverTxt
            // 
            this.btnEscreverTxt.Location = new System.Drawing.Point(13, 240);
            this.btnEscreverTxt.Name = "btnEscreverTxt";
            this.btnEscreverTxt.Size = new System.Drawing.Size(160, 48);
            this.btnEscreverTxt.TabIndex = 1;
            this.btnEscreverTxt.Text = "Escrever TXT";
            this.btnEscreverTxt.UseVisualStyleBackColor = true;
            this.btnEscreverTxt.Click += new System.EventHandler(this.btnEscreverTxt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 2;
            // 
            // btnLerTxt
            // 
            this.btnLerTxt.Location = new System.Drawing.Point(179, 240);
            this.btnLerTxt.Name = "btnLerTxt";
            this.btnLerTxt.Size = new System.Drawing.Size(147, 48);
            this.btnLerTxt.TabIndex = 3;
            this.btnLerTxt.Text = "Ler TXT";
            this.btnLerTxt.UseVisualStyleBackColor = true;
            this.btnLerTxt.Click += new System.EventHandler(this.btnLerTxt_Click);
            // 
            // txtConteudo
            // 
            this.txtConteudo.Location = new System.Drawing.Point(13, 13);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(664, 221);
            this.txtConteudo.TabIndex = 4;
            this.txtConteudo.Text = "";
            // 
            // btnLerBinary
            // 
            this.btnLerBinary.Location = new System.Drawing.Point(332, 240);
            this.btnLerBinary.Name = "btnLerBinary";
            this.btnLerBinary.Size = new System.Drawing.Size(147, 48);
            this.btnLerBinary.TabIndex = 5;
            this.btnLerBinary.Text = "Ler Binary";
            this.btnLerBinary.UseVisualStyleBackColor = true;
            this.btnLerBinary.Click += new System.EventHandler(this.btnLerBinary_Click);
            // 
            // btnEscreverBinary
            // 
            this.btnEscreverBinary.Location = new System.Drawing.Point(485, 240);
            this.btnEscreverBinary.Name = "btnEscreverBinary";
            this.btnEscreverBinary.Size = new System.Drawing.Size(192, 48);
            this.btnEscreverBinary.TabIndex = 6;
            this.btnEscreverBinary.Text = "Escrever Binary";
            this.btnEscreverBinary.UseVisualStyleBackColor = true;
            this.btnEscreverBinary.Click += new System.EventHandler(this.btnEscreverBinary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 300);
            this.Controls.Add(this.btnEscreverBinary);
            this.Controls.Add(this.btnLerBinary);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.btnLerTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEscreverTxt);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEscreverTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLerTxt;
        private System.Windows.Forms.RichTextBox txtConteudo;
        private System.Windows.Forms.Button btnLerBinary;
        private System.Windows.Forms.Button btnEscreverBinary;
    }
}

