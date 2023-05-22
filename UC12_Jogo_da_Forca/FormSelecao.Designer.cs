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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_DEFINIR = new System.Windows.Forms.TextBox();
            this.button_ENVIAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite uma Palavra para começar! (Maximo 10 letras!)";
            // 
            // textBox_DEFINIR
            // 
            this.textBox_DEFINIR.Location = new System.Drawing.Point(15, 89);
            this.textBox_DEFINIR.Name = "textBox_DEFINIR";
            this.textBox_DEFINIR.Size = new System.Drawing.Size(307, 20);
            this.textBox_DEFINIR.TabIndex = 4;
            // 
            // button_ENVIAR
            // 
            this.button_ENVIAR.Location = new System.Drawing.Point(128, 115);
            this.button_ENVIAR.Name = "button_ENVIAR";
            this.button_ENVIAR.Size = new System.Drawing.Size(75, 23);
            this.button_ENVIAR.TabIndex = 5;
            this.button_ENVIAR.Text = "Começar";
            this.button_ENVIAR.UseVisualStyleBackColor = true;
            this.button_ENVIAR.Click += new System.EventHandler(this.button_ENVIAR_Click);
            // 
            // FormSelecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 213);
            this.Controls.Add(this.button_ENVIAR);
            this.Controls.Add(this.textBox_DEFINIR);
            this.Controls.Add(this.label1);
            this.Name = "FormSelecao";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_DEFINIR;
        private System.Windows.Forms.Button button_ENVIAR;
    }
}

