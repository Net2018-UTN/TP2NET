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
            this.tlAI = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.Label();
            this.txtIdIns = new System.Windows.Forms.TextBox();
            this.txtIdCur = new System.Windows.Forms.TextBox();
            this.txtIdAl = new System.Windows.Forms.TextBox();
            this.txtCond = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tlAI.SuspendLayout();
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
            this.tlAI.Controls.Add(this.label2, 0, 1);
            this.tlAI.Controls.Add(this.label3, 0, 2);
            this.tlAI.Controls.Add(this.label4, 2, 0);
            this.tlAI.Controls.Add(this.txtNota, 2, 1);
            this.tlAI.Controls.Add(this.txtIdIns, 1, 0);
            this.tlAI.Controls.Add(this.txtIdCur, 1, 1);
            this.tlAI.Controls.Add(this.txtIdAl, 1, 2);
            this.tlAI.Controls.Add(this.txtCond, 3, 0);
            this.tlAI.Controls.Add(this.textBox5, 3, 1);
            this.tlAI.Controls.Add(this.btnAceptar, 2, 3);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id Alumno";
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
            // txtNota
            // 
            this.txtNota.AutoSize = true;
            this.txtNota.Location = new System.Drawing.Point(222, 63);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(30, 13);
            this.txtNota.TabIndex = 6;
            this.txtNota.Text = "Nota";
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
            // txtIdCur
            // 
            this.txtIdCur.Location = new System.Drawing.Point(79, 66);
            this.txtIdCur.Name = "txtIdCur";
            this.txtIdCur.Size = new System.Drawing.Size(100, 20);
            this.txtIdCur.TabIndex = 8;
            // 
            // txtIdAl
            // 
            this.txtIdAl.Location = new System.Drawing.Point(79, 129);
            this.txtIdAl.Name = "txtIdAl";
            this.txtIdAl.Size = new System.Drawing.Size(100, 20);
            this.txtIdAl.TabIndex = 9;
            // 
            // txtCond
            // 
            this.txtCond.Location = new System.Drawing.Point(303, 3);
            this.txtCond.Name = "txtCond";
            this.txtCond.Size = new System.Drawing.Size(100, 20);
            this.txtCond.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(303, 66);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 11;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlAI;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtNota;
        private System.Windows.Forms.TextBox txtIdIns;
        private System.Windows.Forms.TextBox txtIdCur;
        private System.Windows.Forms.TextBox txtIdAl;
        private System.Windows.Forms.TextBox txtCond;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnAceptar;
    }
}