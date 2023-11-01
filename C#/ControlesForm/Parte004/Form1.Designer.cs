namespace Parte004
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
            this.lista = new System.Windows.Forms.ListBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lista.Dock = System.Windows.Forms.DockStyle.Right;
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 24;
            this.lista.Location = new System.Drawing.Point(308, 0);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(383, 310);
            this.lista.Sorted = true;
            this.lista.TabIndex = 0;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Location = new System.Drawing.Point(23, 51);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(262, 45);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(23, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(262, 32);
            this.txtNome.TabIndex = 2;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(23, 102);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(262, 45);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverItem.Location = new System.Drawing.Point(23, 204);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(262, 45);
            this.btnRemoverItem.TabIndex = 4;
            this.btnRemoverItem.Text = "Remover Item do Inicio";
            this.btnRemoverItem.UseVisualStyleBackColor = true;
            this.btnRemoverItem.Click += new System.EventHandler(this.btnRemoverItem_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(23, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Remover Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(23, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 45);
            this.button2.TabIndex = 6;
            this.button2.Text = "Quantidade de Items";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 310);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRemoverItem);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lista);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnRemoverItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

