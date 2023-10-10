namespace ClassesImportantes
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
            this.btnMessageBox = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnAleatorio = new System.Windows.Forms.Button();
            this.btnTimeSpan = new System.Windows.Forms.Button();
            this.btnDateTime = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnEnvironment = new System.Windows.Forms.Button();
            this.btnApplication = new System.Windows.Forms.Button();
            this.btnThread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMessageBox
            // 
            this.btnMessageBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMessageBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessageBox.Location = new System.Drawing.Point(405, 334);
            this.btnMessageBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMessageBox.Name = "btnMessageBox";
            this.btnMessageBox.Size = new System.Drawing.Size(188, 64);
            this.btnMessageBox.TabIndex = 0;
            this.btnMessageBox.Text = "MessageBox";
            this.btnMessageBox.UseVisualStyleBackColor = true;
            this.btnMessageBox.Click += new System.EventHandler(this.btnMessageBox_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(24, 33);
            this.lbResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(749, 129);
            this.lbResultado.TabIndex = 1;
            this.lbResultado.Text = "label1";
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAleatorio.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAleatorio.Location = new System.Drawing.Point(209, 334);
            this.btnAleatorio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(188, 64);
            this.btnAleatorio.TabIndex = 2;
            this.btnAleatorio.Text = "Random";
            this.btnAleatorio.UseVisualStyleBackColor = true;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            // 
            // btnTimeSpan
            // 
            this.btnTimeSpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeSpan.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeSpan.Location = new System.Drawing.Point(209, 260);
            this.btnTimeSpan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimeSpan.Name = "btnTimeSpan";
            this.btnTimeSpan.Size = new System.Drawing.Size(188, 64);
            this.btnTimeSpan.TabIndex = 3;
            this.btnTimeSpan.Text = "TimeSpan";
            this.btnTimeSpan.UseVisualStyleBackColor = true;
            this.btnTimeSpan.Click += new System.EventHandler(this.btnTimeSpan_Click);
            // 
            // btnDateTime
            // 
            this.btnDateTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDateTime.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateTime.Location = new System.Drawing.Point(13, 260);
            this.btnDateTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDateTime.Name = "btnDateTime";
            this.btnDateTime.Size = new System.Drawing.Size(188, 64);
            this.btnDateTime.TabIndex = 4;
            this.btnDateTime.Text = "DateTime";
            this.btnDateTime.UseVisualStyleBackColor = true;
            this.btnDateTime.Click += new System.EventHandler(this.btnDateTime_Click);
            // 
            // btnColor
            // 
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Location = new System.Drawing.Point(13, 334);
            this.btnColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(188, 64);
            this.btnColor.TabIndex = 5;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnFont
            // 
            this.btnFont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFont.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFont.Location = new System.Drawing.Point(405, 260);
            this.btnFont.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(188, 64);
            this.btnFont.TabIndex = 6;
            this.btnFont.Text = "Fonte";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnEnvironment
            // 
            this.btnEnvironment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnvironment.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvironment.Location = new System.Drawing.Point(601, 260);
            this.btnEnvironment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnvironment.Name = "btnEnvironment";
            this.btnEnvironment.Size = new System.Drawing.Size(188, 64);
            this.btnEnvironment.TabIndex = 7;
            this.btnEnvironment.Text = "Environment";
            this.btnEnvironment.UseVisualStyleBackColor = true;
            this.btnEnvironment.Click += new System.EventHandler(this.btnEnvironment_Click);
            // 
            // btnApplication
            // 
            this.btnApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplication.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplication.Location = new System.Drawing.Point(601, 334);
            this.btnApplication.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApplication.Name = "btnApplication";
            this.btnApplication.Size = new System.Drawing.Size(188, 64);
            this.btnApplication.TabIndex = 8;
            this.btnApplication.Text = "Application";
            this.btnApplication.UseVisualStyleBackColor = true;
            this.btnApplication.Click += new System.EventHandler(this.btnApplication_Click);
            // 
            // btnThread
            // 
            this.btnThread.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThread.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThread.Location = new System.Drawing.Point(13, 186);
            this.btnThread.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThread.Name = "btnThread";
            this.btnThread.Size = new System.Drawing.Size(188, 64);
            this.btnThread.TabIndex = 9;
            this.btnThread.Text = "Thread";
            this.btnThread.UseVisualStyleBackColor = true;
            this.btnThread.Click += new System.EventHandler(this.btnThread_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 412);
            this.Controls.Add(this.btnThread);
            this.Controls.Add(this.btnApplication);
            this.Controls.Add(this.btnEnvironment);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnDateTime);
            this.Controls.Add(this.btnTimeSpan);
            this.Controls.Add(this.btnAleatorio);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btnMessageBox);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMessageBox;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btnAleatorio;
        private System.Windows.Forms.Button btnTimeSpan;
        private System.Windows.Forms.Button btnDateTime;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnEnvironment;
        private System.Windows.Forms.Button btnApplication;
        private System.Windows.Forms.Button btnThread;
    }
}

