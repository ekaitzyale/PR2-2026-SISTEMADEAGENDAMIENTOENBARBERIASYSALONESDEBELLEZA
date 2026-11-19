using System;
using System.Windows.Forms;

namespace SistemaAgendamiento
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var bienvenida = new Forms.FrmBienvenida())
                bienvenida.ShowDialog();
            Application.Run(new Forms.FrmMenu());
        }
    }
}
