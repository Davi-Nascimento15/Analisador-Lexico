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
            this.Rich_Text_Lexema = new System.Windows.Forms.RichTextBox();
            this.Rick_Text_Tokens = new System.Windows.Forms.RichTextBox();
            this.Rick_Text_Simbolos = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_InserirCodigo
            // 
            this.txt_InserirCodigo.Location = new System.Drawing.Point(342, 25);
            this.txt_InserirCodigo.Name = "txt_InserirCodigo";
            this.txt_InserirCodigo.Size = new System.Drawing.Size(97, 63);
            this.txt_InserirCodigo.TabIndex = 0;
            this.txt_InserirCodigo.Text = "Inserir Código";
            this.txt_InserirCodigo.UseVisualStyleBackColor = true;
            this.txt_InserirCodigo.Click += new System.EventHandler(this.txt_InserirCodigo_Click);
            // 
            // txt_LerCodigo
            // 
            this.txt_LerCodigo.Location = new System.Drawing.Point(29, 35);
            this.txt_LerCodigo.Name = "txt_LerCodigo";
            this.txt_LerCodigo.Size = new System.Drawing.Size(92, 53);
            this.txt_LerCodigo.TabIndex = 1;
            this.txt_LerCodigo.Text = "Ler Código";
            this.txt_LerCodigo.UseVisualStyleBackColor = true;
            this.txt_LerCodigo.Click += new System.EventHandler(this.txt_LerCodigo_Click);
            // 
            // R_text
            // 
            this.R_text.Location = new System.Drawing.Point(492, 35);
            this.R_text.Name = "R_text";
            this.R_text.Size = new System.Drawing.Size(296, 364);
            this.R_text.TabIndex = 2;
            this.R_text.Text = "";
            // 
            // Rich_Text_Lexema
            // 
            this.Rich_Text_Lexema.Location = new System.Drawing.Point(29, 250);
            this.Rich_Text_Lexema.Name = "Rich_Text_Lexema";
            this.Rich_Text_Lexema.Size = new System.Drawing.Size(143, 149);
            this.Rich_Text_Lexema.TabIndex = 3;
            this.Rich_Text_Lexema.Text = "";
            // 
            // Rick_Text_Tokens
            // 
            this.Rick_Text_Tokens.Location = new System.Drawing.Point(176, 250);
            this.Rick_Text_Tokens.Name = "Rick_Text_Tokens";
            this.Rick_Text_Tokens.Size = new System.Drawing.Size(143, 149);
            this.Rick_Text_Tokens.TabIndex = 4;
            this.Rick_Text_Tokens.Text = "";
            // 
            // Rick_Text_Simbolos
            // 
            this.Rick_Text_Simbolos.Location = new System.Drawing.Point(325, 250);
            this.Rick_Text_Simbolos.Name = "Rick_Text_Simbolos";
            this.Rick_Text_Simbolos.Size = new System.Drawing.Size(143, 149);
            this.Rick_Text_Simbolos.TabIndex = 5;
            this.Rick_Text_Simbolos.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lexema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tokens";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tabela de Simbolos";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rick_Text_Simbolos);
            this.Controls.Add(this.Rick_Text_Tokens);
            this.Controls.Add(this.Rich_Text_Lexema);
            this.Controls.Add(this.R_text);
            this.Controls.Add(this.txt_LerCodigo);
            this.Controls.Add(this.txt_InserirCodigo);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button txt_InserirCodigo;
        private Button txt_LerCodigo;
        private RichTextBox R_text;
        private RichTextBox Rich_Text_Lexema;
        private RichTextBox Rick_Text_Tokens;
        private RichTextBox Rick_Text_Simbolos;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}