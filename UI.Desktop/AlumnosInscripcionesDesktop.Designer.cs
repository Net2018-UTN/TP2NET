namespace UI.Desktop
{
    partial class AlumnosInscripcionesDesktop
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
            this.tlAI = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdIns = new System.Windows.Forms.TextBox();
            this.txtCond = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAlumno = new System.Windows.Forms.ComboBox();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tlAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tlAI
            // 
            this.tlAI.ColumnCount = 4;
            this.tlAI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlAI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlAI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlAI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlAI.Controls.Add(this.btnCancelar, 3, 3);
            this.tlAI.Controls.Add(this.label1, 0, 0);
            this.tlAI.Controls.Add(this.label4, 2, 0);
            this.tlAI.Controls.Add(this.txtIdIns, 1, 0);
            this.tlAI.Controls.Add(this.txtCond, 3, 0);
            this.tlAI.Controls.Add(this.btnAceptar, 2, 3);
            this.tlAI.Controls.Add(this.label3, 0, 1);
            this.tlAI.Controls.Add(this.label2, 0, 2);
            this.tlAI.Controls.Add(this.cbAlumno, 1, 1);
            this.tlAI.Controls.Add(this.cbCurso, 1, 2);
            this.tlAI.Controls.Add(this.lblNota, 2, 1);
            this.tlAI.Controls.Add(this.txtNota, 3, 1);
            this.tlAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlAI.Location = new System.Drawing.Point(0, 0);
            this.tlAI.Name = "tlAI";
            this.tlAI.RowCount = 4;
            this.tlAI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlAI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlAI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlAI.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlAI.Size = new System.Drawing.Size(444, 220);
            this.tlAI.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(303, 193);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id Inscripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Condicion";
            // 
            // txtIdIns
            // 
            this.txtIdIns.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.txtIdIns.Location = new System.Drawing.Point(79, 3);
            this.txtIdIns.Name = "txtIdIns";
            this.txtIdIns.ReadOnly = true;
            this.txtIdIns.Size = new System.Drawing.Size(100, 20);
            this.txtIdIns.TabIndex = 7;
            // 
            // txtCond
            // 
            this.txtCond.Location = new System.Drawing.Point(303, 3);
            this.txtCond.Name = "txtCond";
            this.txtCond.Size = new System.Drawing.Size(100, 20);
            this.txtCond.TabIndex = 10;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(222, 193);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id Alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id Curso";
            // 
            // cbAlumno
            // 
            this.cbAlumno.DataSource = this.personaBindingSource;
            this.cbAlumno.DisplayMember = "Legajo";
            this.cbAlumno.FormattingEnabled = true;
            this.cbAlumno.Location = new System.Drawing.Point(79, 66);
            this.cbAlumno.Name = "cbAlumno";
            this.cbAlumno.Size = new System.Drawing.Size(121, 21);
            this.cbAlumno.TabIndex = 12;
            this.cbAlumno.ValueMember = "Id";
            // 
            // cbCurso
            // 
            this.cbCurso.DataSource = this.cursoBindingSource;
            this.cbCurso.DisplayMember = "Id";
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(79, 129);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(121, 21);
            this.cbCurso.TabIndex = 13;
            this.cbCurso.ValueMember = "Id";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(222, 63);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(30, 13);
            this.lblNota.TabIndex = 6;
            this.lblNota.Text = "Nota";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(303, 66);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 20);
            this.txtNota.TabIndex = 11;
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataSource = typeof(Entidades.Persona);
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataSource = typeof(Entidades.Curso);
            // 
            // AlumnosInscripcionesDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 220);
            this.Controls.Add(this.tlAI);
            this.Name = "AlumnosInscripcionesDesktop";
            this.Text = "Alumnos_InscripcionesDesktop";
            this.tlAI.ResumeLayout(false);
            this.tlAI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlAI;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.TextBox txtIdIns;
        private System.Windows.Forms.TextBox txtCond;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cbAlumno;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private System.Windows.Forms.BindingSource cursoBindingSource;
    }
}