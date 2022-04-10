namespace AnalisadorLexico
{
    public partial class frm_inicializacao : Form
    {
        int contador = 5;
        public frm_inicializacao()
        {
            InitializeComponent();
        }
        private void frm_inicializacao_Load(object sender, EventArgs e)
        {
            timer_inicio.Start();
        }
        private void timer_inicio_Tick(object sender, EventArgs e)
        {
            if (contador > 0)
            {
                contador--;
            }
            else
            {
                timer_inicio.Stop();
                Close();
            }
        }
    }
}