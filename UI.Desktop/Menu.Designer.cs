namespace UI.Desktop
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReporteDocentes = new System.Windows.Forms.Button();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnDocentesCursos = new System.Windows.Forms.Button();
            this.btnAlumnosInscripciones = new System.Windows.Forms.Button();
            this.btnEspecialidades = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnPlanes = new System.Windows.Forms.Button();
            this.btnComisiones = new System.Windows.Forms.Button();
            this.btnMaterias = new System.Windows.Forms.Button();
            this.btnCursos = new System.Windows.Forms.Button();
            this.btnPersonas = new System.Windows.Forms.Button();
            this.mnuPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuArchivo
            // 
            this.mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir});
            this.mnuArchivo.Name = "mnuArchivo";
            this.mnuArchivo.Size = new System.Drawing.Size(60, 20);
            this.mnuArchivo.Text = "Archivo";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(96, 22);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReporteDocentes);
            this.panel1.Controls.Add(this.lblBienvenido);
            this.panel1.Controls.Add(this.btnDocentesCursos);
            this.panel1.Controls.Add(this.btnAlumnosInscripciones);
            this.panel1.Controls.Add(this.btnEspecialidades);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnPlanes);
            this.panel1.Controls.Add(this.btnComisiones);
            this.panel1.Controls.Add(this.btnMaterias);
            this.panel1.Controls.Add(this.btnCursos);
            this.panel1.Controls.Add(this.btnPersonas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 471);
            this.panel1.TabIndex = 6;
            // 
            // btnReporteDocentes
            // 
            this.btnReporteDocentes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReporteDocentes.Location = new System.Drawing.Point(317, 422);
            this.btnReporteDocentes.Name = "btnReporteDocentes";
            this.btnReporteDocentes.Size = new System.Drawing.Size(144, 23);
            this.btnReporteDocentes.TabIndex = 13;
            this.btnReporteDocentes.Text = "Reporte Docentes";
            this.btnReporteDocentes.UseVisualStyleBackColor = true;
            this.btnReporteDocentes.Click += new System.EventHandler(this.btnReporteDocentes_Click);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(265, 43);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(237, 25);
            this.lblBienvenido.TabIndex = 12;
            this.lblBienvenido.Text = "¡Bienvenido al Sistema!";
            // 
            // btnDocentesCursos
            // 
            this.btnDocentesCursos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDocentesCursos.Location = new System.Drawing.Point(317, 335);
            this.btnDocentesCursos.Name = "btnDocentesCursos";
            this.btnDocentesCursos.Size = new System.Drawing.Size(144, 23);
            this.btnDocentesCursos.TabIndex = 11;
            this.btnDocentesCursos.Text = "Docentes de Cursos";
            this.btnDocentesCursos.UseVisualStyleBackColor = true;
            this.btnDocentesCursos.Click += new System.EventHandler(this.btnDocentesCursos_Click);
            // 
            // btnAlumnosInscripciones
            // 
            this.btnAlumnosInscripciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAlumnosInscripciones.Location = new System.Drawing.Point(317, 306);
            this.btnAlumnosInscripciones.Name = "btnAlumnosInscripciones";
            this.btnAlumnosInscripciones.Size = new System.Drawing.Size(144, 23);
            this.btnAlumnosInscripciones.TabIndex = 10;
            this.btnAlumnosInscripciones.Text = "Inscripciones de Alumnos";
            this.btnAlumnosInscripciones.UseVisualStyleBackColor = true;
            this.btnAlumnosInscripciones.Click += new System.EventHandler(this.btnAlumnosInscripciones_Click);
            // 
            // btnEspecialidades
            // 
            this.btnEspecialidades.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEspecialidades.Location = new System.Drawing.Point(317, 219);
            this.btnEspecialidades.Name = "btnEspecialidades";
            this.btnEspecialidades.Size = new System.Drawing.Size(144, 23);
            this.btnEspecialidades.TabIndex = 7;
            this.btnEspecialidades.Text = "Especialidades";
            this.btnEspecialidades.UseVisualStyleBackColor = true;
            this.btnEspecialidades.Click += new System.EventHandler(this.btnEspecialidades_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUsuarios.Location = new System.Drawing.Point(317, 132);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(144, 23);
            this.btnUsuarios.TabIndex = 6;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnPlanes
            // 
            this.btnPlanes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPlanes.Location = new System.Drawing.Point(317, 161);
            this.btnPlanes.Name = "btnPlanes";
            this.btnPlanes.Size = new System.Drawing.Size(144, 23);
            this.btnPlanes.TabIndex = 5;
            this.btnPlanes.Text = "Planes";
            this.btnPlanes.UseVisualStyleBackColor = true;
            this.btnPlanes.Click += new System.EventHandler(this.btnPlanes_Click);
            // 
            // btnComisiones
            // 
            this.btnComisiones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnComisiones.Location = new System.Drawing.Point(317, 248);
            this.btnComisiones.Name = "btnComisiones";
            this.btnComisiones.Size = new System.Drawing.Size(144, 23);
            this.btnComisiones.TabIndex = 4;
            this.btnComisiones.Text = "Comisiones";
            this.btnComisiones.UseVisualStyleBackColor = true;
            this.btnComisiones.Click += new System.EventHandler(this.btnComisiones_Click);
            // 
            // btnMaterias
            // 
            this.btnMaterias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMaterias.Location = new System.Drawing.Point(317, 277);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Size = new System.Drawing.Size(144, 23);
            this.btnMaterias.TabIndex = 3;
            this.btnMaterias.Text = "Materias";
            this.btnMaterias.UseVisualStyleBackColor = true;
            this.btnMaterias.Click += new System.EventHandler(this.btnMaterias_Click);
            // 
            // btnCursos
            // 
            this.btnCursos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCursos.Location = new System.Drawing.Point(317, 190);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(144, 23);
            this.btnCursos.TabIndex = 2;
            this.btnCursos.Text = "Cursos";
            this.btnCursos.UseVisualStyleBackColor = true;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // btnPersonas
            // 
            this.btnPersonas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPersonas.Location = new System.Drawing.Point(317, 103);
            this.btnPersonas.Name = "btnPersonas";
            this.btnPersonas.Size = new System.Drawing.Size(144, 23);
            this.btnPersonas.TabIndex = 1;
            this.btnPersonas.Text = "Personas";
            this.btnPersonas.UseVisualStyleBackColor = true;
            this.btnPersonas.Click += new System.EventHandler(this.btnPersonas_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "Menu";
            this.Text = "Academia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Menu_Shown);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMaterias;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Button btnPersonas;
        private System.Windows.Forms.Button btnDocentesCursos;
        private System.Windows.Forms.Button btnAlumnosInscripciones;
        private System.Windows.Forms.Button btnEspecialidades;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnPlanes;
        private System.Windows.Forms.Button btnComisiones;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnReporteDocentes;
    }
}