using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaAgendamiento.Forms
{
    // Presentación breve de la interfaz. No simula la conexión a SQL Server.
    public sealed class FrmBienvenida : Form
    {
        private readonly ProgressBar progreso;
        private readonly Timer temporizador;
        private readonly Label porcentaje;

        public FrmBienvenida()
        {
            Text = "BARBER & BEAUTY";
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(660, 380);
            BackColor = Color.FromArgb(17, 23, 32);
            Font = new Font("Segoe UI", 10);
            var oro = Color.FromArgb(214, 179, 113);
            var blanco = Color.FromArgb(238, 241, 245);

            var linea = new Panel { Dock = DockStyle.Top, Height = 7, BackColor = oro };
            Controls.Add(linea);
            var marca = new Label {
                Text = "✦", ForeColor = oro, Font = new Font("Segoe UI Symbol", 42),
                TextAlign = ContentAlignment.MiddleCenter, Bounds = new Rectangle(0, 48, 660, 72)
            };
            var titulo = new Label {
                Text = "BARBER & BEAUTY", ForeColor = blanco,
                Font = new Font("Segoe UI", 29, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter, Bounds = new Rectangle(20, 130, 620, 58)
            };
            var descripcion = new Label {
                Text = "GESTIÓN PROFESIONAL DE CITAS Y SERVICIOS",
                ForeColor = Color.FromArgb(158, 171, 186),
                Font = new Font("Segoe UI", 11),
                TextAlign = ContentAlignment.MiddleCenter, Bounds = new Rectangle(20, 195, 620, 28)
            };
            porcentaje = new Label {
                Text = "Preparando interfaz · 0%", ForeColor = oro,
                TextAlign = ContentAlignment.MiddleCenter, Bounds = new Rectangle(20, 260, 620, 26)
            };
            progreso = new ProgressBar {
                Minimum = 0, Maximum = 100, Value = 0,
                Style = ProgressBarStyle.Continuous, Bounds = new Rectangle(95, 302, 470, 12)
            };
            Controls.Add(marca);
            Controls.Add(titulo);
            Controls.Add(descripcion);
            Controls.Add(porcentaje);
            Controls.Add(progreso);
            temporizador = new Timer { Interval = 35 };
            temporizador.Tick += (s, e) => {
                progreso.Value = Math.Min(100, progreso.Value + 4);
                porcentaje.Text = "Preparando interfaz · " + progreso.Value + "%";
                if (progreso.Value == 100) { temporizador.Stop(); DialogResult = DialogResult.OK; Close(); }
            };
            Shown += (s, e) => temporizador.Start();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) temporizador.Dispose();
            base.Dispose(disposing);
        }
    }
}
