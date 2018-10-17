namespace WF_GPVH.Formularios.Mantenedores.Funcionario
{
    partial class Form_M_Funcionario_Modificar
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
            this.label6 = new MetroFramework.Controls.MetroLabel();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.ddl_unidad = new MetroFramework.Controls.MetroComboBox();
            this.chk_habilitado = new System.Windows.Forms.CheckBox();
            this.txt_direccion = new MetroFramework.Controls.MetroTextBox();
            this.txt_nombre = new MetroFramework.Controls.MetroTextBox();
            this.txt_run = new MetroFramework.Controls.MetroTextBox();
            this.lbl_run = new MetroFramework.Controls.MetroLabel();
            this.txt_ap_pat = new MetroFramework.Controls.MetroTextBox();
            this.txt_ap_mat = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new MetroFramework.Controls.MetroLabel();
            this.label8 = new MetroFramework.Controls.MetroLabel();
            this.txt_correo = new MetroFramework.Controls.MetroTextBox();
            this.label9 = new MetroFramework.Controls.MetroLabel();
            this.cld_nacimiento = new MetroFramework.Controls.MetroDateTime();
            this.lblErrorFechaNacimiento = new MetroFramework.Controls.MetroLabel();
            this.lblErrorDireccion = new MetroFramework.Controls.MetroLabel();
            this.lblErrorCorreo = new MetroFramework.Controls.MetroLabel();
            this.lblErrorApellidoMaterno = new MetroFramework.Controls.MetroLabel();
            this.lblErrorApellidoPaterno = new MetroFramework.Controls.MetroLabel();
            this.lblErrorNombre = new MetroFramework.Controls.MetroLabel();
            this.lblErrorCargo = new MetroFramework.Controls.MetroLabel();
            this.txt_cargo = new MetroFramework.Controls.MetroTextBox();
            this.mtModificar = new MetroFramework.Controls.MetroTile();
            this.mtVolver = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Unidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Cargo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Habilitado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Correo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre";
            // 
            // ddl_unidad
            // 
            this.ddl_unidad.FormattingEnabled = true;
            this.ddl_unidad.ItemHeight = 23;
            this.ddl_unidad.Location = new System.Drawing.Point(135, 303);
            this.ddl_unidad.Name = "ddl_unidad";
            this.ddl_unidad.Size = new System.Drawing.Size(121, 29);
            this.ddl_unidad.TabIndex = 9;
            this.ddl_unidad.UseSelectable = true;
            this.ddl_unidad.SelectedIndexChanged += new System.EventHandler(this.ddl_unidad_SelectedIndexChanged);
            // 
            // chk_habilitado
            // 
            this.chk_habilitado.AutoSize = true;
            this.chk_habilitado.Location = new System.Drawing.Point(135, 282);
            this.chk_habilitado.Name = "chk_habilitado";
            this.chk_habilitado.Size = new System.Drawing.Size(15, 14);
            this.chk_habilitado.TabIndex = 17;
            this.chk_habilitado.UseVisualStyleBackColor = true;
            // 
            // txt_direccion
            // 
            // 
            // 
            // 
            this.txt_direccion.CustomButton.Image = null;
            this.txt_direccion.CustomButton.Location = new System.Drawing.Point(103, 2);
            this.txt_direccion.CustomButton.Name = "";
            this.txt_direccion.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txt_direccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_direccion.CustomButton.TabIndex = 1;
            this.txt_direccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_direccion.CustomButton.UseSelectable = true;
            this.txt_direccion.CustomButton.Visible = false;
            this.txt_direccion.Lines = new string[0];
            this.txt_direccion.Location = new System.Drawing.Point(135, 229);
            this.txt_direccion.MaxLength = 32767;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.PasswordChar = '\0';
            this.txt_direccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_direccion.SelectedText = "";
            this.txt_direccion.SelectionLength = 0;
            this.txt_direccion.SelectionStart = 0;
            this.txt_direccion.ShortcutsEnabled = true;
            this.txt_direccion.Size = new System.Drawing.Size(121, 20);
            this.txt_direccion.TabIndex = 7;
            this.txt_direccion.UseSelectable = true;
            this.txt_direccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_direccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_direccion.TextChanged += new System.EventHandler(this.txt_direccion_TextChanged);
            // 
            // txt_nombre
            // 
            // 
            // 
            // 
            this.txt_nombre.CustomButton.Image = null;
            this.txt_nombre.CustomButton.Location = new System.Drawing.Point(103, 2);
            this.txt_nombre.CustomButton.Name = "";
            this.txt_nombre.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txt_nombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_nombre.CustomButton.TabIndex = 1;
            this.txt_nombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_nombre.CustomButton.UseSelectable = true;
            this.txt_nombre.CustomButton.Visible = false;
            this.txt_nombre.Lines = new string[0];
            this.txt_nombre.Location = new System.Drawing.Point(135, 95);
            this.txt_nombre.MaxLength = 32767;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PasswordChar = '\0';
            this.txt_nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_nombre.SelectedText = "";
            this.txt_nombre.SelectionLength = 0;
            this.txt_nombre.SelectionStart = 0;
            this.txt_nombre.ShortcutsEnabled = true;
            this.txt_nombre.Size = new System.Drawing.Size(121, 20);
            this.txt_nombre.TabIndex = 2;
            this.txt_nombre.UseSelectable = true;
            this.txt_nombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_nombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // txt_run
            // 
            // 
            // 
            // 
            this.txt_run.CustomButton.Image = null;
            this.txt_run.CustomButton.Location = new System.Drawing.Point(103, 2);
            this.txt_run.CustomButton.Name = "";
            this.txt_run.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txt_run.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_run.CustomButton.TabIndex = 1;
            this.txt_run.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_run.CustomButton.UseSelectable = true;
            this.txt_run.CustomButton.Visible = false;
            this.txt_run.Lines = new string[0];
            this.txt_run.Location = new System.Drawing.Point(135, 66);
            this.txt_run.MaxLength = 32767;
            this.txt_run.Name = "txt_run";
            this.txt_run.PasswordChar = '\0';
            this.txt_run.ReadOnly = true;
            this.txt_run.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_run.SelectedText = "";
            this.txt_run.SelectionLength = 0;
            this.txt_run.SelectionStart = 0;
            this.txt_run.ShortcutsEnabled = true;
            this.txt_run.Size = new System.Drawing.Size(121, 20);
            this.txt_run.TabIndex = 1;
            this.txt_run.UseSelectable = true;
            this.txt_run.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_run.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_run
            // 
            this.lbl_run.AutoSize = true;
            this.lbl_run.Location = new System.Drawing.Point(23, 69);
            this.lbl_run.Name = "lbl_run";
            this.lbl_run.Size = new System.Drawing.Size(36, 19);
            this.lbl_run.TabIndex = 29;
            this.lbl_run.Text = "RUN";
            // 
            // txt_ap_pat
            // 
            // 
            // 
            // 
            this.txt_ap_pat.CustomButton.Image = null;
            this.txt_ap_pat.CustomButton.Location = new System.Drawing.Point(103, 2);
            this.txt_ap_pat.CustomButton.Name = "";
            this.txt_ap_pat.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txt_ap_pat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_ap_pat.CustomButton.TabIndex = 1;
            this.txt_ap_pat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ap_pat.CustomButton.UseSelectable = true;
            this.txt_ap_pat.CustomButton.Visible = false;
            this.txt_ap_pat.Lines = new string[0];
            this.txt_ap_pat.Location = new System.Drawing.Point(135, 121);
            this.txt_ap_pat.MaxLength = 32767;
            this.txt_ap_pat.Name = "txt_ap_pat";
            this.txt_ap_pat.PasswordChar = '\0';
            this.txt_ap_pat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ap_pat.SelectedText = "";
            this.txt_ap_pat.SelectionLength = 0;
            this.txt_ap_pat.SelectionStart = 0;
            this.txt_ap_pat.ShortcutsEnabled = true;
            this.txt_ap_pat.Size = new System.Drawing.Size(121, 20);
            this.txt_ap_pat.TabIndex = 3;
            this.txt_ap_pat.UseSelectable = true;
            this.txt_ap_pat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ap_pat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_ap_pat.TextChanged += new System.EventHandler(this.txt_ap_pat_TextChanged);
            // 
            // txt_ap_mat
            // 
            // 
            // 
            // 
            this.txt_ap_mat.CustomButton.Image = null;
            this.txt_ap_mat.CustomButton.Location = new System.Drawing.Point(103, 2);
            this.txt_ap_mat.CustomButton.Name = "";
            this.txt_ap_mat.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txt_ap_mat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_ap_mat.CustomButton.TabIndex = 1;
            this.txt_ap_mat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ap_mat.CustomButton.UseSelectable = true;
            this.txt_ap_mat.CustomButton.Visible = false;
            this.txt_ap_mat.Lines = new string[0];
            this.txt_ap_mat.Location = new System.Drawing.Point(135, 147);
            this.txt_ap_mat.MaxLength = 32767;
            this.txt_ap_mat.Name = "txt_ap_mat";
            this.txt_ap_mat.PasswordChar = '\0';
            this.txt_ap_mat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ap_mat.SelectedText = "";
            this.txt_ap_mat.SelectionLength = 0;
            this.txt_ap_mat.SelectionStart = 0;
            this.txt_ap_mat.ShortcutsEnabled = true;
            this.txt_ap_mat.Size = new System.Drawing.Size(121, 20);
            this.txt_ap_mat.TabIndex = 4;
            this.txt_ap_mat.UseSelectable = true;
            this.txt_ap_mat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ap_mat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_ap_mat.TextChanged += new System.EventHandler(this.txt_ap_mat_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "Apellido Paterno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 19);
            this.label8.TabIndex = 33;
            this.label8.Text = "Apellido Materno";
            // 
            // txt_correo
            // 
            // 
            // 
            // 
            this.txt_correo.CustomButton.Image = null;
            this.txt_correo.CustomButton.Location = new System.Drawing.Point(103, 2);
            this.txt_correo.CustomButton.Name = "";
            this.txt_correo.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txt_correo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_correo.CustomButton.TabIndex = 1;
            this.txt_correo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_correo.CustomButton.UseSelectable = true;
            this.txt_correo.CustomButton.Visible = false;
            this.txt_correo.Lines = new string[0];
            this.txt_correo.Location = new System.Drawing.Point(135, 203);
            this.txt_correo.MaxLength = 32767;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.PasswordChar = '\0';
            this.txt_correo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_correo.SelectedText = "";
            this.txt_correo.SelectionLength = 0;
            this.txt_correo.SelectionStart = 0;
            this.txt_correo.ShortcutsEnabled = true;
            this.txt_correo.Size = new System.Drawing.Size(121, 20);
            this.txt_correo.TabIndex = 6;
            this.txt_correo.UseSelectable = true;
            this.txt_correo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_correo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_correo.TextChanged += new System.EventHandler(this.txt_correo_TextChanged);
            this.txt_correo.Leave += new System.EventHandler(this.txt_correo_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 19);
            this.label9.TabIndex = 36;
            this.label9.Text = "Fecha nacimiento";
            // 
            // cld_nacimiento
            // 
            this.cld_nacimiento.Location = new System.Drawing.Point(135, 170);
            this.cld_nacimiento.MinimumSize = new System.Drawing.Size(0, 29);
            this.cld_nacimiento.Name = "cld_nacimiento";
            this.cld_nacimiento.Size = new System.Drawing.Size(200, 29);
            this.cld_nacimiento.TabIndex = 5;
            this.cld_nacimiento.ValueChanged += new System.EventHandler(this.cld_nacimiento_ValueChanged);
            // 
            // lblErrorFechaNacimiento
            // 
            this.lblErrorFechaNacimiento.AutoSize = true;
            this.lblErrorFechaNacimiento.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFechaNacimiento.Location = new System.Drawing.Point(342, 176);
            this.lblErrorFechaNacimiento.Name = "lblErrorFechaNacimiento";
            this.lblErrorFechaNacimiento.Size = new System.Drawing.Size(162, 19);
            this.lblErrorFechaNacimiento.TabIndex = 74;
            this.lblErrorFechaNacimiento.Text = "Fecha Nacimiento Invalida";
            this.lblErrorFechaNacimiento.Visible = false;
            // 
            // lblErrorDireccion
            // 
            this.lblErrorDireccion.AutoSize = true;
            this.lblErrorDireccion.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDireccion.Location = new System.Drawing.Point(265, 232);
            this.lblErrorDireccion.Name = "lblErrorDireccion";
            this.lblErrorDireccion.Size = new System.Drawing.Size(111, 19);
            this.lblErrorDireccion.TabIndex = 73;
            this.lblErrorDireccion.Text = "Direccion Invalida";
            this.lblErrorDireccion.Visible = false;
            // 
            // lblErrorCorreo
            // 
            this.lblErrorCorreo.AutoSize = true;
            this.lblErrorCorreo.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCorreo.Location = new System.Drawing.Point(265, 206);
            this.lblErrorCorreo.Name = "lblErrorCorreo";
            this.lblErrorCorreo.Size = new System.Drawing.Size(100, 19);
            this.lblErrorCorreo.TabIndex = 72;
            this.lblErrorCorreo.Text = "Correo Invalido";
            this.lblErrorCorreo.Visible = false;
            // 
            // lblErrorApellidoMaterno
            // 
            this.lblErrorApellidoMaterno.AutoSize = true;
            this.lblErrorApellidoMaterno.ForeColor = System.Drawing.Color.Red;
            this.lblErrorApellidoMaterno.Location = new System.Drawing.Point(265, 150);
            this.lblErrorApellidoMaterno.Name = "lblErrorApellidoMaterno";
            this.lblErrorApellidoMaterno.Size = new System.Drawing.Size(161, 19);
            this.lblErrorApellidoMaterno.TabIndex = 71;
            this.lblErrorApellidoMaterno.Text = "Apellido Materno Invalido";
            this.lblErrorApellidoMaterno.Visible = false;
            // 
            // lblErrorApellidoPaterno
            // 
            this.lblErrorApellidoPaterno.AutoSize = true;
            this.lblErrorApellidoPaterno.ForeColor = System.Drawing.Color.Red;
            this.lblErrorApellidoPaterno.Location = new System.Drawing.Point(265, 124);
            this.lblErrorApellidoPaterno.Name = "lblErrorApellidoPaterno";
            this.lblErrorApellidoPaterno.Size = new System.Drawing.Size(156, 19);
            this.lblErrorApellidoPaterno.TabIndex = 70;
            this.lblErrorApellidoPaterno.Text = "Apellido Paterno Invalido";
            this.lblErrorApellidoPaterno.Visible = false;
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNombre.Location = new System.Drawing.Point(265, 98);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(108, 19);
            this.lblErrorNombre.TabIndex = 69;
            this.lblErrorNombre.Text = "Nombre Invalido";
            this.lblErrorNombre.Visible = false;
            // 
            // lblErrorCargo
            // 
            this.lblErrorCargo.AutoSize = true;
            this.lblErrorCargo.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCargo.Location = new System.Drawing.Point(264, 257);
            this.lblErrorCargo.Name = "lblErrorCargo";
            this.lblErrorCargo.Size = new System.Drawing.Size(95, 19);
            this.lblErrorCargo.TabIndex = 76;
            this.lblErrorCargo.Text = "Cargo Invalido";
            this.lblErrorCargo.Visible = false;
            // 
            // txt_cargo
            // 
            // 
            // 
            // 
            this.txt_cargo.CustomButton.Image = null;
            this.txt_cargo.CustomButton.Location = new System.Drawing.Point(103, 2);
            this.txt_cargo.CustomButton.Name = "";
            this.txt_cargo.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txt_cargo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_cargo.CustomButton.TabIndex = 1;
            this.txt_cargo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_cargo.CustomButton.UseSelectable = true;
            this.txt_cargo.CustomButton.Visible = false;
            this.txt_cargo.Lines = new string[0];
            this.txt_cargo.Location = new System.Drawing.Point(135, 254);
            this.txt_cargo.MaxLength = 32767;
            this.txt_cargo.Name = "txt_cargo";
            this.txt_cargo.PasswordChar = '\0';
            this.txt_cargo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_cargo.SelectedText = "";
            this.txt_cargo.SelectionLength = 0;
            this.txt_cargo.SelectionStart = 0;
            this.txt_cargo.ShortcutsEnabled = true;
            this.txt_cargo.Size = new System.Drawing.Size(121, 20);
            this.txt_cargo.TabIndex = 8;
            this.txt_cargo.UseSelectable = true;
            this.txt_cargo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_cargo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_cargo.TextChanged += new System.EventHandler(this.txt_cargo_TextChanged);
            // 
            // mtModificar
            // 
            this.mtModificar.ActiveControl = null;
            this.mtModificar.Location = new System.Drawing.Point(24, 380);
            this.mtModificar.Name = "mtModificar";
            this.mtModificar.Size = new System.Drawing.Size(106, 78);
            this.mtModificar.TabIndex = 77;
            this.mtModificar.Text = "Modificar";
            this.mtModificar.UseSelectable = true;
            this.mtModificar.Click += new System.EventHandler(this.mtModificar_Click);
            // 
            // mtVolver
            // 
            this.mtVolver.ActiveControl = null;
            this.mtVolver.Location = new System.Drawing.Point(196, 380);
            this.mtVolver.Name = "mtVolver";
            this.mtVolver.Size = new System.Drawing.Size(106, 78);
            this.mtVolver.TabIndex = 78;
            this.mtVolver.Text = "Volver";
            this.mtVolver.UseSelectable = true;
            this.mtVolver.Click += new System.EventHandler(this.mtVolver_Click);
            // 
            // Form_M_Funcionario_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 510);
            this.Controls.Add(this.mtVolver);
            this.Controls.Add(this.mtModificar);
            this.Controls.Add(this.lblErrorCargo);
            this.Controls.Add(this.txt_cargo);
            this.Controls.Add(this.lblErrorFechaNacimiento);
            this.Controls.Add(this.lblErrorDireccion);
            this.Controls.Add(this.lblErrorCorreo);
            this.Controls.Add(this.lblErrorApellidoMaterno);
            this.Controls.Add(this.lblErrorApellidoPaterno);
            this.Controls.Add(this.lblErrorNombre);
            this.Controls.Add(this.cld_nacimiento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_ap_mat);
            this.Controls.Add(this.txt_ap_pat);
            this.Controls.Add(this.lbl_run);
            this.Controls.Add(this.txt_run);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddl_unidad);
            this.Controls.Add(this.chk_habilitado);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_nombre);
            this.Name = "Form_M_Funcionario_Modificar";
            this.Text = "Form_M_Funcionario_Modificar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_M_Funcionario_Modificar_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel label6;
        private MetroFramework.Controls.MetroLabel label5;
        private MetroFramework.Controls.MetroLabel label4;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroComboBox ddl_unidad;
        private System.Windows.Forms.CheckBox chk_habilitado;
        private MetroFramework.Controls.MetroTextBox txt_direccion;
        private MetroFramework.Controls.MetroTextBox txt_nombre;
        private MetroFramework.Controls.MetroTextBox txt_run;
        private MetroFramework.Controls.MetroLabel lbl_run;
        private MetroFramework.Controls.MetroTextBox txt_ap_pat;
        private MetroFramework.Controls.MetroTextBox txt_ap_mat;
        private MetroFramework.Controls.MetroLabel label7;
        private MetroFramework.Controls.MetroLabel label8;
        private MetroFramework.Controls.MetroTextBox txt_correo;
        private MetroFramework.Controls.MetroLabel label9;
        private MetroFramework.Controls.MetroDateTime cld_nacimiento;
        private MetroFramework.Controls.MetroLabel lblErrorFechaNacimiento;
        private MetroFramework.Controls.MetroLabel lblErrorDireccion;
        private MetroFramework.Controls.MetroLabel lblErrorCorreo;
        private MetroFramework.Controls.MetroLabel lblErrorApellidoMaterno;
        private MetroFramework.Controls.MetroLabel lblErrorApellidoPaterno;
        private MetroFramework.Controls.MetroLabel lblErrorNombre;
        private MetroFramework.Controls.MetroLabel lblErrorCargo;
        private MetroFramework.Controls.MetroTextBox txt_cargo;
        private MetroFramework.Controls.MetroTile mtModificar;
        private MetroFramework.Controls.MetroTile mtVolver;
    }
}