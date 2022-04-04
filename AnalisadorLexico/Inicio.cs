namespace AnalisadorLexico
{/// <summary>
/// ////PROBLEMA COM A EXPRESSÃO (4/3)
/// </summary>
    public partial class Inicio : Form
    {
        char[] simbolos = { '(', ')', '{', '}', ',', ';', '[', ']' };
        string[] keys = { "main", "void", "int", "while", "for", "then", "if", "else", "float", "double", "string", "char", "boolean", "bool", "break", "switch", "case", "do" };
        char[] caractere = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '_', '.' };
        string[] operador = { "+", "-", "*", "/", ">", "<", "=", "==", "!=", ">=", "<=", "&&", "||" };
        char[] numero = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
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
        void Executa()
        {

            Dictionary<string, string> token = new Dictionary<string, string>();
            string Aux = R_text.Text + " ";
            int i = 0;
            string Aux1 = "";
            char cenario = ' ';
            string AuxNumero = "";
            string AuxCaractere = "";

            foreach (char item in Aux)
            {
                if (AuxCaractere != "")
                {
                    if (!Caractere(item) || Operador(cenario))
                    {
                        if (cenario != ' ')
                        {
                            if (Caractere(cenario))
                            {
                                AuxCaractere += cenario;
                                cenario = ' ';
                            }
                        }
                        if (Keys(AuxCaractere))
                        {
                            token.Add("Key" + (i++), AuxCaractere);
                            AuxCaractere = "";
                        }
                        else
                        {
                            token.Add("Id" + (i++).ToString(), AuxCaractere);
                            AuxCaractere = "";
                        }
                    }
                }
                if (AuxNumero != "")
                {
                    if (!Numero(item))
                    {
                        if (Operador(cenario))
                        {
                            token.Add("numero" + (i++).ToString(), AuxNumero);
                            AuxNumero = "";
                        }
                        else if (cenario != ' ')
                        {
                            if (Numero(cenario))
                            {
                                AuxNumero += cenario.ToString();
                                cenario = ' ';
                            }
                        }
                        else
                        {
                            token.Add("numero" + (i++).ToString(), AuxNumero);
                            AuxNumero = "";
                            cenario = ' ';
                        }
                    }
                }
                if (cenario == '.')
                {
                    if (Numero(item))
                    {
                        Aux1 += cenario;
                        cenario = ' ';///numero float
                    }
                    else if (Caractere(item))
                    {
                        token.Add("ID" + (i++).ToString(), Aux1.ToString());
                        token.Add((i++).ToString(), cenario.ToString());///ponto de função
                        cenario = ' ';
                        Aux1 = " ";
                    }
                }
                if (Numero(cenario))
                {
                    AuxNumero += cenario.ToString();
                    cenario = ' ';
                }
                if (Operador(cenario))
                {
                    if (Operador(item))
                    {
                        token.Add("Oper" + (i++).ToString(), cenario.ToString() + item.ToString());
                        cenario = ' ';
                        Aux1 = item.ToString();
                    }
                    else
                    {
                        token.Add("Oper" + (i++).ToString(), cenario.ToString());
                        cenario = ' ';
                        Aux1 = "";
                    }
                }
                if (Caractere(cenario))
                {
                    AuxCaractere += cenario.ToString();
                    cenario = ' ';
                }
                if (Simbolo(item))
                {
                    if (AuxNumero != "")//Aux1
                    {
                        token.Add("number" + (i++).ToString(), AuxNumero.ToString());
                        token.Add("simbol" + (i++).ToString(), item.ToString());
                        AuxNumero = "";
                    }
                    else if (AuxCaractere != "")
                    {
                        //////
                        ///
                        if (Keys(AuxCaractere))
                            token.Add("Key" + (i++).ToString(), AuxCaractere.ToString());
                        else
                            token.Add("ID" + (i++).ToString(), AuxCaractere.ToString());

                        token.Add("simbol" + (i++).ToString(), AuxCaractere.ToString());
                        AuxCaractere = "";
                        //////
                    }
                    else
                    {
                        token.Add("simbol" + (i++).ToString(), item.ToString());
                    }

                }
                else if (Operador(item))
                {
                    if (Aux1 == "")
                    {
                        if (cenario == ' ')
                            cenario = item;
                    }
                    else
                        Aux1 = "";
                }
                else if (Caractere(item))
                {
                    if (item == '.')
                        cenario = item;
                    else if (cenario == ' ' || Caractere(cenario))
                    {
                        cenario = item;
                    }
                }
                else if (Numero(item))
                {
                    if (cenario == ' ' || Numero(cenario))
                        cenario = item;
                }
            }
            foreach (var item in token)
            {
                R_Text1.Text += item.Key + " " + item.Value + "\n";
            }
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