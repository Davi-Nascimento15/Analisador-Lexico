namespace AnalisadorLexico
{
    public partial class Inicio : Form
    {
        char[] simbolos = { '(', ')', '{', '}', ',', ';', '[', ']' };
        string[] keys = { "main", "void", "int", "while", "for", "then", "if", "else", "float", "double", "string", "char", "boolean", "bool", "break", "switch", "case", "do" };
        char[] caractere = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        string[] operador = { "+", "-", "*", "/", ">", "<", "=", "==", "!=", ">=", "<=", "&&", "||" };
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

        void Executa() {
            Dictionary<string,string> token = new Dictionary<string, string>();
            string Aux = R_text.Text;
            string Aux1 = "";
            foreach (char item in Aux)
            {
                if(item!=' ')
                {
                    if (Simbolo(item))
                    {
                        Aux1 += item.ToString();
                    }else if (Operador(item))
                    {
                        Aux1 += item.ToString();
                    }
                    else if (Keys(item.ToString()))
                    {
                        Aux1 += item.ToString();
                    }
                    else
                    {
                        Aux1 += item.ToString();
                    }
                }
                else
                {
                    if (Aux1 != "")
                    {
                        token.Add(Aux1, Aux1);
                        Aux1 = "";
                    }
                }
            }
            foreach (string key in token.Keys)
            {
                R_Text1.Text += token[key] +"\n";
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