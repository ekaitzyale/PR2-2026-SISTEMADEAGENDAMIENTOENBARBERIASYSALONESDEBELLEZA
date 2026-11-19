using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using SistemaAgendamiento.Datos;

namespace SistemaAgendamiento.Forms
{
    // Alta y modificación de reservas con verificación de disponibilidad en una transacción.
    public sealed class FrmCita : Form
    {
        private readonly int? idCita;
        private readonly ComboBox clientes = new ComboBox(), profesionales = new ComboBox(), servicios = new ComboBox();
        private readonly DateTimePicker fecha = new DateTimePicker(), hora = new DateTimePicker();
        private readonly TextBox observacion = new TextBox();
        private readonly Label resumen = new Label();
        private readonly Color fondo = Color.FromArgb(17, 23, 32), panel = Color.FromArgb(27, 35, 46), oro = Color.FromArgb(214, 179, 113);

        public FrmCita(int? cita = null)
        {
            idCita = cita;
            Text = cita.HasValue ? "Editar cita" : "Nueva cita";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false; MinimizeBox = false;
            ClientSize = new Size(520, 650);
            BackColor = fondo; ForeColor = Color.White;
            Font = new Font("Segoe UI", 10);
            var cabecera = new Panel { Bounds = new Rectangle(0, 0, 520, 75), BackColor = panel };
            cabecera.Controls.Add(new Label { Text = cita.HasValue ? "EDITAR RESERVA" : "NUEVA RESERVA", ForeColor = oro, Font = new Font("Segoe UI", 18, FontStyle.Bold), Bounds = new Rectangle(24, 12, 470, 36) });
            cabecera.Controls.Add(new Label { Text = "BARBER & BEAUTY  /  AGENDA", ForeColor = Color.FromArgb(158, 171, 186), Font = new Font("Segoe UI", 9), Bounds = new Rectangle(25, 48, 460, 20) });
            Controls.Add(cabecera);
            int y = 95;
            AgregarTitulo("CLIENTE", ref y); AgregarControl(clientes, ref y);
            AgregarTitulo("PROFESIONAL", ref y); AgregarControl(profesionales, ref y);
            AgregarTitulo("SERVICIO", ref y); AgregarControl(servicios, ref y);
            AgregarTitulo("FECHA", ref y); AgregarControl(fecha, ref y);
            AgregarTitulo("HORA", ref y); AgregarControl(hora, ref y);
            AgregarTitulo("OBSERVACIONES (OPCIONAL)", ref y); AgregarControl(observacion, ref y);
            resumen.SetBounds(24, y + 4, 465, 40);
            resumen.ForeColor = oro;
            Controls.Add(resumen);
            var guardar = new Button { Text = cita.HasValue ? "Guardar cambios" : "Confirmar cita", BackColor = oro, ForeColor = fondo, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            guardar.FlatAppearance.BorderSize = 0;
            guardar.SetBounds(24, y + 60, 460, 45);
            guardar.Cursor = Cursors.Hand;
            guardar.Click += (s, e) => Guardar();
            Controls.Add(guardar);
            AcceptButton = guardar;
            foreach (var cb in new[] { clientes, profesionales, servicios })
            {
                cb.DropDownStyle = ComboBoxStyle.DropDownList;
                cb.BackColor = panel; cb.ForeColor = Color.White;
                cb.FlatStyle = FlatStyle.Flat;
            }
            fecha.Format = DateTimePickerFormat.Short;
            fecha.MinDate = new DateTime(2000, 1, 1);
            hora.Format = DateTimePickerFormat.Custom;
            hora.CustomFormat = "HH:mm";
            hora.ShowUpDown = true;
            servicios.SelectedIndexChanged += (s, e) => ActualizarResumen();
            fecha.ValueChanged += (s, e) => ActualizarResumen();
            hora.ValueChanged += (s, e) => ActualizarResumen();
            try
            {
                CargarOpciones();
                if (idCita.HasValue) CargarCita();
                ActualizarResumen();
            }
            catch (Exception ex)
            {
                guardar.Enabled = false;
                MessageBox.Show("No se pudieron cargar los datos de la cita. Comprueba la conexión y ejecuta la migración 02.\n\n" + ex.Message, "Citas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarTitulo(string nombre, ref int y)
        {
            Controls.Add(new Label { Text = nombre, Left = 24, Top = y, Width = 460, Height = 21, ForeColor = oro, Font = new Font("Segoe UI", 9, FontStyle.Bold) });
            y += 22;
        }

        private void AgregarControl(Control control, ref int y)
        {
            control.SetBounds(24, y, 460, 32);
            if (control is TextBox) { ((TextBox)control).BackColor = panel; ((TextBox)control).ForeColor = Color.White; ((TextBox)control).BorderStyle = BorderStyle.FixedSingle; }
            Controls.Add(control);
            y += 51;
        }

        private void CargarOpciones()
        {
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                CargarLista(conexion, clientes, "SELECT IdCliente, Nombre + N' · ' + Telefono AS Nombre FROM dbo.CLIENTE ORDER BY Nombre");
                CargarLista(conexion, profesionales, "SELECT IdProfesional, Nombre FROM dbo.PROFESIONAL WHERE Activo = 1 ORDER BY Nombre");
                CargarLista(conexion, servicios, "SELECT IdServicio, Nombre + N' (' + CONVERT(NVARCHAR(12), DuracionMinutos) + N' min)' AS Nombre, DuracionMinutos FROM dbo.SERVICIO WHERE Activo = 1 ORDER BY Nombre");
            }
        }

        private void CargarLista(SqlConnection conexion, ComboBox combo, string consulta)
        {
            using (var adaptador = new SqlDataAdapter(consulta, conexion))
            {
                var tabla = new DataTable();
                adaptador.Fill(tabla);
                combo.DataSource = tabla;
                combo.DisplayMember = "Nombre";
                combo.ValueMember = tabla.Columns[0].ColumnName;
                combo.SelectedIndex = -1;
            }
        }

        private void CargarCita()
        {
            using (var conexion = ConexionBD.ObtenerConexion())
            using (var cmd = new SqlCommand("SELECT IdCliente, IdProfesional, IdServicio, FechaHoraInicio, Observacion FROM dbo.CITA WHERE IdCita = @id AND Estado = N'Programada'", conexion))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = idCita.Value;
                conexion.Open();
                using (var lector = cmd.ExecuteReader())
                {
                    if (!lector.Read()) throw new InvalidOperationException("La cita no existe o ya no está programada.");
                    int cliente = lector.GetInt32(0), profesional = lector.GetInt32(1);
                    int servicio = lector.IsDBNull(2) ? 0 : lector.GetInt32(2);
                    DateTime inicio = lector.GetDateTime(3);
                    string nota = lector.IsDBNull(4) ? "" : lector.GetString(4);
                    clientes.SelectedValue = cliente;
                    profesionales.SelectedValue = profesional;
                    servicios.SelectedValue = servicio;
                    fecha.Value = inicio.Date; hora.Value = inicio;
                    observacion.Text = nota;
                }
            }
        }

        private DateTime Inicio() { return fecha.Value.Date.AddHours(hora.Value.Hour).AddMinutes(hora.Value.Minute); }
        private int Duracion()
        {
            var fila = servicios.SelectedItem as DataRowView;
            return fila == null ? 0 : Convert.ToInt32(fila["DuracionMinutos"]);
        }

        private void ActualizarResumen()
        {
            int minutos = Duracion();
            resumen.Text = minutos > 0 ? "Horario: " + Inicio().ToString("dd/MM/yyyy HH:mm") + " – " + Inicio().AddMinutes(minutos).ToString("HH:mm") : "Selecciona un servicio para calcular la duración.";
        }

        private void Guardar()
        {
            if (clientes.SelectedIndex < 0 || profesionales.SelectedIndex < 0 || servicios.SelectedIndex < 0)
            { MessageBox.Show("Registra y selecciona un cliente, un profesional y un servicio."); return; }
            int duracion = Duracion();
            if (duracion <= 0) { MessageBox.Show("La duración del servicio no es válida."); return; }
            DateTime inicio = Inicio();
            if (!idCita.HasValue && inicio < DateTime.Now)
            { MessageBox.Show("La nueva cita debe tener una fecha y hora futuras."); return; }
            DateTime fin;
            try { fin = inicio.AddMinutes(duracion); }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("La fecha o duración no es válida."); return; }
            if (observacion.Text.Trim().Length > 250) { MessageBox.Show("La observación no debe superar 250 caracteres."); return; }
            try
            {
                using (var conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    // Serializa reservas del mismo profesional mediante bloqueo de aplicación por transacción.
                    using (var transaccion = conexion.BeginTransaction(IsolationLevel.Serializable))
                    {
                        int profesional = Convert.ToInt32(profesionales.SelectedValue);
                        using (var lockCmd = new SqlCommand("DECLARE @r INT; EXEC @r = sp_getapplock @Resource = @recurso, @LockMode = 'Exclusive', @LockOwner = 'Transaction', @LockTimeout = 10000; SELECT @r;", conexion, transaccion))
                        {
                            lockCmd.Parameters.Add("@recurso", SqlDbType.NVarChar, 255).Value = "AgendaProfesional:" + profesional;
                            int resultado = Convert.ToInt32(lockCmd.ExecuteScalar());
                            if (resultado < 0) throw new InvalidOperationException("No se pudo bloquear el horario. Vuelve a intentarlo.");
                        }
                        using (var verificar = new SqlCommand(@"SELECT COUNT(*) FROM dbo.CITA WITH (UPDLOCK, HOLDLOCK)
                            WHERE IdProfesional = @profesional AND Estado <> N'Cancelada'
                            AND FechaHoraInicio < @fin AND FechaHoraFin > @inicio
                            AND (@id IS NULL OR IdCita <> @id)", conexion, transaccion))
                        {
                            verificar.Parameters.Add("@profesional", SqlDbType.Int).Value = profesional;
                            verificar.Parameters.Add("@inicio", SqlDbType.DateTime2).Value = inicio;
                            verificar.Parameters.Add("@fin", SqlDbType.DateTime2).Value = fin;
                            verificar.Parameters.Add("@id", SqlDbType.Int).Value = idCita.HasValue ? (object)idCita.Value : DBNull.Value;
                            if (Convert.ToInt32(verificar.ExecuteScalar()) > 0)
                            {
                                MessageBox.Show("El profesional ya tiene una cita en ese horario. Selecciona otro turno.", "Horario ocupado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        string sql = idCita.HasValue
                            ? @"UPDATE dbo.CITA SET IdCliente=@cliente, IdProfesional=@profesional, IdServicio=@servicio,
                                FechaHoraInicio=@inicio, FechaHoraFin=@fin, Observacion=@nota WHERE IdCita=@id AND Estado=N'Programada'"
                            : @"INSERT INTO dbo.CITA (IdCliente, IdProfesional, IdServicio, FechaHoraInicio, FechaHoraFin, Estado, Observacion)
                                VALUES (@cliente, @profesional, @servicio, @inicio, @fin, N'Programada', @nota)";
                        using (var cmd = new SqlCommand(sql, conexion, transaccion))
                        {
                            cmd.Parameters.Add("@cliente", SqlDbType.Int).Value = Convert.ToInt32(clientes.SelectedValue);
                            cmd.Parameters.Add("@profesional", SqlDbType.Int).Value = profesional;
                            cmd.Parameters.Add("@servicio", SqlDbType.Int).Value = Convert.ToInt32(servicios.SelectedValue);
                            cmd.Parameters.Add("@inicio", SqlDbType.DateTime2).Value = inicio;
                            cmd.Parameters.Add("@fin", SqlDbType.DateTime2).Value = fin;
                            cmd.Parameters.Add("@nota", SqlDbType.NVarChar, 250).Value = string.IsNullOrWhiteSpace(observacion.Text) ? (object)DBNull.Value : observacion.Text.Trim();
                            if (idCita.HasValue) cmd.Parameters.Add("@id", SqlDbType.Int).Value = idCita.Value;
                            if (cmd.ExecuteNonQuery() != 1) throw new InvalidOperationException("La cita ya no puede modificarse.");
                        }
                        transaccion.Commit();
                    }
                }
                MessageBox.Show("Cita guardada correctamente.", "Reserva confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex) { MessageBox.Show("No se pudo guardar la cita:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
