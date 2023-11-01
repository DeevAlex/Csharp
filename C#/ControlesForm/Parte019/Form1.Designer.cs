namespace Parte019
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Filho1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Neto1");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Filho2", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Filho3");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Principal", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Segundo");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "nFilho1";
            treeNode1.Text = "Filho1";
            treeNode2.Name = "nNeto";
            treeNode2.Text = "Neto1";
            treeNode3.Name = "nFilho2";
            treeNode3.Text = "Filho2";
            treeNode4.Name = "nFilho3";
            treeNode4.Text = "Filho3";
            treeNode5.Name = "nPrincipal";
            treeNode5.Text = "Principal";
            treeNode6.Name = "nSegundo";
            treeNode6.Text = "Segundo";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(452, 373);
            this.treeView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 373);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}

