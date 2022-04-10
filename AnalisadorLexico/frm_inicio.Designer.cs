namespace AnalisadorLexico
{
    partial class frm_inicio
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
            this.abrir_arquivo = new System.Windows.Forms.OpenFileDialog();
            this.cmd_LimparDados = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_InserirCodigo
            // 
            this.txt_InserirCodigo.BackColor = System.Drawing.Color.Green;
            this.txt_InserirCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txt_InserirCodigo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_InserirCodigo.Location = new System.Drawing.Point(205, 131);
            this.txt_InserirCodigo.Name = "txt_InserirCodigo";
            this.txt_InserirCodigo.Size = new System.Drawing.Size(92, 53);
            this.txt_InserirCodigo.TabIndex = 0;
            this.txt_InserirCodigo.Text = "Inserir Código";
            this.txt_InserirCodigo.UseVisualStyleBackColor = false;
            this.txt_InserirCodigo.Click += new System.EventHandler(this.txt_InserirCodigo_Click);
            // 
            // txt_LerCodigo
            // 
            this.txt_LerCodigo.BackColor = System.Drawing.Color.Yellow;
            this.txt_LerCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txt_LerCodigo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_LerCodigo.Location = new System.Drawing.Point(60, 131);
            this.txt_LerCodigo.Name = "txt_LerCodigo";
            this.txt_LerCodigo.Size = new System.Drawing.Size(92, 53);
            this.txt_LerCodigo.TabIndex = 1;
            this.txt_LerCodigo.Text = "Ler Código";
            this.txt_LerCodigo.UseVisualStyleBackColor = false;
            this.txt_LerCodigo.Click += new System.EventHandler(this.txt_LerCodigo_Click);
            // 
            // R_text
            // 
            this.R_text.Enabled = false;
            this.R_text.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.R_text.Location = new System.Drawing.Point(518, 35);
            this.R_text.Name = "R_text";
            this.R_text.Size = new System.Drawing.Size(270, 364);
            this.R_text.TabIndex = 2;
            this.R_text.Text = "";
            this.R_text.Visible = false;
            // 
            // Rich_Text_Lexema
            // 
            this.Rich_Text_Lexema.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rich_Text_Lexema.Location = new System.Drawing.Point(29, 250);
            this.Rich_Text_Lexema.Name = "Rich_Text_Lexema";
            this.Rich_Text_Lexema.ReadOnly = true;
            this.Rich_Text_Lexema.Size = new System.Drawing.Size(123, 149);
            this.Rich_Text_Lexema.TabIndex = 3;
            this.Rich_Text_Lexema.Text = "";
            // 
            // Rick_Text_Tokens
            // 
            this.Rick_Text_Tokens.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rick_Text_Tokens.Location = new System.Drawing.Point(158, 250);
            this.Rick_Text_Tokens.Name = "Rick_Text_Tokens";
            this.Rick_Text_Tokens.ReadOnly = true;
            this.Rick_Text_Tokens.Size = new System.Drawing.Size(177, 149);
            this.Rick_Text_Tokens.TabIndex = 4;
            this.Rick_Text_Tokens.Text = "";
            // 
            // Rick_Text_Simbolos
            // 
            this.Rick_Text_Simbolos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rick_Text_Simbolos.Location = new System.Drawing.Point(341, 250);
            this.Rick_Text_Simbolos.Name = "Rick_Text_Simbolos";
            this.Rick_Text_Simbolos.ReadOnly = true;
            this.Rick_Text_Simbolos.Size = new System.Drawing.Size(152, 149);
            this.Rick_Text_Simbolos.TabIndex = 5;
            this.Rick_Text_Simbolos.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lexema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(216, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tokens";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(341, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tabela de Simbolos";
            // 
            // abrir_arquivo
            // 
            this.abrir_arquivo.FileName = "openFileDialog1";
            // 
            // cmd_LimparDados
            // 
            this.cmd_LimparDados.BackColor = System.Drawing.Color.Red;
            this.cmd_LimparDados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmd_LimparDados.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmd_LimparDados.ForeColor = System.Drawing.SystemColors.Control;
            this.cmd_LimparDados.Location = new System.Drawing.Point(341, 131);
            this.cmd_LimparDados.Name = "cmd_LimparDados";
            this.cmd_LimparDados.Size = new System.Drawing.Size(92, 53);
            this.cmd_LimparDados.TabIndex = 9;
            this.cmd_LimparDados.Text = "Limpar Dados";
            this.cmd_LimparDados.UseVisualStyleBackColor = false;
            this.cmd_LimparDados.Click += new System.EventHandler(this.cmd_LimparDados_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(124, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Projeto Compiladores";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmd_LimparDados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rick_Text_Simbolos);
            this.Controls.Add(this.Rick_Text_Tokens);
            this.Controls.Add(this.Rich_Text_Lexema);
            this.Controls.Add(this.R_text);
            this.Controls.Add(this.txt_LerCodigo);
            this.Controls.Add(this.txt_InserirCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compilador - Trabalho de Compiladores -1º Bimestre";
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
        private OpenFileDialog abrir_arquivo;
        private Button cmd_LimparDados;
        private Label label4;
    }
}