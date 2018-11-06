namespace UI.Desktop
{
    partial class AlumnosInscripciones
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
            this.components = new System.ComponentModel.Container();
            this.tcAI = new System.Windows.Forms.ToolStripContainer();
            this.tlAI = new System.Windows.Forms.TableLayoutPanel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvAI = new System.Windows.Forms.DataGridView();
            this.tsAI = new System.Windows.Forms.ToolStrip();
            this.stbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnosInscripcionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcAI.ContentPanel.SuspendLayout();
            this.tcAI.TopToolStripPanel.SuspendLayout();
            this.tcAI.SuspendLayout();
            this.tlAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAI)).BeginInit();
            this.tsAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosInscripcionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tcAI
            // 
            // 
            // tcAI.ContentPanel
            // 
            this.tcAI.ContentPanel.Controls.Add(this.tlAI);
            this.tcAI.ContentPanel.Size = new System.Drawing.Size(651, 231);
            this.tcAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAI.Location = new System.Drawing.Point(0, 0);
            this.tcAI.Name = "tcAI";
            this.tcAI.Size = new System.Drawing.Size(651, 256);
            this.tcAI.TabIndex = 0;
            this.tcAI.Text = "toolStripContainer1";
            // 
            // tcAI.TopToolStripPanel
            // 
            this.tcAI.TopToolStripPanel.Controls.Add(this.tsAI);
            // 
            // tlAI
            // 
            this.tlAI.ColumnCount = 2;
            this.tlAI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlAI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlAI.Controls.Add(this.btnActualizar, 0, 1);
            this.tlAI.Controls.Add(this.btnSalir, 1, 1);
            this.tlAI.Controls.Add(this.dgvAI, 0, 0);
            this.tlAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlAI.Location = new System.Drawing.Point(0, 0);
            this.tlAI.Name = "tlAI";
            this.tlAI.RowCount = 2;
            this.tlAI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlAI.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlAI.Size = new System.Drawing.Size(651, 231);
            this.tlAI.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(3, 205);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(573, 205);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvAI
            // 
            this.dgvAI.AllowUserToAddRows = false;
            this.dgvAI.AllowUserToDeleteRows = false;
            this.dgvAI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.alumnos,
            this.curso,
            this.condicion,
            this.nota});
            this.tlAI.SetColumnSpan(this.dgvAI, 2);
            this.dgvAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAI.Location = new System.Drawing.Point(3, 3);
            this.dgvAI.Name = "dgvAI";
            this.dgvAI.ReadOnly = true;
            this.dgvAI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAI.Size = new System.Drawing.Size(645, 196);
            this.dgvAI.TabIndex = 2;
            // 
            // tsAI
            // 
            this.tsAI.Dock = System.Windows.Forms.DockStyle.None;
            this.tsAI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsAI.Location = new System.Drawing.Point(3, 0);
            this.tsAI.Name = "tsAI";
            this.tsAI.Size = new System.Drawing.Size(81, 25);
            this.tsAI.TabIndex = 0;
            // 
            // stbNuevo
            // 
            this.stbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stbNuevo.Image = global::UI.Desktop.Properties.Resources.agregar_icon;
            this.stbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbNuevo.Name = "stbNuevo";
            this.stbNuevo.Size = new System.Drawing.Size(23, 22);
            this.stbNuevo.Text = "tsbNuevo";
            this.stbNuevo.ToolTipText = "Nuevo";
            this.stbNuevo.Click += new System.EventHandler(this.stbNuevo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = global::UI.Desktop.Properties.Resources.editar_icono;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "tsbEditar";
            this.tsbEditar.ToolTipText = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = global::UI.Desktop.Properties.Resources.images;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "tsbEliminar";
            this.tsbEliminar.ToolTipText = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // alumnos
            // 
            this.alumnos.DataPropertyName = "IdAlumno";
            this.alumnos.HeaderText = "Alumno";
            this.alumnos.Name = "alumnos";
            this.alumnos.ReadOnly = true;
            // 
            // curso
            // 
            this.curso.DataPropertyName = "IdCurso";
            this.curso.HeaderText = "Curso";
            this.curso.Name = "curso";
            this.curso.ReadOnly = true;
            // 
            // condicion
            // 
            this.condicion.DataPropertyName = "Condicion";
            this.condicion.HeaderText = "Condicion";
            this.condicion.Name = "condicion";
            this.condicion.ReadOnly = true;
            // 
            // nota
            // 
            this.nota.DataPropertyName = "Nota";
            this.nota.HeaderText = "Nota";
            this.nota.Name = "nota";
            this.nota.ReadOnly = true;
            // 
            // alumnosInscripcionesBindingSource
            // 
            this.alumnosInscripcionesBindingSource.DataSource = typeof(Entidades.AlumnosInscripciones);
            // 
            // AlumnosInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 256);
            this.Controls.Add(this.tcAI);
            this.Name = "AlumnosInscripciones";
            this.Text = "Inscripciones";
            this.Load += new System.EventHandler(this.AlumnosInscripciones_Load);
            this.tcAI.ContentPanel.ResumeLayout(false);
            this.tcAI.TopToolStripPanel.ResumeLayout(false);
            this.tcAI.TopToolStripPanel.PerformLayout();
            this.tcAI.ResumeLayout(false);
            this.tcAI.PerformLayout();
            this.tlAI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAI)).EndInit();
            this.tsAI.ResumeLayout(false);
            this.tsAI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosInscripcionesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcAI;
        private System.Windows.Forms.TableLayoutPanel tlAI;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvAI;
        private System.Windows.Forms.ToolStrip tsAI;
        private System.Windows.Forms.ToolStripButton stbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.BindingSource alumnosInscripcionesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
    }
}