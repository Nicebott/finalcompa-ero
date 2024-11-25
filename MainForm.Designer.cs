namespace INF512_FinalProject
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Guardar = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Matricula = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.practica1 = new System.Windows.Forms.TextBox();
            this.practica2 = new System.Windows.Forms.TextBox();
            this.practica3 = new System.Windows.Forms.TextBox();
            this.examen1 = new System.Windows.Forms.TextBox();
            this.examen2 = new System.Windows.Forms.TextBox();
            this.examen3 = new System.Windows.Forms.TextBox();
            this.labelPractica1 = new System.Windows.Forms.Label();
            this.labelPractica2 = new System.Windows.Forms.Label();
            this.labelPractica3 = new System.Windows.Forms.Label();
            this.labelExamen1 = new System.Windows.Forms.Label();
            this.labelExamen2 = new System.Windows.Forms.Label();
            this.labelExamen3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1 - Header
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Size = new System.Drawing.Size(1200, 60);
            this.panel1.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(20, 15);
            this.labelTitle.Size = new System.Drawing.Size(400, 30);
            this.labelTitle.Text = "Sistema de Reporte de Calificaciones";
            // 
            // groupBox1 - Datos Personales
            // 
            this.groupBox1.Text = "Datos del Estudiante";
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.Location = new System.Drawing.Point(20, 80);
            this.groupBox1.Size = new System.Drawing.Size(560, 100);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Matricula);
            // 
            // Nombre & Matrícula
            // 
            this.label1.Text = "Nombre:";
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Size = new System.Drawing.Size(70, 20);

            this.Nombre.Location = new System.Drawing.Point(100, 28);
            this.Nombre.Size = new System.Drawing.Size(200, 25);

            this.label2.Text = "Matrícula:";
            this.label2.Location = new System.Drawing.Point(320, 30);
            this.label2.Size = new System.Drawing.Size(70, 20);

            this.Matricula.Location = new System.Drawing.Point(400, 28);
            this.Matricula.Size = new System.Drawing.Size(140, 25);

            // groupBox2 - Prácticas
            // 
            this.groupBox2.Text = "Prácticas";
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox2.Location = new System.Drawing.Point(600, 80);
            this.groupBox2.Size = new System.Drawing.Size(280, 100);
            this.groupBox2.Controls.Add(this.labelPractica1);
            this.groupBox2.Controls.Add(this.practica1);
            this.groupBox2.Controls.Add(this.labelPractica2);
            this.groupBox2.Controls.Add(this.practica2);
            this.groupBox2.Controls.Add(this.labelPractica3);
            this.groupBox2.Controls.Add(this.practica3);

            // Prácticas Labels & TextBoxes
            this.labelPractica1.Text = "Práctica 1:";
            this.labelPractica1.Location = new System.Drawing.Point(20, 30);
            this.practica1.Location = new System.Drawing.Point(90, 28);
            this.practica1.Size = new System.Drawing.Size(60, 25);

            this.labelPractica2.Text = "Práctica 2:";
            this.labelPractica2.Location = new System.Drawing.Point(20, 60);
            this.practica2.Location = new System.Drawing.Point(90, 58);
            this.practica2.Size = new System.Drawing.Size(60, 25);

            this.labelPractica3.Text = "Práctica 3:";
            this.labelPractica3.Location = new System.Drawing.Point(160, 30);
            this.practica3.Location = new System.Drawing.Point(230, 28);
            this.practica3.Size = new System.Drawing.Size(60, 25);

            // groupBox3 - Exámenes
            // 
            this.groupBox3.Text = "Exámenes";
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox3.Location = new System.Drawing.Point(900, 80);
            this.groupBox3.Size = new System.Drawing.Size(280, 100);
            this.groupBox3.Controls.Add(this.labelExamen1);
            this.groupBox3.Controls.Add(this.examen1);
            this.groupBox3.Controls.Add(this.labelExamen2);
            this.groupBox3.Controls.Add(this.examen2);
            this.groupBox3.Controls.Add(this.labelExamen3);
            this.groupBox3.Controls.Add(this.examen3);

            // Exámenes Labels & TextBoxes
            this.labelExamen1.Text = "Examen 1:";
            this.labelExamen1.Location = new System.Drawing.Point(20, 30);
            this.examen1.Location = new System.Drawing.Point(90, 28);
            this.examen1.Size = new System.Drawing.Size(60, 25);

            this.labelExamen2.Text = "Examen 2:";
            this.labelExamen2.Location = new System.Drawing.Point(20, 60);
            this.examen2.Location = new System.Drawing.Point(90, 58);
            this.examen2.Size = new System.Drawing.Size(60, 25);

            this.labelExamen3.Text = "Examen 3:";
            this.labelExamen3.Location = new System.Drawing.Point(160, 30);
            this.examen3.Location = new System.Drawing.Point(230, 28);
            this.examen3.Size = new System.Drawing.Size(60, 25);

            // Buttons
            // 
            this.Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Guardar.ForeColor = System.Drawing.Color.White;
            this.Guardar.Location = new System.Drawing.Point(20, 200);
            this.Guardar.Size = new System.Drawing.Size(120, 35);
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;

            this.Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Editar.ForeColor = System.Drawing.Color.White;
            this.Editar.Location = new System.Drawing.Point(150, 200);
            this.Editar.Size = new System.Drawing.Size(120, 35);
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = false;

            this.Borrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Borrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Borrar.ForeColor = System.Drawing.Color.White;
            this.Borrar.Location = new System.Drawing.Point(280, 200);
            this.Borrar.Size = new System.Drawing.Size(120, 35);
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = false;

            // DataGridView
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(20, 250);
            this.dataGridView1.Size = new System.Drawing.Size(1160, 300);
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Reporte de Calificaciones";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Matricula;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox practica1;
        private System.Windows.Forms.TextBox practica2;
        private System.Windows.Forms.TextBox practica3;
        private System.Windows.Forms.TextBox examen1;
        private System.Windows.Forms.TextBox examen2;
        private System.Windows.Forms.TextBox examen3;
        private System.Windows.Forms.Label labelPractica1;
        private System.Windows.Forms.Label labelPractica2;
        private System.Windows.Forms.Label labelPractica3;
        private System.Windows.Forms.Label labelExamen1;
        private System.Windows.Forms.Label labelExamen2;
        private System.Windows.Forms.Label labelExamen3;
    }
}