namespace AnalisadorLexico
{
    public partial class frm_inicio : Form
    {
        char[] simbolos = { '(', ')', '{', '}', ',', ';', '[', ']' };
        string[] keys = { "main", "void", "int", "while", "for", "then", "if", "else", "float", "double", "string", "char", "boolean", "bool", "break", "switch", "case", "do" };
        char[] caractere = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '_', '.' };
        string[] operador = { ">", "<", "=", "==", "!=", ">=", "<=", "&&", "||", "%" };
        string[] sinais = { "+", "-", "*", "/" };
        char[] numero = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        string codigo = "";///Recebe todo o código lido
        bool[] tipoEntrada = { false, false, false, false, false, false }; // 0 - caractere, 1-numero, 2-simbolo,3-operador,4-sinais e 5-Quebra de Linha      
        List<Token> tokens = new List<Token>();
        List<Tabela> tabelaSimbolos = new List<Tabela>();

        string lexema = "";//Armazena o padrão lido até o momento " " ou troca de padrão
        bool espaco = false;
        int ContadorSimbolos = 0;//Armazena quantidade de itens na tabela de simbolos
        int Estado = 0;
        public frm_inicio()
        {
            frm_inicializacao Intro= new frm_inicializacao();
            Intro.ShowDialog();
            InitializeComponent();
            estado_form();
        }
        bool Simbolo(char c)
        {
            foreach (char ch in simbolos)
            {
                if (ch == c)
                {
                    return true;
                }
            }
            return false;
        }
        bool Operador(char c)
        {
            foreach (string ch in operador)
            {
                if (ch == c.ToString())
                {
                    return true;
                }
            }
            return false;
        }
        bool Sinais(char c)
        {
            foreach (string ch in sinais)
            {
                if (ch == c.ToString())
                {
                    return true;
                }
            }
            return false;
        }
        bool Keys(string s)
        {
            foreach (string ch in keys)
            {
                if (ch == s.ToString())
                {
                    return true;
                }
            }
            return false;
        }
        bool Caractere(char c)
        {
            foreach (char ch in caractere)
            {
                if (ch == c)
                {
                    return true;
                }
            }
            return false;
        }
        bool Numero(char c)
        {
            foreach (char ch in numero)
            {
                if (ch == c)
                {
                    return true;
                }
            }
            return false;
        }
        void VerificaPadrao(int i)//Verifica o padrão de entrada até o momento
        {
            if (espaco == true)/// Trata entrada de espaços em branco
            {
                espaco = false;
                GeraToken(i);
                tipoEntrada[i] = false;
            }
            else if (tipoEntrada[2] && i == 2)///// Armazena delimitadores sequenciais de forma correta
            {
                GeraToken(2);
            }
            else if ((tipoEntrada[3] && i == 3 || tipoEntrada[4] && i == 4) && lexema.Length == 2)//Verifica sinais e funçoes matematicas a mais que 2 
            {
                GeraToken(i);
            }
            else if (tipoEntrada[i] != true)
            {
                for (int j = 0; j < 5; j++)/// verifica entrada lida anteriormente, quando a atual mudar
                {
                    if (tipoEntrada[j] && lexema != "")
                    {
                        GeraToken(j);
                        tipoEntrada[j] = false;
                    }
                }
                tipoEntrada[i] = true;
            }
            else
            {
                for (int j = 0; j < 5; j++)///seta todos as posiçoes a false, menos a atual
                {
                    if (j != i)
                    {
                        tipoEntrada[j] = false;
                    }
                }
            }
        }
        void GeraToken(int i)// Verifica e armazena o token
        {
            Token auxToken = new Token();
            Tabela auxTabela;
            switch (i)
            {
                case 0:
                    if (Keys(lexema))
                    {
                        auxToken.AtributoSet = "Key";
                        auxToken.ValorSet = lexema;
                        lexema = "";
                    }
                    else
                    {
                        int c = 0;
                        if (tabelaSimbolos.Count > 0)//Confirma se não há dados na tabela de simbolos
                        {
                            foreach (Tabela item in tabelaSimbolos)
                            {
                                if (item.TokenGet.ValorGet == lexema)/// Se na tabela haver um objeto com o mesmo nome do lexima
                                {
                                    auxToken.ValorSet = item.posicaoGet.ToString();// Guarda a posição do objeto existente na tabela de simbolos
                                    auxToken.AtributoSet = "Id";
                                    c++;
                                }
                            }
                        }
                        if (c == 0 && lexema != "")
                        {
                            ContadorSimbolos++;// incrementa o contador da tabela de simbolos
                            auxToken.AtributoSet = "Id";
                            auxToken.ValorSet = ContadorSimbolos.ToString();// Atribui a posição ao token a ser armazenado
                            auxTabela = new Tabela(ContadorSimbolos, (new Token("Id", lexema)));// Guarda a posição e o objeto com o valor do lexema
                            tabelaSimbolos.Add(auxTabela);// guarda na tabela de simbolos
                        }
                        lexema = "";
                    }
                    break;
                case 1:
                    auxToken.AtributoSet = "Number";
                    auxToken.ValorSet = lexema;
                    lexema = "";
                    break;
                case 2:
                    auxToken.AtributoSet = "Delop";
                    auxToken.ValorSet = lexema;
                    lexema = "";
                    break;
                case 3:
                    auxToken.AtributoSet = "Relop";
                    auxToken.ValorSet = lexema;
                    lexema = "";
                    break;
                case 4:
                    auxToken.AtributoSet = "Matop";
                    auxToken.ValorSet = lexema;
                    lexema = "";
                    break;
            }
            tokens.Add(auxToken);
        }
        void Retirar_Espacos()///Retira os espaços em excesso.
        {
            string esp = " ";
            for (int i = 2; i < 30; i++)
            {
                esp += " ";
                codigo = codigo.Replace(esp, "");
            }
        }
        void PreencherDados()
        {
            foreach (Token item in tokens)//Traz o lexema
            {
                Rich_Text_Lexema.Text += item.ValorGet + "\n";
            }
            foreach (Token item in tokens)//Traz o token
            {
                if (item.AtributoGet == "Key")
                    Rick_Text_Tokens.Text += "< " + item.ValorGet + " >" + "\n";
                else
                    Rick_Text_Tokens.Text += "< " + item.AtributoGet + " , " + item.ValorGet + " >" + "\n";
            }
            foreach (Tabela item in tabelaSimbolos)//Traz o token
            {
                Rick_Text_Simbolos.Text += item.posicaoGet + " , " + item.TokenGet.ValorGet + "\n";
            }
        }
        void Executa()
        {
            for (int i = 0; i < codigo.Length; i++)
            {
                if (codigo[i] != ' ')//Se espaço em branco
                {
                    if (Caractere(codigo[i]))//Verifico se o padrão corresponde ao caractere
                    {
                        VerificaPadrao(0);
                        lexema += codigo[i];//Se sim armazena a posição lida

                    }
                    else if (Numero(codigo[i]))//Verifico se o padrão corresponde ao número
                    {
                        VerificaPadrao(1);
                        lexema += codigo[i];//Se sim armazena a posição lida

                    }
                    else if (Simbolo(codigo[i]))//Verifico se o padrão corresponde ao simbolo
                    {
                        VerificaPadrao(2);
                        lexema += codigo[i];//Se sim armazena a posição lida

                    }
                    else if (Operador(codigo[i]))//Verifico se o padrão corresponde ao Função Matemática
                    {
                        VerificaPadrao(3);
                        lexema += codigo[i];//Se sim armazena a posição lida

                    }
                    else if (Sinais(codigo[i]))//Verifico se o padrão corresponde ao Sinal Matematico
                    {
                        VerificaPadrao(4);
                        lexema += codigo[i];//Se sim armazena a posição lida

                    }
                }
                else
                {
                    espaco = true;//Trata os espaços em branco.
                    if (lexema != "")
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (tipoEntrada[j])//Identifica o padrão de entrada lido
                            {
                                VerificaPadrao(j);
                            }
                        }
                    }
                }
            }
            PreencherDados();///Preenche os formulários.
        }
        void estado_form()
        {
            switch (Estado)
            {
                case (0):
                    R_text.Text = "";
                    R_text.Enabled = false;
                    R_text.Visible = false;
                    txt_InserirCodigo.Text = "Inserir Código";
                    Rick_Text_Simbolos.Text = "";
                    Rick_Text_Tokens.Text = "";
                    Rich_Text_Lexema.Text = "";
                    cmd_LimparDados.Enabled = false;
                    break;
                case (1):
                    txt_LerCodigo.Enabled = false;
                    R_text.Text = "";
                    R_text.Enabled = true;
                    R_text.Visible = true;
                    txt_InserirCodigo.Text = "Processar Código";
                    Rick_Text_Simbolos.Text = "";
                    Rick_Text_Tokens.Text = "";
                    Rich_Text_Lexema.Text = "";
                    cmd_LimparDados.Enabled = Enabled;
                    txt_LerCodigo.Enabled = false;
                    break;
                case (3):
                    cmd_LimparDados.Enabled = true;
                    break;
                case (4):
                    R_text.Text = "";
                    R_text.Enabled = false;
                    R_text.Visible = false;
                    txt_InserirCodigo.Text = "Inserir Código";
                    Rick_Text_Simbolos.Text = "";
                    Rick_Text_Tokens.Text = "";
                    Rich_Text_Lexema.Text = "";
                    cmd_LimparDados.Enabled = false;
                    tokens.Clear();
                    tabelaSimbolos.Clear();
                    txt_InserirCodigo.Enabled = true;
                    txt_LerCodigo.Enabled = true;
                    ContadorSimbolos = 0;
                    break;
            }

        }
        private void txt_InserirCodigo_Click(object sender, EventArgs e)
        {
            if (Estado == 1)
            {
                codigo = R_text.Text + " ";
                codigo = codigo.Replace("\n", "");///Retira a quebra de linha
                Retirar_Espacos();
                Executa();
            }
            else
            {
                Estado = 1;
                estado_form();
            }
        }
        private void InsereTexto(string text)
        {
            codigo = text;
        }
        private void txt_LerCodigo_Click(object sender, EventArgs e)
        {
            Estado = 3;
            estado_form();

            if (abrir_arquivo.ShowDialog() == DialogResult.OK)
            {
                var auxTexto = new StreamReader(abrir_arquivo.FileName);
                InsereTexto(auxTexto.ReadToEnd());
                codigo = codigo.Replace("\n", "");///Retira a quebra de linha
                Retirar_Espacos();
                Executa();
            }
        }

        private void cmd_LimparDados_Click(object sender, EventArgs e)
        {
            Estado = 4;
            estado_form();
        }
    }
}