namespace Parte016
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
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Location = new System.Drawing.Point(39, 43);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(114, 28);
            this.radio1.TabIndex = 0;
            this.radio1.TabStop = true;
            this.radio1.Text = "Vermelho";
            this.radio1.UseVisualStyleBackColor = true;
            this.radio1.CheckedChanged += new System.EventHandler(this.radio1_CheckedChanged);
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(39, 77);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(82, 28);
            this.radio2.TabIndex = 1;
            this.radio2.TabStop = true;
            this.radio2.Text = "Verde";
            this.radio2.UseVisualStyleBackColor = true;
            this.radio2.CheckedChanged += new System.EventHandler(this.radio2_CheckedChanged);
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Location = new System.Drawing.Point(39, 111);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(65, 28);
            this.radio3.TabIndex = 2;
            this.radio3.TabStop = true;
            this.radio3.Text = "Azul";
            this.radio3.UseVisualStyleBackColor = true;
            this.radio3.CheckedChanged += new System.EventHandler(this.radio3_CheckedChanged);
            // 
            // btn
            // 
            this.btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn.Location = new System.Drawing.Point(39, 307);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(114, 38);
            this.btn.TabIndex = 3;
            this.btn.Text = "Executar";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 370);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.radio3);
            this.Controls.Add(this.radio2);
            this.Controls.Add(this.radio1);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.Button btn;
    }
}

