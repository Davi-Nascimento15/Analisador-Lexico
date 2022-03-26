namespace AnalisadorLexico
{
    public partial class Inicio : Form
    {
        char[] simbolos = { '(', ')', '{', '}', ',', ';', '[', ']'};
        string[] keys = { "main", "void", "int", "while", "for", "then", "if", "else", "float", "double", "string", "char", "boolean", "bool", "break", "switch", "case", "do" };
        char[] caractere = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z','_','.'};
        string[] operador = { "+", "-", "*", "/", ">", "<", "=", "==", "!=", ">=", "<=", "&&", "||" };
        char[] numero = { '0','1', '2', '3', '4', '5', '6', '7', '8', '9'};
        public Inicio()
        {
            InitializeComponent();
        }
        bool Simbolo(char c)
        {
            foreach (char ch in simbolos)
            {
                if (ch== c)
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
        void Executa() {
            Dictionary<string,string> token = new Dictionary<string, string>();
            string Aux = R_text.Text+" ";
            int i = 0;
            string Aux1 = "";
            char cenario=' ';
            foreach (char item in Aux)
            {
                if(item!=' ')
                {
                    if (cenario=='.')
                    {
                        if (Numero(item))
                        {
                            Aux1 += cenario;
                            cenario = ' ';
                        }
                        else if(Caractere(item))
                        {
                            token.Add((i++).ToString(), Aux1.ToString());
                            token.Add((i++).ToString(), cenario.ToString());
                            cenario= ' ';
                            Aux1 =" ";
                        }
                    }
                    if (Simbolo(item))
                    {
                        if (Aux1 == "")
                        {
                            token.Add((i++).ToString(), item.ToString());
                            Aux1 = "";                            
                        }
                        else if(Aux1!=""){
                             token.Add((i++).ToString(), Aux1);
                             Aux1 = "";
                             token.Add((i++).ToString(), item.ToString());

                        }
                    }else if (Operador(item))
                    {
                        if (Aux1 == "")
                        {
                            token.Add((i++).ToString(), item.ToString());
                            Aux1 = "";
                        }
                        else if (Aux1 != "")
                        {
                            token.Add((i++).ToString(), Aux1);
                            Aux1 = "";
                            token.Add((i++).ToString(), item.ToString());
                        }
                    }
                    else if(Caractere(item))
                    {
                        if (item == '.')
                            cenario = item;
                        else
                            Aux1 += item.ToString();
                        if (Keys(Aux1))
                        {
                            token.Add("Key"+(i++), Aux1);
                            Aux1 = "";
                        }
                    }
                    else if (Numero(item))
                    {
                        
                        Aux1 += item.ToString();
                    }
                }
                else
                {
                    if (Aux1 !="")
                    {
                        token.Add((i++).ToString(), Aux1);
                        Aux1 = "";
                    }
                }
            }
            foreach (var item in token)
            {
                R_Text1.Text += item.Key + " " + item.Value +"\n" ;
            }
        }
        private void txt_InserirCodigo_Click(object sender, EventArgs e)
        {
            R_text.Enabled= true;
            R_text.Visible = true;
            Executa();
        }
        private void txt_LerCodigo_Click(object sender, EventArgs e)
        {

        }
    }
}