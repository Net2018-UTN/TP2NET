namespace UI.Desktop
{
    partial class Especialidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Especialidad));
            this.tcEspecialidad = new System.Windows.Forms.ToolStripContainer();
            this.tlEspecialidad = new System.Windows.Forms.TableLayoutPanel();
            this.dgvEspecialidad = new System.Windows.Forms.DataGridView();
            this.Id_especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc_especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsEspecialidad = new System.Windows.Forms.ToolStrip();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tcEspecialidad.ContentPanel.SuspendLayout();
            this.tcEspecialidad.TopToolStripPanel.SuspendLayout();
            this.tcEspecialidad.SuspendLayout();
            this.tlEspecialidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidad)).BeginInit();
            this.tsEspecialidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcEspecialidad
            // 
            // 
            // tcEspecialidad.ContentPanel
            // 
            this.tcEspecialidad.ContentPanel.Controls.Add(this.tlEspecialidad);
            this.tcEspecialidad.ContentPanel.Size = new System.Drawing.Size(460, 282);
            this.tcEspecialidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcEspecialidad.Location = new System.Drawing.Point(0, 0);
            this.tcEspecialidad.Name = "tcEspecialidad";
            this.tcEspecialidad.Size = new System.Drawing.Size(460, 307);
            this.tcEspecialidad.TabIndex = 1;
            this.tcEspecialidad.Text = "toolStripContainer1";
            // 
            // tcEspecialidad.TopToolStripPanel
            // 
            this.tcEspecialidad.TopToolStripPanel.Controls.Add(this.tsEspecialidad);
            // 
            // tlEspecialidad
            // 
            this.tlEspecialidad.ColumnCount = 2;
            this.tlEspecialidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlEspecialidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlEspecialidad.Controls.Add(this.dgvEspecialidad, 0, 0);
            this.tlEspecialidad.Controls.Add(this.btnActualizar, 0, 1);
            this.tlEspecialidad.Controls.Add(this.btnSalir, 1, 1);
            this.tlEspecialidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlEspecialidad.Location = new System.Drawing.Point(0, 0);
            this.tlEspecialidad.Name = "tlEspecialidad";
            this.tlEspecialidad.RowCount = 2;
            this.tlEspecialidad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlEspecialidad.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlEspecialidad.Size = new System.Drawing.Size(460, 282);
            this.tlEspecialidad.TabIndex = 1;
            // 
            // dgvEspecialidad
            // 
            this.dgvEspecialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_especialidad,
            this.Desc_especialidad});
            this.tlEspecialidad.SetColumnSpan(this.dgvEspecialidad, 2);
            this.dgvEspecialidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEspecialidad.Location = new System.Drawing.Point(3, 3);
            this.dgvEspecialidad.Name = "dgvEspecialidad";
            this.dgvEspecialidad.Size = new System.Drawing.Size(454, 247);
            this.dgvEspecialidad.TabIndex = 1;
            // 
            // Id_especialidad
            // 
            this.Id_especialidad.HeaderText = "Id";
            this.Id_especialidad.Name = "Id_especialidad";
            // 
            // Desc_especialidad
            // 
            this.Desc_especialidad.HeaderText = "Desc";
            this.Desc_especialidad.Name = "Desc_especialidad";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(3, 256);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(382, 256);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // tsEspecialidad
            // 
            this.tsEspecialidad.Dock = System.Windows.Forms.DockStyle.None;
            this.tsEspecialidad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsEspecialidad.Location = new System.Drawing.Point(3, 0);
            this.tsEspecialidad.Name = "tsEspecialidad";
            this.tsEspecialidad.Size = new System.Drawing.Size(112, 25);
            this.tsEspecialidad.TabIndex = 0;
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "toolStripButton1";
            this.tsbEliminar.ToolTipText = "Eliminar";
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "toolStripButton1";
            this.tsbEditar.ToolTipText = "Editar";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "Nuevo";
            // 
            // Especialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 307);
            this.Controls.Add(this.tcEspecialidad);
            this.Name = "Especialidad";
            this.Text = "Especialidad";
            this.Load += new System.EventHandler(this.Especialidad_Load);
            this.tcEspecialidad.ContentPanel.ResumeLayout(false);
            this.tcEspecialidad.TopToolStripPanel.ResumeLayout(false);
            this.tcEspecialidad.TopToolStripPanel.PerformLayout();
            this.tcEspecialidad.ResumeLayout(false);
            this.tcEspecialidad.PerformLayout();
            this.tlEspecialidad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidad)).EndInit();
            this.tsEspecialidad.ResumeLayout(false);
            this.tsEspecialidad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcEspecialidad;
        private System.Windows.Forms.TableLayoutPanel tlEspecialidad;
        private System.Windows.Forms.DataGridView dgvEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_especialidad;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsEspecialidad;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
    }
}