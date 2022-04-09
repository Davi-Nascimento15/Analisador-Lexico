namespace AnalisadorLexico
{
    public partial class Inicio : Form
    {
        char[] simbolos = { '(', ')', '{', '}', ',', ';', '[', ']' };
        string[] keys = { "main", "void", "int", "while", "for", "then", "if", "else", "float", "double", "string", "char", "boolean", "bool", "break", "switch", "case", "do" };
        char[] caractere = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '_', '.' };
        string[] operador = { ">", "<", "=", "==", "!=", ">=", "<=", "&&", "||" };
        string[] sinais = { "+", "-", "*", "/" };
        char[] numero = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        bool[] tipoEntrada = { false, false, false, false, false, false }; // 0 - caractere, 1-numero, 2-simbolo,3-operador,4-sinais e 5-Quebra de Linha
        Dictionary<string, string> token = new Dictionary<string, string>();
        
        List<Token> tokens = new List<Token>();
        Token AuxToken = null;

        string lexema = "";//Armazena o padrão lido até o momento " " ou troca de padrão
        bool espaco = false;

        int aux = 0;
        
        public Inicio()
        {
            InitializeComponent();
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
            else if ((tipoEntrada[3] && i == 3 || tipoEntrada[4] && i == 4) && lexema.Length == 2)
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
            switch (i)
            {
                case 0:
                    if (Keys(lexema))
                    {
                        token.Add("Key" + aux++, lexema);//Palavra reservada
                        lexema = "";
                    }
                    else
                    {
                        token.Add("Id" + aux++, lexema);
                        lexema = "";
                    }
                    break;
                case 1:
                    token.Add("Number" + aux++, lexema);
                    lexema = "";
                    break;
                case 2:
                    token.Add("Delop" + aux++, lexema);//Delimitadores
                    lexema = "";
                    break;
                case 3:
                    token.Add("Relop" + aux++, lexema);//Funçoes Matemáticas (>,<,==)
                    lexema = "";
                    break;
                case 4:
                    token.Add("Matop" + aux++, lexema);//Funços Matemáticas (+,-,/,*)
                    lexema = "";
                    break;
                case 5:
                    token.Add("ws" + aux++, lexema);
                    lexema = "";
                    break;
            }
        }

        void PreencherDados()
        {
            foreach (var item in token)//Traz o lexema
            {
                Rich_Text_Lexema.Text += item.Value + "\n";
            }
            foreach (var item in token)//Traz o token
            {
                if (item.Key.Substring(0, 3) == "Key")
                    Rick_Text_Tokens.Text += "< " + item.Value + " >" + "\n";
                else
                    Rick_Text_Tokens.Text += "< " + item.Key + " , " + item.Value + " >" + "\n";
            }
        }

        void Executa()
        {
            string codigo = R_text.Text + " ";///Recebe todo o código lido

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
                    espaco = true;
                    if (lexema != "")
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (tipoEntrada[j])
                            {
                                VerificaPadrao(j);
                            }
                        }
                    }
                }
            }
            PreencherDados();
        }
        private void txt_InserirCodigo_Click(object sender, EventArgs e)
        {
            R_text.Enabled = true;
            R_text.Visible = true;
            Executa();
        }
        private void txt_LerCodigo_Click(object sender, EventArgs e)
        {

        }
    }
}