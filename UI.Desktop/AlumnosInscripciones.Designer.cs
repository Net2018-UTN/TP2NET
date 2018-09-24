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
            this.tcAI = new System.Windows.Forms.ToolStripContainer();
            this.tlAI = new System.Windows.Forms.TableLayoutPanel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvAI = new System.Windows.Forms.DataGridView();
            this.tsAI = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tcAI.ContentPanel.SuspendLayout();
            this.tcAI.TopToolStripPanel.SuspendLayout();
            this.tcAI.SuspendLayout();
            this.tlAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAI)).BeginInit();
            this.tsAI.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAI
            // 
            // 
            // tcAI.ContentPanel
            // 
            this.tcAI.ContentPanel.Controls.Add(this.tlAI);
            this.tcAI.ContentPanel.Size = new System.Drawing.Size(434, 222);
            this.tcAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAI.Location = new System.Drawing.Point(0, 0);
            this.tcAI.Name = "tcAI";
            this.tcAI.Size = new System.Drawing.Size(434, 247);
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
            this.tlAI.Size = new System.Drawing.Size(434, 222);
            this.tlAI.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(3, 196);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(356, 196);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // dgvAI
            // 
            this.dgvAI.AllowUserToAddRows = false;
            this.dgvAI.AllowUserToDeleteRows = false;
            this.dgvAI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlAI.SetColumnSpan(this.dgvAI, 2);
            this.dgvAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAI.Location = new System.Drawing.Point(3, 3);
            this.dgvAI.Name = "dgvAI";
            this.dgvAI.ReadOnly = true;
            this.dgvAI.Size = new System.Drawing.Size(428, 187);
            this.dgvAI.TabIndex = 2;
            // 
            // tsAI
            // 
            this.tsAI.Dock = System.Windows.Forms.DockStyle.None;
            this.tsAI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.tsAI.Location = new System.Drawing.Point(3, 0);
            this.tsAI.Name = "tsAI";
            this.tsAI.Size = new System.Drawing.Size(81, 25);
            this.tsAI.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::UI.Desktop.Properties.Resources.agregar_icon;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "tsbNuevo";
            this.toolStripButton1.ToolTipText = "Nuevo";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::UI.Desktop.Properties.Resources.editar_icono;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "tsbEditar";
            this.toolStripButton2.ToolTipText = "Editar";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::UI.Desktop.Properties.Resources.images;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "tsbEliminar";
            this.toolStripButton3.ToolTipText = "Eliminar";
            // 
            // AlumnosInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 247);
            this.Controls.Add(this.tcAI);
            this.Name = "AlumnosInscripciones";
            this.Text = "Alumnos_Inscripciones";
            this.tcAI.ContentPanel.ResumeLayout(false);
            this.tcAI.TopToolStripPanel.ResumeLayout(false);
            this.tcAI.TopToolStripPanel.PerformLayout();
            this.tcAI.ResumeLayout(false);
            this.tcAI.PerformLayout();
            this.tlAI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAI)).EndInit();
            this.tsAI.ResumeLayout(false);
            this.tsAI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcAI;
        private System.Windows.Forms.TableLayoutPanel tlAI;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvAI;
        private System.Windows.Forms.ToolStrip tsAI;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}