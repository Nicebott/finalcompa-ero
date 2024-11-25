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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Guardar = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nota1 = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Matricula = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Practica = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Asistencia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 
            // 
            this.Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Guardar.FlatAppearance.BorderSize = 0;
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Guardar.ForeColor = System.Drawing.Color.White;
            this.Guardar.Location = new System.Drawing.Point(843, 31);
            this.Guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(160, 43);
            this.Guardar.TabIndex = 0;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // 
            // 
            this.Borrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Borrar.FlatAppearance.BorderSize = 0;
            this.Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Borrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Borrar.ForeColor = System.Drawing.Color.White;
            this.Borrar.Location = new System.Drawing.Point(843, 485);
            this.Borrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(160, 43);
            this.Borrar.TabIndex = 1;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = false;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // 
            // 
            this.Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Editar.FlatAppearance.BorderSize = 0;
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Editar.ForeColor = System.Drawing.Color.White;
            this.Editar.Location = new System.Drawing.Point(675, 485);
            this.Editar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(160, 43);
            this.Editar.TabIndex = 2;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = false;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // 
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // 
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(321, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Matrícula";
            // 
            // 
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(20, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nota Final";
            // 
            // 
            // 
            this.Nota1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nota1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Nota1.Location = new System.Drawing.Point(112, 65);
            this.Nota1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nota1.Name = "Nota1";
            this.Nota1.Size = new System.Drawing.Size(79, 27);
            this.Nota1.TabIndex = 8;
            // 
            // 
            // 
            this.Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Nombre.Location = new System.Drawing.Point(96, 28);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(213, 27);
            this.Nombre.TabIndex = 11;
            // 
            // 
            // 
            this.Matricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Matricula.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Matricula.Location = new System.Drawing.Point(405, 28);
            this.Matricula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Matricula.Name = "Matricula";
            this.Matricula.Size = new System.Drawing.Size(159, 27);
            this.Matricula.TabIndex = 12;
            // 
            // 
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // 
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(16, 186);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 292);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            //
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(200, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Práctica";
            // 
            // 
            // 
            this.Practica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Practica.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Practica.Location = new System.Drawing.Point(275, 65);
            this.Practica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Practica.Name = "Practica";
            this.Practica.Size = new System.Drawing.Size(79, 27);
            this.Practica.TabIndex = 16;
            // 
            // 
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(363, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cuaderno";
            // 
            // 
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.Location = new System.Drawing.Point(449, 65);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 27);
            this.textBox1.TabIndex = 18;
            // 
            // 
            // 
            this.Asistencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Asistencia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Asistencia.Location = new System.Drawing.Point(624, 65);
            this.Asistencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Asistencia.Name = "Asistencia";
            this.Asistencia.Size = new System.Drawing.Size(79, 27);
            this.Asistencia.TabIndex = 20;
            // 
            // 
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(537, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Asistencia";
            // 
            // 
            // 
            this.groupBox1.Controls.Add(this.Asistencia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Practica);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Nota1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Matricula);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Guardar);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.Location = new System.Drawing.Point(16, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1035, 98);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Estudiante";
            // 
            // 
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 62);
            this.panel1.TabIndex = 22;
            // 
            //
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(9, 9);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(308, 37);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Gestión de Estudiantes";
           
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Borrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión Académica";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nota1;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Matricula;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Practica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Asistencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitle;
    }
}