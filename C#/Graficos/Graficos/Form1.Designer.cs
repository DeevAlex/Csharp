﻿namespace Graficos
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
            this.components = new System.ComponentModel.Container();
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
            this.dataValores = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataValores)).BeginInit();
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
            this.btnInserirValores.Click += new System.EventHandler(this.btnInserirValores_Click);
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.Location = new System.Drawing.Point(713, 456);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(264, 43);
            this.btnAleatorio.TabIndex = 1;
            this.btnAleatorio.Text = "Inserir Valores Aleatorios";
            this.btnAleatorio.UseVisualStyleBackColor = true;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
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
            this.grafico3D.CheckedChanged += new System.EventHandler(this.grafico3D_CheckedChanged);
            // 
            // palletCor
            // 
            this.palletCor.FormattingEnabled = true;
            this.palletCor.Location = new System.Drawing.Point(297, 462);
            this.palletCor.Name = "palletCor";
            this.palletCor.Size = new System.Drawing.Size(273, 32);
            this.palletCor.TabIndex = 3;
            this.palletCor.SelectedIndexChanged += new System.EventHandler(this.palletCor_SelectedIndexChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(13, 413);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(278, 43);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar Gráfico";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // xValor
            // 
            this.xValor.Location = new System.Drawing.Point(12, 112);
            this.xValor.Name = "xValor";
            this.xValor.Size = new System.Drawing.Size(135, 32);
            this.xValor.TabIndex = 6;
            this.xValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xValor_KeyPress);
            // 
            // yValor
            // 
            this.yValor.Location = new System.Drawing.Point(157, 112);
            this.yValor.Name = "yValor";
            this.yValor.Size = new System.Drawing.Size(134, 32);
            this.yValor.TabIndex = 7;
            this.yValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yValor_KeyPress);
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
            this.tipoGrafico.SelectedIndexChanged += new System.EventHandler(this.tipoGrafico_SelectedIndexChanged);
            // 
            // dataValores
            // 
            this.dataValores.AllowUserToAddRows = false;
            this.dataValores.AllowUserToDeleteRows = false;
            this.dataValores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataValores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataValores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataValores.Location = new System.Drawing.Point(13, 200);
            this.dataValores.MultiSelect = false;
            this.dataValores.Name = "dataValores";
            this.dataValores.ReadOnly = true;
            this.dataValores.RowHeadersVisible = false;
            this.dataValores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataValores.Size = new System.Drawing.Size(278, 207);
            this.dataValores.TabIndex = 12;
            this.dataValores.SelectionChanged += new System.EventHandler(this.dataValores_SelectionChanged);
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
            this.grafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "X vs Y";
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series1.YValuesPerPoint = 4;
            this.grafico.Series.Add(series1);
            this.grafico.Size = new System.Drawing.Size(680, 443);
            this.grafico.TabIndex = 13;
            this.grafico.Text = "chart1";
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 509);
            this.Controls.Add(this.grafico);
            this.Controls.Add(this.dataValores);
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
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataValores)).EndInit();
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
        private System.Windows.Forms.DataGridView dataValores;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Timer timer;
    }
}

