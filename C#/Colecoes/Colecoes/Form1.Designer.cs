namespace Colecoes
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
            this.btnList = new System.Windows.Forms.Button();
            this.btnHashSet = new System.Windows.Forms.Button();
            this.btnDictionary = new System.Windows.Forms.Button();
            this.btnSortedList = new System.Windows.Forms.Button();
            this.btnSortedDictionary = new System.Windows.Forms.Button();
            this.btnSortedSet = new System.Windows.Forms.Button();
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnStack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 23;
            this.lista.Location = new System.Drawing.Point(12, 12);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(429, 326);
            this.lista.TabIndex = 0;
            // 
            // btnList
            // 
            this.btnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnList.Location = new System.Drawing.Point(447, 12);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(239, 35);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnHashSet
            // 
            this.btnHashSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHashSet.Location = new System.Drawing.Point(447, 53);
            this.btnHashSet.Name = "btnHashSet";
            this.btnHashSet.Size = new System.Drawing.Size(239, 35);
            this.btnHashSet.TabIndex = 2;
            this.btnHashSet.Text = "HashSet";
            this.btnHashSet.UseVisualStyleBackColor = true;
            this.btnHashSet.Click += new System.EventHandler(this.btnHashSet_Click);
            // 
            // btnDictionary
            // 
            this.btnDictionary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDictionary.Location = new System.Drawing.Point(447, 94);
            this.btnDictionary.Name = "btnDictionary";
            this.btnDictionary.Size = new System.Drawing.Size(239, 35);
            this.btnDictionary.TabIndex = 3;
            this.btnDictionary.Text = "Dictionary";
            this.btnDictionary.UseVisualStyleBackColor = true;
            this.btnDictionary.Click += new System.EventHandler(this.btnDictionary_Click);
            // 
            // btnSortedList
            // 
            this.btnSortedList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortedList.Location = new System.Drawing.Point(447, 135);
            this.btnSortedList.Name = "btnSortedList";
            this.btnSortedList.Size = new System.Drawing.Size(239, 35);
            this.btnSortedList.TabIndex = 4;
            this.btnSortedList.Text = "SortedList";
            this.btnSortedList.UseVisualStyleBackColor = true;
            this.btnSortedList.Click += new System.EventHandler(this.btnSortedList_Click);
            // 
            // btnSortedDictionary
            // 
            this.btnSortedDictionary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortedDictionary.Location = new System.Drawing.Point(447, 176);
            this.btnSortedDictionary.Name = "btnSortedDictionary";
            this.btnSortedDictionary.Size = new System.Drawing.Size(239, 35);
            this.btnSortedDictionary.TabIndex = 5;
            this.btnSortedDictionary.Text = "SortedDictionary";
            this.btnSortedDictionary.UseVisualStyleBackColor = true;
            this.btnSortedDictionary.Click += new System.EventHandler(this.btnSortedDictionary_Click);
            // 
            // btnSortedSet
            // 
            this.btnSortedSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortedSet.Location = new System.Drawing.Point(447, 217);
            this.btnSortedSet.Name = "btnSortedSet";
            this.btnSortedSet.Size = new System.Drawing.Size(239, 35);
            this.btnSortedSet.TabIndex = 6;
            this.btnSortedSet.Text = "SortedSet";
            this.btnSortedSet.UseVisualStyleBackColor = true;
            this.btnSortedSet.Click += new System.EventHandler(this.btnSortedSet_Click);
            // 
            // btnQueue
            // 
            this.btnQueue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQueue.Location = new System.Drawing.Point(447, 258);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(239, 35);
            this.btnQueue.TabIndex = 7;
            this.btnQueue.Text = "Queue";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // btnStack
            // 
            this.btnStack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStack.Location = new System.Drawing.Point(447, 299);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(239, 35);
            this.btnStack.TabIndex = 8;
            this.btnStack.Text = "Stack";
            this.btnStack.UseVisualStyleBackColor = true;
            this.btnStack.Click += new System.EventHandler(this.btnStack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 339);
            this.Controls.Add(this.btnStack);
            this.Controls.Add(this.btnQueue);
            this.Controls.Add(this.btnSortedSet);
            this.Controls.Add(this.btnSortedDictionary);
            this.Controls.Add(this.btnSortedList);
            this.Controls.Add(this.btnDictionary);
            this.Controls.Add(this.btnHashSet);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.lista);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listas Genericas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnHashSet;
        private System.Windows.Forms.Button btnDictionary;
        private System.Windows.Forms.Button btnSortedList;
        private System.Windows.Forms.Button btnSortedDictionary;
        private System.Windows.Forms.Button btnSortedSet;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Button btnStack;
    }
}

