namespace AnalisadorLexico
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frm_inicio());
        }
    }
}