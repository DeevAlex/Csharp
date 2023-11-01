namespace Formulario
{
    partial class FormMain
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
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.btnSegunda = new System.Windows.Forms.Button();
            this.btnSegundaThread = new System.Windows.Forms.Button();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpSobreDev = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpSobreVersao = new System.Windows.Forms.ToolStripMenuItem();
            this.comboMenu = new System.Windows.Forms.ToolStripComboBox();
            this.mPesquisar = new System.Windows.Forms.ToolStripTextBox();
            this.mFileNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.Location = new System.Drawing.Point(12, 101);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(757, 151);
            this.lblPrincipal.TabIndex = 0;
            this.lblPrincipal.Text = "Principal";
            this.lblPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSegunda
            // 
            this.btnSegunda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSegunda.Location = new System.Drawing.Point(12, 378);
            this.btnSegunda.Name = "btnSegunda";
            this.btnSegunda.Size = new System.Drawing.Size(169, 59);
            this.btnSegunda.TabIndex = 1;
            this.btnSegunda.Text = "Segunda Form";
            this.btnSegunda.UseVisualStyleBackColor = true;
            this.btnSegunda.Click += new System.EventHandler(this.btnSegunda_Click);
            // 
            // btnSegundaThread
            // 
            this.btnSegundaThread.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSegundaThread.Location = new System.Drawing.Point(191, 378);
            this.btnSegundaThread.Name = "btnSegundaThread";
            this.btnSegundaThread.Size = new System.Drawing.Size(238, 59);
            this.btnSegundaThread.TabIndex = 2;
            this.btnSegundaThread.Text = "Segunda Form Thread";
            this.btnSegundaThread.UseVisualStyleBackColor = true;
            this.btnSegundaThread.Click += new System.EventHandler(this.btnSegundaThread_Click);
            // 
            // menuBar
            // 
            this.menuBar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp,
            this.comboMenu,
            this.mPesquisar});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(781, 27);
            this.menuBar.TabIndex = 3;
            this.menuBar.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileNovo,
            this.mFileAbrir,
            this.toolStripSeparator1,
            this.mFileSair});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(46, 23);
            this.menuFile.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHelpSobre});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(53, 23);
            this.menuHelp.Text = "Help";
            // 
            // mHelpSobre
            // 
            this.mHelpSobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHelpSobreDev,
            this.mHelpSobreVersao});
            this.mHelpSobre.Name = "mHelpSobre";
            this.mHelpSobre.Size = new System.Drawing.Size(119, 22);
            this.mHelpSobre.Text = "Sobre";
            // 
            // mHelpSobreDev
            // 
            this.mHelpSobreDev.Name = "mHelpSobreDev";
            this.mHelpSobreDev.Size = new System.Drawing.Size(186, 22);
            this.mHelpSobreDev.Text = "Desenvolvedor";
            this.mHelpSobreDev.Click += new System.EventHandler(this.mHelpSobreDev_Click);
            // 
            // mHelpSobreVersao
            // 
            this.mHelpSobreVersao.Name = "mHelpSobreVersao";
            this.mHelpSobreVersao.Size = new System.Drawing.Size(186, 22);
            this.mHelpSobreVersao.Text = "Versão";
            this.mHelpSobreVersao.Click += new System.EventHandler(this.mHelpSobreVersao_Click);
            // 
            // comboMenu
            // 
            this.comboMenu.Items.AddRange(new object[] {
            "Inglês",
            "Português"});
            this.comboMenu.Name = "comboMenu";
            this.comboMenu.Size = new System.Drawing.Size(121, 23);
            this.comboMenu.SelectedIndexChanged += new System.EventHandler(this.comboMenu_SelectedIndexChanged);
            // 
            // mPesquisar
            // 
            this.mPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mPesquisar.Name = "mPesquisar";
            this.mPesquisar.Size = new System.Drawing.Size(100, 23);
            this.mPesquisar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mPesquisar_KeyUp);
            // 
            // mFileNovo
            // 
            this.mFileNovo.Image = global::Formulario.Properties.Resources.Iconsmind_Outline_File;
            this.mFileNovo.Name = "mFileNovo";
            this.mFileNovo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mFileNovo.Size = new System.Drawing.Size(180, 22);
            this.mFileNovo.Text = "Novo";
            this.mFileNovo.Click += new System.EventHandler(this.mFileNovo_Click);
            // 
            // mFileAbrir
            // 
            this.mFileAbrir.Image = global::Formulario.Properties.Resources.Hopstarter_Soft_Scraps_My_Documents;
            this.mFileAbrir.Name = "mFileAbrir";
            this.mFileAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mFileAbrir.Size = new System.Drawing.Size(180, 22);
            this.mFileAbrir.Text = "Abrir";
            this.mFileAbrir.Click += new System.EventHandler(this.mFileAbrir_Click);
            // 
            // mFileSair
            // 
            this.mFileSair.Image = global::Formulario.Properties.Resources.Custom_Icon_Design_Pretty_Office_6_Logout_24;
            this.mFileSair.Name = "mFileSair";
            this.mFileSair.Size = new System.Drawing.Size(180, 22);
            this.mFileSair.Text = "Sair";
            this.mFileSair.Click += new System.EventHandler(this.mFileSair_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 449);
            this.Controls.Add(this.btnSegundaThread);
            this.Controls.Add(this.btnSegunda);
            this.Controls.Add(this.lblPrincipal);
            this.Controls.Add(this.menuBar);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuBar;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Button btnSegunda;
        private System.Windows.Forms.Button btnSegundaThread;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem mFileNovo;
        private System.Windows.Forms.ToolStripMenuItem mFileAbrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mFileSair;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem mHelpSobre;
        private System.Windows.Forms.ToolStripMenuItem mHelpSobreDev;
        private System.Windows.Forms.ToolStripMenuItem mHelpSobreVersao;
        private System.Windows.Forms.ToolStripComboBox comboMenu;
        private System.Windows.Forms.ToolStripTextBox mPesquisar;
    }
}

