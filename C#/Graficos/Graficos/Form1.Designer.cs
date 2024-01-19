namespace Graficos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnInserirValores = new System.Windows.Forms.Button();
            this.btnAleatorio = new System.Windows.Forms.Button();
            this.grafico3D = new System.Windows.Forms.CheckBox();
            this.palletCor = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.xValor = new System.Windows.Forms.TextBox();
            this.yValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tipoGrafico = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInserirValores
            // 
            this.btnInserirValores.Location = new System.Drawing.Point(12, 150);
            this.btnInserirValores.Name = "btnInserirValores";
            this.btnInserirValores.Size = new System.Drawing.Size(279, 43);
            this.btnInserirValores.TabIndex = 0;
            this.btnInserirValores.Text = "Inserir Valores no Gráfico";
            this.btnInserirValores.UseVisualStyleBackColor = true;
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.Location = new System.Drawing.Point(713, 456);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(264, 43);
            this.btnAleatorio.TabIndex = 1;
            this.btnAleatorio.Text = "Inserir Valores Aleatorios";
            this.btnAleatorio.UseVisualStyleBackColor = true;
            // 
            // grafico3D
            // 
            this.grafico3D.AutoSize = true;
            this.grafico3D.Location = new System.Drawing.Point(576, 464);
            this.grafico3D.Name = "grafico3D";
            this.grafico3D.Size = new System.Drawing.Size(131, 28);
            this.grafico3D.TabIndex = 2;
            this.grafico3D.Text = "Gráfico 3D";
            this.grafico3D.UseVisualStyleBackColor = true;
            // 
            // palletCor
            // 
            this.palletCor.FormattingEnabled = true;
            this.palletCor.Location = new System.Drawing.Point(297, 462);
            this.palletCor.Name = "palletCor";
            this.palletCor.Size = new System.Drawing.Size(273, 32);
            this.palletCor.TabIndex = 3;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(13, 413);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(278, 43);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar Gráfico";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // xValor
            // 
            this.xValor.Location = new System.Drawing.Point(12, 112);
            this.xValor.Name = "xValor";
            this.xValor.Size = new System.Drawing.Size(135, 32);
            this.xValor.TabIndex = 6;
            // 
            // yValor
            // 
            this.yValor.Location = new System.Drawing.Point(157, 112);
            this.yValor.Name = "yValor";
            this.yValor.Size = new System.Drawing.Size(134, 32);
            this.yValor.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gráfico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Y";
            // 
            // tipoGrafico
            // 
            this.tipoGrafico.FormattingEnabled = true;
            this.tipoGrafico.Location = new System.Drawing.Point(12, 462);
            this.tipoGrafico.Name = "tipoGrafico";
            this.tipoGrafico.Size = new System.Drawing.Size(279, 32);
            this.tipoGrafico.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridView1.Location = new System.Drawing.Point(13, 200);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(278, 207);
            this.dataGridView1.TabIndex = 12;
            // 
            // X
            // 
            this.X.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.X.HeaderText = "Eixo X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            // 
            // Y
            // 
            this.Y.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Y.HeaderText = "Eixo Y";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            // 
            // grafico
            // 
            chartArea1.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafico.Legends.Add(legend1);
            this.grafico.Location = new System.Drawing.Point(297, 13);
            this.grafico.Name = "grafico";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grafico.Series.Add(series1);
            this.grafico.Size = new System.Drawing.Size(680, 443);
            this.grafico.TabIndex = 13;
            this.grafico.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 509);
            this.Controls.Add(this.grafico);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tipoGrafico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yValor);
            this.Controls.Add(this.xValor);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.palletCor);
            this.Controls.Add(this.grafico3D);
            this.Controls.Add(this.btnAleatorio);
            this.Controls.Add(this.btnInserirValores);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserirValores;
        private System.Windows.Forms.Button btnAleatorio;
        private System.Windows.Forms.CheckBox grafico3D;
        private System.Windows.Forms.ComboBox palletCor;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox xValor;
        private System.Windows.Forms.TextBox yValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tipoGrafico;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
    }
}

