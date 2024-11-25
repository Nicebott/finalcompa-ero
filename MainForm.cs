using System;
using System.Windows.Forms;
using System.Linq;

namespace INF512_FinalProject
{
    public partial class MainForm : Form
    {
        private readonly RepositorioEstudiantes repositorio;

        public MainForm()
        {
            InitializeComponent();
            repositorio = new RepositorioEstudiantes();
            ConfigurarDataGridView();
            ConfigurarCamposNumericos();
            CargarEstudiantes();
        }

        private void ConfigurarCamposNumericos()
        {
            // Configurar validación para campos numéricos
            TextBox[] camposNumericos = { practica1, practica2, practica3, examen1, examen2, examen3 };
            foreach (var campo in camposNumericos)
            {
                campo.Text = "0";
                campo.KeyPress += (s, e) =>
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                    {
                        e.Handled = true;
                    }

                    if (e.KeyChar == '.' && (s as TextBox).Text.IndexOf('.') > -1)
                    {
                        e.Handled = true;
                    }
                };
            }
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Matricula",
                HeaderText = "Matrícula",
                DataPropertyName = "Matricula",
                Width = 100
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                Width = 200
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Practica1",
                HeaderText = "Práctica 1",
                DataPropertyName = "Practica1",
                Width = 80
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Practica2",
                HeaderText = "Práctica 2",
                DataPropertyName = "Practica2",
                Width = 80
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Practica3",
                HeaderText = "Práctica 3",
                DataPropertyName = "Practica3",
                Width = 80
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Examen1",
                HeaderText = "Examen 1",
                DataPropertyName = "Examen1",
                Width = 80
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Examen2",
                HeaderText = "Examen 2",
                DataPropertyName = "Examen2",
                Width = 80
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Examen3",
                HeaderText = "Examen 3",
                DataPropertyName = "Examen3",
                Width = 80
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NotaFinal",
                HeaderText = "Nota Final",
                DataPropertyName = "CalificacionFinal",
                Width = 80
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Estatus",
                HeaderText = "Estatus",
                DataPropertyName = "Estatus",
                Width = 100
            });
        }

        private void CargarEstudiantes()
        {
            try
            {
                var estudiantes = repositorio.CargarEstudiantes();
                dataGridView1.Rows.Clear();

                foreach (var estudiante in estudiantes)
                {
                    dataGridView1.Rows.Add(
                        estudiante.Matricula,
                        estudiante.Nombre,
                        estudiante.Practicas[0],
                        estudiante.Practicas[1],
                        estudiante.Practicas[2],
                        estudiante.Examenes[0],
                        estudiante.Examenes[1],
                        estudiante.Examenes[2],
                        estudiante.CalificacionFinal,
                        estudiante.Estatus
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar estudiantes: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Matricula.Text) || string.IsNullOrWhiteSpace(Nombre.Text))
            {
                MessageBox.Show("Por favor complete los campos requeridos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var estudiante = new Estudiante
                {
                    Matricula = Matricula.Text,
                    Nombre = Nombre.Text,
                    Practicas = new[]
                    {
                        double.Parse(practica1.Text),
                        double.Parse(practica2.Text),
                        double.Parse(practica3.Text)
                    },
                    Examenes = new[]
                    {
                        double.Parse(examen1.Text),
                        double.Parse(examen2.Text),
                        double.Parse(examen3.Text)
                    }
                };

                estudiante.CalcularCalificacionFinal();
                repositorio.GuardarEstudiante(estudiante);
                CargarEstudiantes();
                LimpiarCampos();

                MessageBox.Show("Estudiante guardado exitosamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar estudiante: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var matricula = dataGridView1.SelectedRows[0].Cells["Matricula"].Value.ToString();
                if (MessageBox.Show("¿Está seguro de eliminar este estudiante?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        repositorio.EliminarEstudiante(matricula);
                        CargarEstudiantes();
                        LimpiarCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar estudiante: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                Matricula.Text = row.Cells["Matricula"].Value?.ToString() ?? string.Empty;
                Nombre.Text = row.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                practica1.Text = row.Cells["Practica1"].Value?.ToString() ?? "0";
                practica2.Text = row.Cells["Practica2"].Value?.ToString() ?? "0";
                practica3.Text = row.Cells["Practica3"].Value?.ToString() ?? "0";
                examen1.Text = row.Cells["Examen1"].Value?.ToString() ?? "0";
                examen2.Text = row.Cells["Examen2"].Value?.ToString() ?? "0";
                examen3.Text = row.Cells["Examen3"].Value?.ToString() ?? "0";
            }
        }

        private void LimpiarCampos()
        {
            Matricula.Clear();
            Nombre.Clear();
            practica1.Text = "0";
            practica2.Text = "0";
            practica3.Text = "0";
            examen1.Text = "0";
            examen2.Text = "0";
            examen3.Text = "0";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                Matricula.Text = row.Cells["Matricula"].Value?.ToString() ?? string.Empty;
                Nombre.Text = row.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                practica1.Text = row.Cells["Practica1"].Value?.ToString() ?? "0";
                practica2.Text = row.Cells["Practica2"].Value?.ToString() ?? "0";
                practica3.Text = row.Cells["Practica3"].Value?.ToString() ?? "0";
                examen1.Text = row.Cells["Examen1"].Value?.ToString() ?? "0";
                examen2.Text = row.Cells["Examen2"].Value?.ToString() ?? "0";
                examen3.Text = row.Cells["Examen3"].Value?.ToString() ?? "0";
            }
        }
    }
}