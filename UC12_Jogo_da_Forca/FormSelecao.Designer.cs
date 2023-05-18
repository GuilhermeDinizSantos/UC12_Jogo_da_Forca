namespace UC12_Jogo_da_Forca
{
    partial class FormSelecao
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
            this.buttonEGO = new System.Windows.Forms.Button();
            this.buttonFRENTE = new System.Windows.Forms.Button();
            this.buttonJOGO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEGO
            // 
            this.buttonEGO.Location = new System.Drawing.Point(13, 119);
            this.buttonEGO.Name = "buttonEGO";
            this.buttonEGO.Size = new System.Drawing.Size(257, 23);
            this.buttonEGO.TabIndex = 0;
            this.buttonEGO.Text = "Ego";
            this.buttonEGO.UseVisualStyleBackColor = true;
            this.buttonEGO.Click += new System.EventHandler(this.buttonEGO_Click);
            // 
            // buttonFRENTE
            // 
            this.buttonFRENTE.Location = new System.Drawing.Point(13, 149);
            this.buttonFRENTE.Name = "buttonFRENTE";
            this.buttonFRENTE.Size = new System.Drawing.Size(257, 23);
            this.buttonFRENTE.TabIndex = 1;
            this.buttonFRENTE.Text = "Frente";
            this.buttonFRENTE.UseVisualStyleBackColor = true;
            this.buttonFRENTE.Click += new System.EventHandler(this.buttonFRENTE_Click);
            // 
            // buttonJOGO
            // 
            this.buttonJOGO.Location = new System.Drawing.Point(13, 179);
            this.buttonJOGO.Name = "buttonJOGO";
            this.buttonJOGO.Size = new System.Drawing.Size(257, 23);
            this.buttonJOGO.TabIndex = 2;
            this.buttonJOGO.Text = "Jogo";
            this.buttonJOGO.UseVisualStyleBackColor = true;
            this.buttonJOGO.Click += new System.EventHandler(this.buttonJOGO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecione uma das palavras para começar!";
            // 
            // FormSelecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 213);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonJOGO);
            this.Controls.Add(this.buttonFRENTE);
            this.Controls.Add(this.buttonEGO);
            this.Name = "FormSelecao";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEGO;
        private System.Windows.Forms.Button buttonFRENTE;
        private System.Windows.Forms.Button buttonJOGO;
        private System.Windows.Forms.Label label1;
    }
}

