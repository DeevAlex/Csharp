namespace Parte006
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
            this.checkedList = new System.Windows.Forms.CheckedListBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedList
            // 
            this.checkedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedList.CheckOnClick = true;
            this.checkedList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkedList.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkedList.ForeColor = System.Drawing.Color.DarkRed;
            this.checkedList.FormattingEnabled = true;
            this.checkedList.Location = new System.Drawing.Point(0, 0);
            this.checkedList.Name = "checkedList";
            this.checkedList.Size = new System.Drawing.Size(238, 382);
            this.checkedList.Sorted = true;
            this.checkedList.TabIndex = 0;
            this.checkedList.SelectedIndexChanged += new System.EventHandler(this.checkedList_SelectedIndexChanged);
            // 
            // btnExecutar
            // 
            this.btnExecutar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecutar.Location = new System.Drawing.Point(255, 13);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(249, 47);
            this.btnExecutar.TabIndex = 1;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.checkedList);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedList;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Label label1;
    }
}

