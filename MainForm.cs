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
            CargarEstudiantes();
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Matricula",
                HeaderText = "Matrícula",
                DataPropertyName = "Matricula"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NotaFinal",
                HeaderText = "Nota Final",
                DataPropertyName = "NotaFinal"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Practica",
                HeaderText = "Práctica",
                DataPropertyName = "Practica"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cuaderno",
                HeaderText = "Cuaderno",
                DataPropertyName = "Cuaderno"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Asistencia",
                HeaderText = "Asistencia",
                DataPropertyName = "Asistencia"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Estatus",
                HeaderText = "Estatus",
                DataPropertyName = "Estatus"
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
                        estudiante.CalificacionFinal,
                        estudiante.Practicas?.FirstOrDefault() ?? 0,
                        estudiante.Examenes?.FirstOrDefault() ?? 0,
                        estudiante.Examenes?.LastOrDefault() ?? 0,
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
                    Examenes = new double[] {
                        double.Parse(textBox1.Text), 
                        double.Parse(Asistencia.Text) 
                    },
                    Practicas = new double[] {
                        double.Parse(Practica.Text),
                        double.Parse(Nota1.Text)
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
                    
                    CargarEstudiantes();
                }
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                Matricula.Text = row.Cells["Matricula"].Value.ToString();
                Nombre.Text = row.Cells["Nombre"].Value.ToString();
                Nota1.Text = row.Cells["NotaFinal"].Value.ToString();
                Practica.Text = row.Cells["Practica"].Value.ToString();
                textBox1.Text = row.Cells["Cuaderno"].Value.ToString();
                Asistencia.Text = row.Cells["Asistencia"].Value.ToString();
            }
        }

        private void LimpiarCampos()
        {
            Matricula.Clear();
            Nombre.Clear();
            Nota1.Clear();
            Practica.Clear();
            textBox1.Clear();
            Asistencia.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                Matricula.Text = row.Cells["Matricula"].Value?.ToString();
                Nombre.Text = row.Cells["Nombre"].Value?.ToString();
                Nota1.Text = row.Cells["NotaFinal"].Value?.ToString();
                Practica.Text = row.Cells["Practica"].Value?.ToString();
                textBox1.Text = row.Cells["Cuaderno"].Value?.ToString();
                Asistencia.Text = row.Cells["Asistencia"].Value?.ToString();
            }
        }
    }
}