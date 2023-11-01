namespace Parte005
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
            this.check1 = new System.Windows.Forms.CheckBox();
            this.check2 = new System.Windows.Forms.CheckBox();
            this.check3 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.check1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check1.ForeColor = System.Drawing.Color.Maroon;
            this.check1.Location = new System.Drawing.Point(145, 106);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(109, 28);
            this.check1.TabIndex = 0;
            this.check1.Text = "Opcão 1";
            this.check1.UseVisualStyleBackColor = false;
            this.check1.CheckedChanged += new System.EventHandler(this.check1_CheckedChanged);
            // 
            // check2
            // 
            this.check2.AutoSize = true;
            this.check2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.check2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check2.ForeColor = System.Drawing.Color.Maroon;
            this.check2.Location = new System.Drawing.Point(145, 140);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(109, 28);
            this.check2.TabIndex = 1;
            this.check2.Text = "Opcão 2";
            this.check2.UseVisualStyleBackColor = false;
            this.check2.CheckedChanged += new System.EventHandler(this.check2_CheckedChanged);
            // 
            // check3
            // 
            this.check3.AutoSize = true;
            this.check3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.check3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check3.ForeColor = System.Drawing.Color.Maroon;
            this.check3.Location = new System.Drawing.Point(145, 174);
            this.check3.Name = "check3";
            this.check3.Size = new System.Drawing.Size(109, 28);
            this.check3.TabIndex = 2;
            this.check3.Text = "Opcão 3";
            this.check3.UseVisualStyleBackColor = false;
            this.check3.CheckedChanged += new System.EventHandler(this.check3_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(145, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 408);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.check3);
            this.Controls.Add(this.check2);
            this.Controls.Add(this.check1);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox check1;
        private System.Windows.Forms.CheckBox check2;
        private System.Windows.Forms.CheckBox check3;
        private System.Windows.Forms.Button button1;
    }
}

