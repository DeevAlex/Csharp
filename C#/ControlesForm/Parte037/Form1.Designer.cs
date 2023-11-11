namespace Parte037
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
            this.printPreview = new System.Windows.Forms.PrintPreviewControl();
            this.txtPrint = new System.Windows.Forms.RichTextBox();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // printPreview
            // 
            this.printPreview.AutoZoom = false;
            this.printPreview.Document = this.printDoc;
            this.printPreview.Location = new System.Drawing.Point(356, 12);
            this.printPreview.Name = "printPreview";
            this.printPreview.Size = new System.Drawing.Size(304, 284);
            this.printPreview.TabIndex = 0;
            this.printPreview.Zoom = 0.25D;
            // 
            // txtPrint
            // 
            this.txtPrint.Location = new System.Drawing.Point(12, 12);
            this.txtPrint.Name = "txtPrint";
            this.txtPrint.Size = new System.Drawing.Size(338, 284);
            this.txtPrint.TabIndex = 1;
            this.txtPrint.Text = "";
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(386, 302);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(140, 40);
            this.btnVisualizar.TabIndex = 2;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(532, 302);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(128, 40);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 354);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.txtPrint);
            this.Controls.Add(this.printPreview);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintPreviewControl printPreview;
        private System.Windows.Forms.RichTextBox txtPrint;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Drawing.Printing.PrintDocument printDoc;
    }
}

