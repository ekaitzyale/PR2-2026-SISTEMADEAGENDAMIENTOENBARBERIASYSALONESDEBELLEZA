using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using SistemaAgendamiento.Datos;

namespace SistemaAgendamiento.Forms
{
    // Interfaz creada por código para mantener compatibilidad con .NET Framework 4.8.
    public class FrmMenu : Form
    {
        private readonly Color fondo = Color.FromArgb(17, 23, 32);
        private readonly Color panel = Color.FromArgb(27, 35, 46);
        private readonly Color dorado = Color.FromArgb(214, 179, 113);
        private readonly Color texto = Color.FromArgb(238, 241, 245);
        private readonly Color secundario = Color.FromArgb(158, 171, 186);
        private Panel contenido;
        private FlowLayoutPanel navegacion;
        private Label titulo, subtitulo, estado;
        private string moduloActual = "Inicio";
        private DataGridView tabla;
        private DateTimePicker filtroFecha;
        private ComboBox filtroProfesional;

        public FrmMenu()
        {
            Text = "BARBER & BEAUTY | Sistema de Agendamiento";
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(930, 620);
            Size = new Size(1180, 740);
            BackColor = fondo;
            Font = new Font("Segoe UI", 10);
            ConstruirInterfaz();
            MostrarInicio();
        }

        private Label Etiqueta(string valor, int tamano, Color color, bool negrita = false)
        {
            return new Label { Text = valor, ForeColor = color, Font = new Font("Segoe UI", tamano, negrita ? FontStyle.Bold : FontStyle.Regular), AutoSize = true, Margin = new Padding(0, 0, 0, 8) };
        }

        private Button Boton(string nombre, EventHandler accion, bool destacado = false)
        {
            var boton = new Button
            {
                Text = nombre, Height = 43, Width = 184, FlatStyle = FlatStyle.Flat,
                BackColor = destacado ? dorado : panel, ForeColor = destacado ? fondo : texto,
                Font = new Font("Segoe UI", 10, FontStyle.Bold), Cursor = Cursors.Hand,
                Margin = new Padding(0, 5, 0, 5)
            };
            boton.FlatAppearance.BorderSize = 0;
            boton.Click += accion;
            return boton;
        }

        private void ConstruirInterfaz()
        {
            var lateral = new Panel { Dock = DockStyle.Left, Width = 220, BackColor = panel, Padding = new Padding(18, 24, 18, 15) };
            var marca = new Label { Text = "✦  BARBER & BEAUTY", Dock = DockStyle.Top, Height = 70, ForeColor = dorado, Font = new Font("Segoe UI", 13, FontStyle.Bold) };
            navegacion = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.TopDown, WrapContents = false, AutoScroll = true };
            navegacion.Controls.Add(Boton("⌂   Panel principal", (s, e) => MostrarInicio()));
            navegacion.Controls.Add(Boton("◉   Clientes", (s, e) => MostrarModulo("Clientes")));
            navegacion.Controls.Add(Boton("◈   Profesionales", (s, e) => MostrarModulo("Profesionales")));
            navegacion.Controls.Add(Boton("◇   Servicios", (s, e) => MostrarModulo("Servicios")));
            navegacion.Controls.Add(Boton("▦   Citas y agenda", (s, e) => MostrarModulo("Citas")));
            navegacion.Controls.Add(Boton("↻   Actualizar", (s, e) => Actualizar()));
            navegacion.Controls.Add(Boton("⏻   Salir", (s, e) => Close()));
            lateral.Controls.Add(navegacion);
            lateral.Controls.Add(marca);

            var principal = new Panel { Dock = DockStyle.Fill, Padding = new Padding(30, 24, 30, 20) };
            var encabezado = new Panel { Dock = DockStyle.Top, Height = 100 };
            titulo = new Label { Dock = DockStyle.Top, Height = 48, ForeColor = texto, Font = new Font("Segoe UI", 23, FontStyle.Bold) };
            subtitulo = new Label { Dock = DockStyle.Top, Height = 28, ForeColor = secundario, Font = new Font("Segoe UI", 10) };
            encabezado.Controls.Add(subtitulo);
            encabezado.Controls.Add(titulo);
            estado = new Label { Dock = DockStyle.Bottom, Height = 32, ForeColor = secundario, Font = new Font("Segoe UI", 9) };
            contenido = new Panel { Dock = DockStyle.Fill, AutoScroll = true };
            principal.Controls.Add(contenido);
            principal.Controls.Add(estado);
            principal.Controls.Add(encabezado);
            Controls.Add(principal);
            Controls.Add(lateral);
        }

        private void Encabezado(string nombre, string descripcion)
        {
            moduloActual = nombre;
            titulo.Text = nombre == "Inicio" ? "Panel principal" : nombre;
            subtitulo.Text = descripcion;
            contenido.Controls.Clear();
            tabla = null;
            estado.Text = "Sistema de agendamiento  •  " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private Panel Tarjeta(string encabezado, string detalle)
        {
            var tarjeta = new Panel { Width = 235, Height = 130, BackColor = panel, Margin = new Padding(0, 0, 16, 16), Padding = new Padding(18) };
            var etiqueta = Etiqueta(encabezado, 11, secundario);
            etiqueta.Dock = DockStyle.Top;
            var numero = Etiqueta(detalle, 25, dorado, true);
            numero.Dock = DockStyle.Bottom;
            tarjeta.Controls.Add(numero);
            tarjeta.Controls.Add(etiqueta);
            return tarjeta;
        }

        private void MostrarInicio()
        {
            Encabezado("Inicio", "Resumen de tu negocio y acceso rápido a las operaciones");
            var disposicion = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.TopDown, WrapContents = false, AutoScroll = true };
            var tarjetas = new FlowLayoutPanel { Width = 810, Height = 155, AutoSize = false, WrapContents = true };
            string[] entidades = { "CLIENTE", "PROFESIONAL", "SERVICIO", "CITA" };
            string[] nombres = { "Clientes registrados", "Profesionales activos", "Servicios activos", "Citas programadas" };
            for (int i = 0; i < entidades.Length; i++)
            {
                string condicion = i == 1 || i == 2 ? " WHERE Activo = 1" : i == 3 ? " WHERE Estado = N'Programada'" : "";
                tarjetas.Controls.Add(Tarjeta(nombres[i], Contar(entidades[i], condicion)));
            }
            disposicion.Controls.Add(tarjetas);
            disposicion.Controls.Add(Etiqueta("ACCESOS RÁPIDOS", 12, dorado, true));
            var accesos = new FlowLayoutPanel { Width = 810, Height = 65 };
            accesos.Controls.Add(Boton("Ver clientes", (s, e) => MostrarModulo("Clientes"), true));
            accesos.Controls.Add(Boton("Ver agenda", (s, e) => MostrarModulo("Citas"), true));
            disposicion.Controls.Add(accesos);
            disposicion.Controls.Add(Etiqueta("Los datos se consultan directamente en SQL Server. La creación y edición de citas se incorporará con validación de horarios.", 10, secundario));
            contenido.Controls.Add(disposicion);
        }

        private string Contar(string entidad, string condicion)
        {
            try
            {
                using (var conexion = ConexionBD.ObtenerConexion())
                using (var comando = new SqlCommand("SELECT COUNT(*) FROM dbo." + entidad + condicion, conexion))
                {
                    conexion.Open();
                    return Convert.ToString(comando.ExecuteScalar());
                }
            }
            catch (Exception) { return "—"; }
        }

        private void MostrarModulo(string modulo)
        {
            Encabezado(modulo, modulo == "Citas" ? "Consulta la agenda y administra cancelaciones" : "Consulta y registra información del negocio");
            var barra = new FlowLayoutPanel { Dock = DockStyle.Top, Height = modulo == "Citas" ? 112 : 64, AutoScroll = true };
            barra.Controls.Add(Boton("↻ Actualizar", (s, e) => CargarTabla()));
            if (modulo != "Citas")
                barra.Controls.Add(Boton("+ Nuevo registro", (s, e) => NuevoRegistro(), true));
            else
            {
                barra.Controls.Add(Boton("+ Nueva cita", (s, e) => AbrirCita(), true));
                barra.Controls.Add(Boton("Editar cita", (s, e) => EditarCita()));
                barra.Controls.Add(Boton("Cancelar cita", (s, e) => CancelarCita()));
                var filtros = new FlowLayoutPanel { Width = 800, Height = 48 };
                filtroFecha = new DateTimePicker { Width = 180, Format = DateTimePickerFormat.Short, Value = DateTime.Today };
                filtroProfesional = new ComboBox { Width = 245, DropDownStyle = ComboBoxStyle.DropDownList };
                filtroProfesional.Items.Add(new OpcionProfesional(0, "Todos los profesionales"));
                try
                {
                    using (var conexion = ConexionBD.ObtenerConexion())
                    using (var cmd = new SqlCommand("SELECT IdProfesional, Nombre FROM dbo.PROFESIONAL ORDER BY Nombre", conexion))
                    {
                        conexion.Open();
                        using (var lector = cmd.ExecuteReader())
                            while (lector.Read()) filtroProfesional.Items.Add(new OpcionProfesional(lector.GetInt32(0), lector.GetString(1)));
                    }
                }
                catch (Exception ex) { estado.Text = "No se pudieron cargar profesionales: " + ex.Message; }
                filtroProfesional.SelectedIndex = 0;
                filtros.Controls.Add(filtroFecha);
                filtros.Controls.Add(filtroProfesional);
                filtros.Controls.Add(Boton("Filtrar agenda", (s, e) => CargarTabla(), true));
                barra.Controls.Add(filtros);
            }
            tabla = new DataGridView
            {
                Dock = DockStyle.Fill, BackgroundColor = panel, BorderStyle = BorderStyle.None,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true, AllowUserToAddRows = false, AllowUserToDeleteRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect, MultiSelect = false,
                RowHeadersVisible = false, EnableHeadersVisualStyles = false,
                ColumnHeadersHeight = 38, RowTemplate = { Height = 34 },
                GridColor = fondo, ForeColor = texto, DefaultCellStyle = { BackColor = panel, ForeColor = texto, SelectionBackColor = Color.FromArgb(67, 82, 97), SelectionForeColor = Color.White },
                ColumnHeadersDefaultCellStyle = { BackColor = fondo, ForeColor = dorado, Font = new Font("Segoe UI", 10, FontStyle.Bold) }
            };
            contenido.Controls.Add(tabla);
            contenido.Controls.Add(barra);
            CargarTabla();
        }

        private void CargarTabla()
        {
            if (tabla == null) return;
            string consulta;
            switch (moduloActual)
            {
                case "Clientes": consulta = "SELECT IdCliente, Nombre, Telefono, Email FROM dbo.CLIENTE ORDER BY Nombre"; break;
                case "Profesionales": consulta = "SELECT IdProfesional, Nombre, Especialidad, Activo FROM dbo.PROFESIONAL ORDER BY Nombre"; break;
                case "Servicios": consulta = "SELECT IdServicio, Nombre, DuracionMinutos, Precio, Activo FROM dbo.SERVICIO ORDER BY Nombre"; break;
                case "Citas":
                    consulta = @"SELECT c.IdCita, c.FechaHoraInicio, c.FechaHoraFin, c.Estado,
                        cl.Nombre AS Cliente, p.Nombre AS Profesional, sv.Nombre AS Servicio, c.Observacion
                        FROM dbo.CITA c INNER JOIN dbo.CLIENTE cl ON cl.IdCliente = c.IdCliente
                        INNER JOIN dbo.PROFESIONAL p ON p.IdProfesional = c.IdProfesional
                        LEFT JOIN dbo.SERVICIO sv ON sv.IdServicio = c.IdServicio
                        WHERE c.FechaHoraInicio >= @dia AND c.FechaHoraInicio < DATEADD(day, 1, @dia)
                        AND (@profesional = 0 OR c.IdProfesional = @profesional)
                        ORDER BY c.FechaHoraInicio"; break;
                default: return;
            }
            try
            {
                using (var conexion = ConexionBD.ObtenerConexion())
                using (var comando = new SqlCommand(consulta, conexion))
                using (var adaptador = new SqlDataAdapter(comando))
                {
                    if (moduloActual == "Citas")
                    {
                        comando.Parameters.Add("@dia", SqlDbType.Date).Value = filtroFecha.Value.Date;
                        comando.Parameters.Add("@profesional", SqlDbType.Int).Value = ((OpcionProfesional)filtroProfesional.SelectedItem).Id;
                    }
                    var datos = new DataTable();
                    adaptador.Fill(datos);
                    tabla.DataSource = datos;
                    estado.Text = datos.Rows.Count + " registro(s) encontrados.";
                }
            }
            catch (Exception ex)
            {
                tabla.DataSource = null;
                estado.Text = "Error al consultar SQL Server.";
                MessageBox.Show("No fue posible consultar los datos. Comprueba SQL Server y App.config.\n\nDetalle: " + ex.Message, "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NuevoRegistro()
        {
            string[] campos;
            if (moduloActual == "Clientes") campos = new[] { "Nombre", "Teléfono", "Email (opcional)" };
            else if (moduloActual == "Profesionales") campos = new[] { "Nombre", "Especialidad" };
            else if (moduloActual == "Servicios") campos = new[] { "Nombre", "Duración (minutos)", "Precio" };
            else return;

            using (var dialogo = new Form())
            {
                dialogo.Text = "Nuevo registro · " + moduloActual;
                dialogo.Size = new Size(470, 180 + campos.Length * 62);
                dialogo.MinimumSize = dialogo.Size;
                dialogo.MaximumSize = dialogo.Size;
                dialogo.StartPosition = FormStartPosition.CenterParent;
                dialogo.BackColor = fondo;
                dialogo.ForeColor = texto;
                dialogo.FormBorderStyle = FormBorderStyle.FixedDialog;
                dialogo.MaximizeBox = false;
                dialogo.MinimizeBox = false;
                var entradas = new List<TextBox>();
                for (int i = 0; i < campos.Length; i++)
                {
                    var etiqueta = new Label { Text = campos[i], Location = new Point(26, 22 + i * 62), AutoSize = true, ForeColor = texto };
                    var entrada = new TextBox { Location = new Point(26, 45 + i * 62), Width = 405, MaxLength = 120 };
                    entradas.Add(entrada);
                    dialogo.Controls.Add(etiqueta);
                    dialogo.Controls.Add(entrada);
                }
                var guardar = Boton("Guardar registro", (s, e) => { }, true);
                guardar.Location = new Point(26, 55 + campos.Length * 62);
                guardar.Click += (s, e) =>
                {
                    if (GuardarRegistro(entradas)) { dialogo.DialogResult = DialogResult.OK; dialogo.Close(); }
                };
                dialogo.Controls.Add(guardar);
                dialogo.AcceptButton = guardar;
                if (dialogo.ShowDialog(this) == DialogResult.OK) CargarTabla();
            }
        }

        private bool GuardarRegistro(List<TextBox> campos)
        {
            string nombre = campos[0].Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El nombre es obligatorio."); return false;
            }
            string sql;
            if (moduloActual == "Clientes") sql = "INSERT INTO dbo.CLIENTE (Nombre, Telefono, Email) VALUES (@nombre, @telefono, @email)";
            else if (moduloActual == "Profesionales") sql = "INSERT INTO dbo.PROFESIONAL (Nombre, Especialidad) VALUES (@nombre, @especialidad)";
            else sql = "INSERT INTO dbo.SERVICIO (Nombre, DuracionMinutos, Precio) VALUES (@nombre, @duracion, @precio)";
            try
            {
                using (var conexion = ConexionBD.ObtenerConexion())
                using (var cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.Add("@nombre", SqlDbType.NVarChar, 100).Value = nombre;
                    if (moduloActual == "Clientes")
                    {
                        string telefono = campos[1].Text.Trim(), email = campos[2].Text.Trim();
                        if (telefono.Length == 0 || telefono.Length > 20 || email.Length > 120)
                        { MessageBox.Show("Introduce un teléfono válido (máximo 20 caracteres) y un email de hasta 120 caracteres."); return false; }
                        if (email.Length > 0 && !System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^\s@]+@[^\s@]+\.[^\s@]+$"))
                        { MessageBox.Show("Introduce un email válido."); return false; }
                        cmd.Parameters.Add("@telefono", SqlDbType.NVarChar, 20).Value = telefono;
                        cmd.Parameters.Add("@email", SqlDbType.NVarChar, 120).Value = email.Length == 0 ? (object)DBNull.Value : email;
                    }
                    else if (moduloActual == "Profesionales")
                    {
                        string especialidad = campos[1].Text.Trim();
                        if (especialidad.Length == 0 || especialidad.Length > 80) { MessageBox.Show("La especialidad es obligatoria (máximo 80 caracteres)."); return false; }
                        cmd.Parameters.Add("@especialidad", SqlDbType.NVarChar, 80).Value = especialidad;
                    }
                    else
                    {
                        int duracion; decimal precio;
                        if (!int.TryParse(campos[1].Text, out duracion) || duracion <= 0 || !decimal.TryParse(campos[2].Text, out precio) || precio < 0 || precio > 99999999.99m)
                        { MessageBox.Show("La duración debe ser un entero positivo y el precio un número no negativo."); return false; }
                        cmd.Parameters.Add("@duracion", SqlDbType.Int).Value = duracion;
                        var parametroPrecio = cmd.Parameters.Add("@precio", SqlDbType.Decimal);
                        parametroPrecio.Precision = 10; parametroPrecio.Scale = 2; parametroPrecio.Value = precio;
                    }
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Registro guardado correctamente.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex) { MessageBox.Show("No se pudo guardar el registro:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
        }

        private void AbrirCita()
        {
            using (var formulario = new FrmCita())
                if (formulario.ShowDialog(this) == DialogResult.OK) CargarTabla();
        }

        private void EditarCita()
        {
            if (tabla == null || tabla.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona primero una cita programada.");
                return;
            }
            int id = Convert.ToInt32(tabla.SelectedRows[0].Cells["IdCita"].Value);
            using (var formulario = new FrmCita(id))
                if (formulario.ShowDialog(this) == DialogResult.OK) CargarTabla();
        }

        private void CancelarCita()
        {
            if (tabla == null || tabla.SelectedRows.Count == 0) { MessageBox.Show("Selecciona una cita de la tabla."); return; }
            var fila = tabla.SelectedRows[0];
            int id = Convert.ToInt32(fila.Cells["IdCita"].Value);
            if (MessageBox.Show("¿Cancelar la cita #" + id + "? El registro se conservará.", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                using (var conexion = ConexionBD.ObtenerConexion())
                using (var cmd = new SqlCommand("UPDATE dbo.CITA SET Estado = N'Cancelada' WHERE IdCita = @id AND Estado = N'Programada'", conexion))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    conexion.Open();
                    int afectados = cmd.ExecuteNonQuery();
                    MessageBox.Show(afectados == 1 ? "Cita cancelada correctamente." : "Solo se pueden cancelar citas programadas.");
                }
                CargarTabla();
            }
            catch (Exception ex) { MessageBox.Show("No se pudo cancelar la cita:\n" + ex.Message); }
        }

        private void Actualizar()
        {
            if (moduloActual == "Inicio") MostrarInicio();
            else MostrarModulo(moduloActual);
        }

        private sealed class OpcionProfesional
        {
            public int Id { get; private set; }
            private readonly string nombre;
            public OpcionProfesional(int id, string nombreProfesional) { Id = id; nombre = nombreProfesional; }
            public override string ToString() { return nombre; }
        }
    }
}
