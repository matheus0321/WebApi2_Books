namespace WebApi2_Books
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
            this.btnObter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtURI = new System.Windows.Forms.TextBox();
            this.gdvDados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObter
            // 
            this.btnObter.Location = new System.Drawing.Point(12, 290);
            this.btnObter.Name = "btnObter";
            this.btnObter.Size = new System.Drawing.Size(75, 23);
            this.btnObter.TabIndex = 0;
            this.btnObter.Text = "Obter Api";
            this.btnObter.UseVisualStyleBackColor = true;
            this.btnObter.Click += new System.EventHandler(this.btnObter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URI- WebApi";
            // 
            // txtURI
            // 
            this.txtURI.Location = new System.Drawing.Point(88, 15);
            this.txtURI.Name = "txtURI";
            this.txtURI.Size = new System.Drawing.Size(395, 20);
            this.txtURI.TabIndex = 2;
            // 
            // gdvDados
            // 
            this.gdvDados.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gdvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvDados.Location = new System.Drawing.Point(12, 39);
            this.gdvDados.Name = "gdvDados";
            this.gdvDados.Size = new System.Drawing.Size(471, 245);
            this.gdvDados.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(488, 322);
            this.Controls.Add(this.gdvDados);
            this.Controls.Add(this.txtURI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObter);
            this.Name = "Form1";
            this.Text = "Web Api Books";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURI;
        private System.Windows.Forms.DataGridView gdvDados;
    }
}

