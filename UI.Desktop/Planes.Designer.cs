using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace UI.Desktop
{
    partial class Planes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Planes));
            this.tcPLanes = new System.Windows.Forms.ToolStripContainer();
            this.tlPLanes = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPlanes = new System.Windows.Forms.DataGridView();
            this.idPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planesLogicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsPlanes = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.businessLogicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcPLanes.ContentPanel.SuspendLayout();
            this.tcPLanes.TopToolStripPanel.SuspendLayout();
            this.tcPLanes.SuspendLayout();
            this.tlPLanes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesLogicBindingSource)).BeginInit();
            this.tsPlanes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.businessLogicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPLanes
            // 
            // 
            // tcPLanes.ContentPanel
            // 
            this.tcPLanes.ContentPanel.Controls.Add(this.tlPLanes);
            this.tcPLanes.ContentPanel.Size = new System.Drawing.Size(528, 282);
            this.tcPLanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPLanes.Location = new System.Drawing.Point(0, 0);
            this.tcPLanes.Name = "tcPLanes";
            this.tcPLanes.Size = new System.Drawing.Size(528, 307);
            this.tcPLanes.TabIndex = 0;
            this.tcPLanes.Text = "toolStripContainer1";
            // 
            // tcPLanes.TopToolStripPanel
            // 
            this.tcPLanes.TopToolStripPanel.Controls.Add(this.tsPlanes);
            // 
            // tlPLanes
            // 
            this.tlPLanes.ColumnCount = 2;
            this.tlPLanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPLanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPLanes.Controls.Add(this.dgvPlanes, 0, 0);
            this.tlPLanes.Controls.Add(this.btnActualizar, 0, 1);
            this.tlPLanes.Controls.Add(this.btnSalir, 1, 1);
            this.tlPLanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPLanes.Location = new System.Drawing.Point(0, 0);
            this.tlPLanes.Name = "tlPLanes";
            this.tlPLanes.RowCount = 2;
            this.tlPLanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPLanes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPLanes.Size = new System.Drawing.Size(528, 282);
            this.tlPLanes.TabIndex = 0;
            // 
            // dgvPlanes
            // 
            this.dgvPlanes.AllowUserToAddRows = false;
            this.dgvPlanes.AllowUserToDeleteRows = false;
            this.dgvPlanes.AutoGenerateColumns = false;
            this.dgvPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPlan,
            this.descPlan,
            this.idEspecialidad});
            this.tlPLanes.SetColumnSpan(this.dgvPlanes, 2);
            this.dgvPlanes.DataSource = this.planesLogicBindingSource;
            this.dgvPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlanes.Location = new System.Drawing.Point(3, 3);
            this.dgvPlanes.MultiSelect = false;
            this.dgvPlanes.Name = "dgvPlanes";
            this.dgvPlanes.ReadOnly = true;
            this.dgvPlanes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanes.Size = new System.Drawing.Size(522, 247);
            this.dgvPlanes.TabIndex = 0;
            this.dgvPlanes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanes_CellContentClick);
            // 
            // idPlan
            // 
            this.idPlan.DataPropertyName = "id";
            this.idPlan.HeaderText = "Id Plan";
            this.idPlan.Name = "idPlan";
            this.idPlan.ReadOnly = true;
            this.idPlan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // descPlan
            // 
            this.descPlan.DataPropertyName = "descPlan";
            this.descPlan.HeaderText = "Descripcion";
            this.descPlan.Name = "descPlan";
            this.descPlan.ReadOnly = true;
            this.descPlan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // idEspecialidad
            // 
            this.idEspecialidad.DataPropertyName = "idEspecialidad";
            this.idEspecialidad.HeaderText = "Especialidad";
            this.idEspecialidad.Name = "idEspecialidad";
            this.idEspecialidad.ReadOnly = true;
            this.idEspecialidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // planesLogicBindingSource
            // 
            this.planesLogicBindingSource.DataSource = typeof(Negocio.PlanesLogic);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(369, 256);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(450, 256);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsPlanes
            // 
            this.tsPlanes.Dock = System.Windows.Forms.DockStyle.None;
            this.tsPlanes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsPlanes.Location = new System.Drawing.Point(5, 0);
            this.tsPlanes.Name = "tsPlanes";
            this.tsPlanes.Size = new System.Drawing.Size(81, 25);
            this.tsPlanes.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "toolStripButton1";
            this.tsbNuevo.ToolTipText = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // businessLogicBindingSource
            // 
            this.businessLogicBindingSource.DataSource = typeof(Negocio.BusinessLogic);
            // 
            // Planes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 307);
            this.Controls.Add(this.tcPLanes);
            this.Name = "Planes";
            this.Text = "Planes";
            this.Load += new System.EventHandler(this.Planes_Load);
            this.tcPLanes.ContentPanel.ResumeLayout(false);
            this.tcPLanes.TopToolStripPanel.ResumeLayout(false);
            this.tcPLanes.TopToolStripPanel.PerformLayout();
            this.tcPLanes.ResumeLayout(false);
            this.tcPLanes.PerformLayout();
            this.tlPLanes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesLogicBindingSource)).EndInit();
            this.tsPlanes.ResumeLayout(false);
            this.tsPlanes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.businessLogicBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcPLanes;
        private System.Windows.Forms.TableLayoutPanel tlPLanes;
        private System.Windows.Forms.DataGridView dgvPlanes;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsPlanes;
        private System.Windows.Forms.BindingSource planesLogicBindingSource;
        private System.Windows.Forms.BindingSource businessLogicBindingSource;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn descPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEspecialidad;
    }
}