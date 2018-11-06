namespace UI.Desktop
{
    partial class DocentesCursosDesktop
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblIdDictado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtIdDictado = new System.Windows.Forms.TextBox();
            this.cbIdCurso = new System.Windows.Forms.ComboBox();
            this.cbIdDocente = new System.Windows.Forms.ComboBox();
            this.cbIdCargo = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblIdDictado, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtIdDictado, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbIdCurso, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbIdDocente, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbIdCargo, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(614, 120);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(407, 95);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 22);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblIdDictado
            // 
            this.lblIdDictado.AutoSize = true;
            this.lblIdDictado.Location = new System.Drawing.Point(3, 0);
            this.lblIdDictado.Name = "lblIdDictado";
            this.lblIdDictado.Size = new System.Drawing.Size(56, 13);
            this.lblIdDictado.TabIndex = 0;
            this.lblIdDictado.Text = "Id Dictado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Docente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cargo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(205, 95);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 22);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtIdDictado
            // 
            this.txtIdDictado.Enabled = false;
            this.txtIdDictado.Location = new System.Drawing.Point(205, 3);
            this.txtIdDictado.Name = "txtIdDictado";
            this.txtIdDictado.ReadOnly = true;
            this.txtIdDictado.Size = new System.Drawing.Size(121, 20);
            this.txtIdDictado.TabIndex = 6;
            // 
            // cbIdCurso
            // 
            this.cbIdCurso.FormattingEnabled = true;
            this.cbIdCurso.Location = new System.Drawing.Point(205, 23);
            this.cbIdCurso.Name = "cbIdCurso";
            this.cbIdCurso.Size = new System.Drawing.Size(121, 21);
            this.cbIdCurso.TabIndex = 7;
            // 
            // cbIdDocente
            // 
            this.cbIdDocente.FormattingEnabled = true;
            this.cbIdDocente.Location = new System.Drawing.Point(205, 43);
            this.cbIdDocente.Name = "cbIdDocente";
            this.cbIdDocente.Size = new System.Drawing.Size(121, 21);
            this.cbIdDocente.TabIndex = 8;
            // 
            // cbIdCargo
            // 
            this.cbIdCargo.FormattingEnabled = true;
            this.cbIdCargo.Location = new System.Drawing.Point(205, 63);
            this.cbIdCargo.Name = "cbIdCargo";
            this.cbIdCargo.Size = new System.Drawing.Size(121, 21);
            this.cbIdCargo.TabIndex = 9;
            // 
            // DocentesCursosDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 157);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DocentesCursosDesktop";
            this.Text = "DocentesCursosDesktop";
            this.Load += new System.EventHandler(this.DocentesCursosDesktop_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblIdDictado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtIdDictado;
        private System.Windows.Forms.ComboBox cbIdCurso;
        private System.Windows.Forms.ComboBox cbIdDocente;
        private System.Windows.Forms.ComboBox cbIdCargo;
    }
}