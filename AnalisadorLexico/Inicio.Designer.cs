namespace AnalisadorLexico
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_InserirCodigo = new System.Windows.Forms.Button();
            this.txt_LerCodigo = new System.Windows.Forms.Button();
            this.R_text = new System.Windows.Forms.RichTextBox();
            this.R_Text1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txt_InserirCodigo
            // 
            this.txt_InserirCodigo.Location = new System.Drawing.Point(51, 107);
            this.txt_InserirCodigo.Name = "txt_InserirCodigo";
            this.txt_InserirCodigo.Size = new System.Drawing.Size(97, 63);
            this.txt_InserirCodigo.TabIndex = 0;
            this.txt_InserirCodigo.Text = "Inserir Código";
            this.txt_InserirCodigo.UseVisualStyleBackColor = true;
            this.txt_InserirCodigo.Click += new System.EventHandler(this.txt_InserirCodigo_Click);
            // 
            // txt_LerCodigo
            // 
            this.txt_LerCodigo.Location = new System.Drawing.Point(51, 207);
            this.txt_LerCodigo.Name = "txt_LerCodigo";
            this.txt_LerCodigo.Size = new System.Drawing.Size(92, 53);
            this.txt_LerCodigo.TabIndex = 1;
            this.txt_LerCodigo.Text = "Ler Código";
            this.txt_LerCodigo.UseVisualStyleBackColor = true;
            this.txt_LerCodigo.Click += new System.EventHandler(this.txt_LerCodigo_Click);
            // 
            // R_text
            // 
            this.R_text.Location = new System.Drawing.Point(475, 25);
            this.R_text.Name = "R_text";
            this.R_text.Size = new System.Drawing.Size(296, 364);
            this.R_text.TabIndex = 2;
            this.R_text.Text = "";
            // 
            // R_Text1
            // 
            this.R_Text1.Location = new System.Drawing.Point(148, 276);
            this.R_Text1.Name = "R_Text1";
            this.R_Text1.Size = new System.Drawing.Size(218, 149);
            this.R_Text1.TabIndex = 3;
            this.R_Text1.Text = "";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.R_Text1);
            this.Controls.Add(this.R_text);
            this.Controls.Add(this.txt_LerCodigo);
            this.Controls.Add(this.txt_InserirCodigo);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private Button txt_InserirCodigo;
        private Button txt_LerCodigo;
        private RichTextBox R_text;
        private RichTextBox R_Text1;
    }
}