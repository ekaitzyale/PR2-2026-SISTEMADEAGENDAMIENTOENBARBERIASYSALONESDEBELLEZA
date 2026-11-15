using System.Drawing;
using System.Windows.Forms;

namespace SistemaAgendamiento.Forms
{
    public class FrmMenu : Form
    {
        private Label lblTitulo;
        private Label lblEstado;
        private Button btnClientes;
        private Button btnProfesionales;
        private Button btnServicios;
        private Button btnCitas;

        public FrmMenu()
        {
            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            Text = "Sistema de Agendamiento";
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(820, 520);
            MinimumSize = new Size(700, 450);
            BackColor = Color.WhiteSmoke;

            lblTitulo = new Label();
            lblTitulo.Text = "SISTEMA DE AGENDAMIENTO";
            lblTitulo.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(35, 30);

            Label lblSubtitulo = new Label();
            lblSubtitulo.Text = "Barberías y Salones de Belleza";
            lblSubtitulo.Font = new Font("Segoe UI", 11);
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Location = new Point(39, 78);

            btnClientes = CrearBoton("Clientes", 40, 145);
            btnProfesionales = CrearBoton("Profesionales", 225, 145);
            btnServicios = CrearBoton("Servicios", 410, 145);
            btnCitas = CrearBoton("Citas y agenda", 595, 145);

            lblEstado = new Label();
            lblEstado.Text = "Proyecto iniciado. Los módulos se implementarán paso a paso.";
            lblEstado.Font = new Font("Segoe UI", 9);
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(40, 250);

            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(btnClientes);
            Controls.Add(btnProfesionales);
            Controls.Add(btnServicios);
            Controls.Add(btnCitas);
            Controls.Add(lblEstado);
        }

        private Button CrearBoton(string texto, int x, int y)
        {
            Button boton = new Button();
            boton.Text = texto;
            boton.Location = new Point(x, y);
            boton.Size = new Size(165, 65);
            boton.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            boton.Enabled = false;
            return boton;
        }
    }
}
