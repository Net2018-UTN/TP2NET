namespace UI.Desktop
{
    partial class VistaMateriasDocente
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
            this.tlpVistaMaterias = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMateriasDocente = new System.Windows.Forms.DataGridView();
            this.IDCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tlpVistaMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasDocente)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpVistaMaterias
            // 
            this.tlpVistaMaterias.AutoSize = true;
            this.tlpVistaMaterias.ColumnCount = 1;
            this.tlpVistaMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpVistaMaterias.Controls.Add(this.dgvMateriasDocente, 0, 0);
            this.tlpVistaMaterias.Controls.Add(this.btnSalir, 0, 1);
            this.tlpVistaMaterias.Location = new System.Drawing.Point(0, 0);
            this.tlpVistaMaterias.Name = "tlpVistaMaterias";
            this.tlpVistaMaterias.RowCount = 2;
            this.tlpVistaMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.9621F));
            this.tlpVistaMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.037901F));
            this.tlpVistaMaterias.Size = new System.Drawing.Size(843, 343);
            this.tlpVistaMaterias.TabIndex = 0;
            // 
            // dgvMateriasDocente
            // 
            this.dgvMateriasDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriasDocente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCurso,
            this.IdDocente,
            this.IdMateria,
            this.IdComision,
            this.DescMateria,
            this.DescCurso,
            this.DescComision,
            this.TipoCargo});
            this.dgvMateriasDocente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMateriasDocente.Location = new System.Drawing.Point(3, 3);
            this.dgvMateriasDocente.Name = "dgvMateriasDocente";
            this.dgvMateriasDocente.Size = new System.Drawing.Size(837, 305);
            this.dgvMateriasDocente.TabIndex = 1;
            // 
            // IDCurso
            // 
            this.IDCurso.DataPropertyName = "IdCurso";
            this.IDCurso.HeaderText = "ID Curso";
            this.IDCurso.Name = "IDCurso";
            this.IDCurso.ReadOnly = true;
            // 
            // IdDocente
            // 
            this.IdDocente.DataPropertyName = "IdDocente";
            this.IdDocente.HeaderText = "ID Docente";
            this.IdDocente.Name = "IdDocente";
            this.IdDocente.ReadOnly = true;
            // 
            // IdMateria
            // 
            this.IdMateria.DataPropertyName = "IdMateria";
            this.IdMateria.HeaderText = "ID Materia";
            this.IdMateria.Name = "IdMateria";
            this.IdMateria.ReadOnly = true;
            // 
            // IdComision
            // 
            this.IdComision.DataPropertyName = "IdComision";
            this.IdComision.HeaderText = "ID Comision";
            this.IdComision.Name = "IdComision";
            this.IdComision.ReadOnly = true;
            // 
            // DescMateria
            // 
            this.DescMateria.DataPropertyName = "DescripcionMateria";
            this.DescMateria.HeaderText = "Descripcion Materia";
            this.DescMateria.Name = "DescMateria";
            this.DescMateria.ReadOnly = true;
            // 
            // DescCurso
            // 
            this.DescCurso.DataPropertyName = "DescripcionCurso";
            this.DescCurso.HeaderText = "Descripcion Curso";
            this.DescCurso.Name = "DescCurso";
            this.DescCurso.ReadOnly = true;
            // 
            // DescComision
            // 
            this.DescComision.DataPropertyName = "DescripcionComision";
            this.DescComision.HeaderText = "Descripcion Comision";
            this.DescComision.Name = "DescComision";
            this.DescComision.ReadOnly = true;
            // 
            // TipoCargo
            // 
            this.TipoCargo.DataPropertyName = "Cargo";
            this.TipoCargo.HeaderText = "Tipo de Cargo";
            this.TipoCargo.Name = "TipoCargo";
            this.TipoCargo.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSalir.Location = new System.Drawing.Point(765, 315);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // VistaMateriasDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(933, 404);
            this.Controls.Add(this.tlpVistaMaterias);
            this.Name = "VistaMateriasDocente";
            this.Text = "VistaMateriasDocente";
            this.Load += new System.EventHandler(this.VistaMateriasDocente_Load_1);
            this.tlpVistaMaterias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasDocente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpVistaMaterias;
        private System.Windows.Forms.DataGridView dgvMateriasDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCargo;
        private System.Windows.Forms.Button btnSalir;

    }
}