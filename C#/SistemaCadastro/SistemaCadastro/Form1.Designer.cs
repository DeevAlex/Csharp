namespace SistemaCadastro
{
    partial class Formulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtEstadoCivil = new System.Windows.Forms.ComboBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.CheckCasa = new System.Windows.Forms.CheckBox();
            this.CheckVeiculo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Outro = new System.Windows.Forms.RadioButton();
            this.Feminino = new System.Windows.Forms.RadioButton();
            this.Masculino = new System.Windows.Forms.RadioButton();
            this.txtLista = new System.Windows.Forms.ListBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado Civil:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(74, 6);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(387, 26);
            this.txtNome.TabIndex = 4;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataNascimento.Location = new System.Drawing.Point(157, 45);
            this.txtDataNascimento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(304, 26);
            this.txtDataNascimento.TabIndex = 5;
            // 
            // txtEstadoCivil
            // 
            this.txtEstadoCivil.FormattingEnabled = true;
            this.txtEstadoCivil.Location = new System.Drawing.Point(110, 86);
            this.txtEstadoCivil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEstadoCivil.Name = "txtEstadoCivil";
            this.txtEstadoCivil.Size = new System.Drawing.Size(351, 28);
            this.txtEstadoCivil.TabIndex = 6;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(94, 140);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefone.Mask = " (00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(367, 26);
            this.txtTelefone.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Location = new System.Drawing.Point(20, 374);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(161, 30);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar / Alterar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // CheckCasa
            // 
            this.CheckCasa.AutoSize = true;
            this.CheckCasa.Location = new System.Drawing.Point(26, 174);
            this.CheckCasa.Name = "CheckCasa";
            this.CheckCasa.Size = new System.Drawing.Size(157, 24);
            this.CheckCasa.TabIndex = 9;
            this.CheckCasa.Text = "Possuí Casa Propría?";
            this.CheckCasa.UseVisualStyleBackColor = true;
            // 
            // CheckVeiculo
            // 
            this.CheckVeiculo.AutoSize = true;
            this.CheckVeiculo.Location = new System.Drawing.Point(26, 204);
            this.CheckVeiculo.Name = "CheckVeiculo";
            this.CheckVeiculo.Size = new System.Drawing.Size(147, 24);
            this.CheckVeiculo.TabIndex = 10;
            this.CheckVeiculo.Text = "Possuí um Veiculo?";
            this.CheckVeiculo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Outro);
            this.groupBox1.Controls.Add(this.Feminino);
            this.groupBox1.Controls.Add(this.Masculino);
            this.groupBox1.Location = new System.Drawing.Point(20, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 121);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gênero:";
            // 
            // Outro
            // 
            this.Outro.AutoSize = true;
            this.Outro.Location = new System.Drawing.Point(6, 85);
            this.Outro.Name = "Outro";
            this.Outro.Size = new System.Drawing.Size(59, 24);
            this.Outro.TabIndex = 2;
            this.Outro.TabStop = true;
            this.Outro.Text = "Outro";
            this.Outro.UseVisualStyleBackColor = true;
            // 
            // Feminino
            // 
            this.Feminino.AutoSize = true;
            this.Feminino.Location = new System.Drawing.Point(6, 55);
            this.Feminino.Name = "Feminino";
            this.Feminino.Size = new System.Drawing.Size(82, 24);
            this.Feminino.TabIndex = 1;
            this.Feminino.TabStop = true;
            this.Feminino.Text = "Feminino";
            this.Feminino.UseVisualStyleBackColor = true;
            // 
            // Masculino
            // 
            this.Masculino.AutoSize = true;
            this.Masculino.Location = new System.Drawing.Point(6, 25);
            this.Masculino.Name = "Masculino";
            this.Masculino.Size = new System.Drawing.Size(87, 24);
            this.Masculino.TabIndex = 0;
            this.Masculino.TabStop = true;
            this.Masculino.Text = "Masculino";
            this.Masculino.UseVisualStyleBackColor = true;
            // 
            // txtLista
            // 
            this.txtLista.FormattingEnabled = true;
            this.txtLista.ItemHeight = 20;
            this.txtLista.Location = new System.Drawing.Point(20, 412);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(441, 104);
            this.txtLista.TabIndex = 12;
            this.txtLista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtLista_MouseDoubleClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Location = new System.Drawing.Point(187, 374);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(113, 30);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(306, 374);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(156, 30);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 538);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CheckVeiculo);
            this.Controls.Add(this.CheckCasa);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEstadoCivil);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Cadastro";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker txtDataNascimento;
        private System.Windows.Forms.ComboBox txtEstadoCivil;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.CheckBox CheckCasa;
        private System.Windows.Forms.CheckBox CheckVeiculo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Feminino;
        private System.Windows.Forms.RadioButton Masculino;
        private System.Windows.Forms.RadioButton Outro;
        private System.Windows.Forms.ListBox txtLista;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
    }
}

