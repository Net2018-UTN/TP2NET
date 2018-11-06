namespace UI.Desktop
{
    partial class ModuloUsuarioDesktop
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblModulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.cmbModulo = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.chkAlta = new System.Windows.Forms.CheckBox();
            this.chkBaja = new System.Windows.Forms.CheckBox();
            this.chkModificacion = new System.Windows.Forms.CheckBox();
            this.chkConsulta = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.87467F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.12533F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.65306F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.34694F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(383, 196);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.54717F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.45283F));
            this.tableLayoutPanel2.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblModulo, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblUsuario, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmbUsuario, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmbModulo, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(207, 155);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 19);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblModulo
            // 
            this.lblModulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblModulo.AutoSize = true;
            this.lblModulo.Location = new System.Drawing.Point(3, 70);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(42, 13);
            this.lblModulo.TabIndex = 1;
            this.lblModulo.Text = "Módulo";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(3, 122);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(70, 118);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(121, 21);
            this.cmbUsuario.TabIndex = 3;
            this.cmbUsuario.ValueMember = "id_usuario";
            // 
            // cmbModulo
            // 
            this.cmbModulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModulo.FormattingEnabled = true;
            this.cmbModulo.Location = new System.Drawing.Point(70, 66);
            this.cmbModulo.Name = "cmbModulo";
            this.cmbModulo.Size = new System.Drawing.Size(121, 21);
            this.cmbModulo.TabIndex = 4;
            this.cmbModulo.ValueMember = "id_modulo";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtID.Location = new System.Drawing.Point(70, 15);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(121, 20);
            this.txtID.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.chkAlta, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.chkBaja, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.chkModificacion, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.chkConsulta, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(216, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(164, 155);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // chkAlta
            // 
            this.chkAlta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkAlta.AutoSize = true;
            this.chkAlta.Location = new System.Drawing.Point(3, 10);
            this.chkAlta.Name = "chkAlta";
            this.chkAlta.Size = new System.Drawing.Size(44, 17);
            this.chkAlta.TabIndex = 0;
            this.chkAlta.Text = "Alta";
            this.chkAlta.UseVisualStyleBackColor = true;
            // 
            // chkBaja
            // 
            this.chkBaja.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkBaja.AutoSize = true;
            this.chkBaja.Location = new System.Drawing.Point(3, 47);
            this.chkBaja.Name = "chkBaja";
            this.chkBaja.Size = new System.Drawing.Size(47, 17);
            this.chkBaja.TabIndex = 1;
            this.chkBaja.Text = "Baja";
            this.chkBaja.UseVisualStyleBackColor = true;
            // 
            // chkModificacion
            // 
            this.chkModificacion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkModificacion.AutoSize = true;
            this.chkModificacion.Location = new System.Drawing.Point(3, 84);
            this.chkModificacion.Name = "chkModificacion";
            this.chkModificacion.Size = new System.Drawing.Size(86, 17);
            this.chkModificacion.TabIndex = 2;
            this.chkModificacion.Text = "Modificación";
            this.chkModificacion.UseVisualStyleBackColor = true;
            // 
            // chkConsulta
            // 
            this.chkConsulta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkConsulta.AutoSize = true;
            this.chkConsulta.Location = new System.Drawing.Point(3, 124);
            this.chkConsulta.Name = "chkConsulta";
            this.chkConsulta.Size = new System.Drawing.Size(67, 17);
            this.chkConsulta.TabIndex = 3;
            this.chkConsulta.Text = "Consulta";
            this.chkConsulta.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel4.Controls.Add(this.btnAceptar, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnSalir, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(216, 164);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(164, 29);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(3, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(85, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ModuloUsuarioDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 196);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ModuloUsuarioDesktop";
            this.Text = "ModuloUsuarioDesktop";
            this.Load += new System.EventHandler(this.ModuloUsuarioDesktop_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.ComboBox cmbModulo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox chkAlta;
        private System.Windows.Forms.CheckBox chkBaja;
        private System.Windows.Forms.CheckBox chkModificacion;
        private System.Windows.Forms.CheckBox chkConsulta;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
    }
}