namespace LINQ_1
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
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.btnWhere = new System.Windows.Forms.Button();
            this.btnOrderBy = new System.Windows.Forms.Button();
            this.btnGroupBy = new System.Windows.Forms.Button();
            this.btnAgregacao = new System.Windows.Forms.Button();
            this.btnElemento = new System.Windows.Forms.Button();
            this.btnLambdas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.Dock = System.Windows.Forms.DockStyle.Left;
            this.lista.FormattingEnabled = true;
            this.lista.HorizontalScrollbar = true;
            this.lista.ItemHeight = 24;
            this.lista.Location = new System.Drawing.Point(0, 0);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(482, 355);
            this.lista.TabIndex = 0;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(488, 0);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(215, 32);
            this.txtConsulta.TabIndex = 1;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(488, 50);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(215, 37);
            this.btnExecutar.TabIndex = 2;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.Location = new System.Drawing.Point(488, 93);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(215, 37);
            this.btnWhere.TabIndex = 3;
            this.btnWhere.Text = "Where";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // btnOrderBy
            // 
            this.btnOrderBy.Location = new System.Drawing.Point(488, 136);
            this.btnOrderBy.Name = "btnOrderBy";
            this.btnOrderBy.Size = new System.Drawing.Size(215, 37);
            this.btnOrderBy.TabIndex = 4;
            this.btnOrderBy.Text = "Order By";
            this.btnOrderBy.UseVisualStyleBackColor = true;
            this.btnOrderBy.Click += new System.EventHandler(this.btnOrderBy_Click);
            // 
            // btnGroupBy
            // 
            this.btnGroupBy.Location = new System.Drawing.Point(488, 179);
            this.btnGroupBy.Name = "btnGroupBy";
            this.btnGroupBy.Size = new System.Drawing.Size(215, 37);
            this.btnGroupBy.TabIndex = 5;
            this.btnGroupBy.Text = "Group By";
            this.btnGroupBy.UseVisualStyleBackColor = true;
            this.btnGroupBy.Click += new System.EventHandler(this.btnGroupBy_Click);
            // 
            // btnAgregacao
            // 
            this.btnAgregacao.Location = new System.Drawing.Point(488, 222);
            this.btnAgregacao.Name = "btnAgregacao";
            this.btnAgregacao.Size = new System.Drawing.Size(215, 37);
            this.btnAgregacao.TabIndex = 6;
            this.btnAgregacao.Text = "Agregação";
            this.btnAgregacao.UseVisualStyleBackColor = true;
            this.btnAgregacao.Click += new System.EventHandler(this.btnAgregacao_Click);
            // 
            // btnElemento
            // 
            this.btnElemento.Location = new System.Drawing.Point(488, 265);
            this.btnElemento.Name = "btnElemento";
            this.btnElemento.Size = new System.Drawing.Size(215, 37);
            this.btnElemento.TabIndex = 7;
            this.btnElemento.Text = "Elemento";
            this.btnElemento.UseVisualStyleBackColor = true;
            this.btnElemento.Click += new System.EventHandler(this.btnElemento_Click);
            // 
            // btnLambdas
            // 
            this.btnLambdas.Location = new System.Drawing.Point(488, 308);
            this.btnLambdas.Name = "btnLambdas";
            this.btnLambdas.Size = new System.Drawing.Size(215, 37);
            this.btnLambdas.TabIndex = 8;
            this.btnLambdas.Text = "Lambdas";
            this.btnLambdas.UseVisualStyleBackColor = true;
            this.btnLambdas.Click += new System.EventHandler(this.btnLambdas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 355);
            this.Controls.Add(this.btnLambdas);
            this.Controls.Add(this.btnElemento);
            this.Controls.Add(this.btnAgregacao);
            this.Controls.Add(this.btnGroupBy);
            this.Controls.Add(this.btnOrderBy);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.txtConsulta);
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
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button btnOrderBy;
        private System.Windows.Forms.Button btnGroupBy;
        private System.Windows.Forms.Button btnAgregacao;
        private System.Windows.Forms.Button btnElemento;
        private System.Windows.Forms.Button btnLambdas;
    }
}

