namespace UI.Desktop
{
    partial class Materia
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
            this.tcMateria = new System.Windows.Forms.ToolStripContainer();
            this.tsMateria = new System.Windows.Forms.ToolStrip();
            this.tlMateria = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMateria = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsSemanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcMateria.ContentPanel.SuspendLayout();
            this.tcMateria.TopToolStripPanel.SuspendLayout();
            this.tcMateria.SuspendLayout();
            this.tsMateria.SuspendLayout();
            this.tlMateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMateria
            // 
            // 
            // tcMateria.ContentPanel
            // 
            this.tcMateria.ContentPanel.Controls.Add(this.tlMateria);
            this.tcMateria.ContentPanel.Size = new System.Drawing.Size(669, 293);
            this.tcMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMateria.Location = new System.Drawing.Point(0, 0);
            this.tcMateria.Name = "tcMateria";
            this.tcMateria.Size = new System.Drawing.Size(669, 318);
            this.tcMateria.TabIndex = 0;
            this.tcMateria.Text = "toolStripContainer1";
            // 
            // tcMateria.TopToolStripPanel
            // 
            this.tcMateria.TopToolStripPanel.Controls.Add(this.tsMateria);
            // 
            // tsMateria
            // 
            this.tsMateria.Dock = System.Windows.Forms.DockStyle.None;
            this.tsMateria.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsMateria.Location = new System.Drawing.Point(3, 0);
            this.tsMateria.Name = "tsMateria";
            this.tsMateria.Size = new System.Drawing.Size(81, 25);
            this.tsMateria.TabIndex = 0;
            // 
            // tlMateria
            // 
            this.tlMateria.ColumnCount = 2;
            this.tlMateria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlMateria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlMateria.Controls.Add(this.dgvMateria, 0, 0);
            this.tlMateria.Controls.Add(this.btnActualizar, 0, 1);
            this.tlMateria.Controls.Add(this.btnCancelar, 1, 1);
            this.tlMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlMateria.Location = new System.Drawing.Point(0, 0);
            this.tlMateria.Name = "tlMateria";
            this.tlMateria.RowCount = 2;
            this.tlMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlMateria.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMateria.Size = new System.Drawing.Size(669, 293);
            this.tlMateria.TabIndex = 0;
            // 
            // dgvMateria
            // 
            this.dgvMateria.AllowUserToAddRows = false;
            this.dgvMateria.AllowUserToDeleteRows = false;
            this.dgvMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descMateria,
            this.hsSemanales,
            this.hsTotales});
            this.tlMateria.SetColumnSpan(this.dgvMateria, 2);
            this.dgvMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMateria.Location = new System.Drawing.Point(3, 3);
            this.dgvMateria.Name = "dgvMateria";
            this.dgvMateria.ReadOnly = true;
            this.dgvMateria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMateria.Size = new System.Drawing.Size(663, 258);
            this.dgvMateria.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(510, 267);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(591, 267);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = global::UI.Desktop.Properties.Resources.agregar_icon;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "toolStripButton1";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = global::UI.Desktop.Properties.Resources.editar_icono;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = global::UI.Desktop.Properties.Resources.images;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // descMateria
            // 
            this.descMateria.DataPropertyName = "descMateria";
            this.descMateria.HeaderText = "Descripcion";
            this.descMateria.Name = "descMateria";
            this.descMateria.ReadOnly = true;
            // 
            // hsSemanales
            // 
            this.hsSemanales.DataPropertyName = "hsSemanales";
            this.hsSemanales.HeaderText = "Horas Semanales";
            this.hsSemanales.Name = "hsSemanales";
            this.hsSemanales.ReadOnly = true;
            // 
            // hsTotales
            // 
            this.hsTotales.DataPropertyName = "hsTotales";
            this.hsTotales.HeaderText = "Horas totales";
            this.hsTotales.Name = "hsTotales";
            this.hsTotales.ReadOnly = true;
            // 
            // Materia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 318);
            this.Controls.Add(this.tcMateria);
            this.Name = "Materia";
            this.Text = "Materia";
            this.Load += new System.EventHandler(this.Materia_Load);
            this.tcMateria.ContentPanel.ResumeLayout(false);
            this.tcMateria.TopToolStripPanel.ResumeLayout(false);
            this.tcMateria.TopToolStripPanel.PerformLayout();
            this.tcMateria.ResumeLayout(false);
            this.tcMateria.PerformLayout();
            this.tsMateria.ResumeLayout(false);
            this.tsMateria.PerformLayout();
            this.tlMateria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcMateria;
        private System.Windows.Forms.TableLayoutPanel tlMateria;
        private System.Windows.Forms.DataGridView dgvMateria;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolStrip tsMateria;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsSemanales;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsTotales;
    }
}