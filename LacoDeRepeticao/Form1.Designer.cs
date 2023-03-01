namespace LacoDeRepeticao
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
            this.listFor = new System.Windows.Forms.ListBox();
            this.buttonexecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listFor
            // 
            this.listFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFor.FormattingEnabled = true;
            this.listFor.ItemHeight = 16;
            this.listFor.Location = new System.Drawing.Point(12, 12);
            this.listFor.Name = "listFor";
            this.listFor.Size = new System.Drawing.Size(257, 420);
            this.listFor.TabIndex = 0;
            // 
            // buttonexecutar
            // 
            this.buttonexecutar.Location = new System.Drawing.Point(275, 209);
            this.buttonexecutar.Name = "buttonexecutar";
            this.buttonexecutar.Size = new System.Drawing.Size(125, 41);
            this.buttonexecutar.TabIndex = 1;
            this.buttonexecutar.Text = "Clique Aqui";
            this.buttonexecutar.UseVisualStyleBackColor = true;
            this.buttonexecutar.Click += new System.EventHandler(this.buttonexecutar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 454);
            this.Controls.Add(this.buttonexecutar);
            this.Controls.Add(this.listFor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listFor;
        private System.Windows.Forms.Button buttonexecutar;
    }
}

