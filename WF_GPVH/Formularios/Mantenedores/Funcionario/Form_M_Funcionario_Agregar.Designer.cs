namespace WF_GPVH.Formularios.Mantenedores.Funcionario
{
    partial class Form_M_Funcionario_Agregar
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
            this.cld_nacimiento = new MetroFramework.Controls.MetroDateTime();
            this.label9 = new MetroFramework.Controls.MetroLabel();
            this.txt_correo = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new MetroFramework.Controls.MetroLabel();
            this.label7 = new MetroFramework.Controls.MetroLabel();
            this.txt_ap_mat = new MetroFramework.Controls.MetroTextBox();
            this.txt_ap_pat = new MetroFramework.Controls.MetroTextBox();
            this.lbl_run = new MetroFramework.Controls.MetroLabel();
            this.txt_run = new MetroFramework.Controls.MetroTextBox();
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
            this.txt_dv = new MetroFramework.Controls.MetroTextBox();
            this.lblErrorRun = new MetroFramework.Controls.MetroLabel();
            this.lblErrorNombre = new MetroFramework.Controls.MetroLabel();
            this.lblErrorApellidoPaterno = new MetroFramework.Controls.MetroLabel();
            this.lblErrorApellidoMaterno = new MetroFramework.Controls.MetroLabel();
            this.lblErrorCorreo = new MetroFramework.Controls.MetroLabel();
            this.lblErrorDireccion = new MetroFramework.Controls.MetroLabel();
            this.lblErrorFechaNacimiento = new MetroFramework.Controls.MetroLabel();
            this.txt_cargo = new MetroFramework.Controls.MetroTextBox();
            this.lblErrorCargo = new MetroFramework.Controls.MetroLabel();
            this.mtAgregar = new MetroFramework.Controls.MetroTile();
            this.mtVolver = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // cld_nacimiento
            // 
            this.cld_nacimiento.Location = new System.Drawing.Point(138, 177);
            this.cld_nacimiento.MinimumSize = new System.Drawing.Size(0, 29);
            this.cld_nacimiento.Name = "cld_nacimiento";
            this.cld_nacimiento.Size = new System.Drawing.Size(200, 29);
            this.cld_nacimiento.TabIndex = 59;
            this.cld_nacimiento.Value = new System.DateTime(1944, 6, 6, 23, 56, 0, 0);
            this.cld_nacimiento.ValueChanged += new System.EventHandler(this.cld_nacimiento_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 19);
            this.label9.TabIndex = 58;
            this.label9.Text = "Fecha nacimiento";
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
            this.txt_correo.Location = new System.Drawing.Point(137, 219);
            this.txt_correo.MaxLength = 32767;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.PasswordChar = '\0';
            this.txt_correo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_correo.SelectedText = "";
            this.txt_correo.SelectionLength = 0;
            this.txt_correo.SelectionStart = 0;
            this.txt_correo.ShortcutsEnabled = true;
            this.txt_correo.Size = new System.Drawing.Size(121, 20);
            this.txt_correo.TabIndex = 57;
            this.txt_correo.UseSelectable = true;
            this.txt_correo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_correo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_correo.TextChanged += new System.EventHandler(this.txt_correo_TextChanged);
            this.txt_correo.Leave += new System.EventHandler(this.txt_correo_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 19);
            this.label8.TabIndex = 56;
            this.label8.Text = "Apellido Materno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 19);
            this.label7.TabIndex = 55;
            this.label7.Text = "Apellido Paterno";
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
            this.txt_ap_mat.Location = new System.Drawing.Point(138, 151);
            this.txt_ap_mat.MaxLength = 32767;
            this.txt_ap_mat.Name = "txt_ap_mat";
            this.txt_ap_mat.PasswordChar = '\0';
            this.txt_ap_mat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ap_mat.SelectedText = "";
            this.txt_ap_mat.SelectionLength = 0;
            this.txt_ap_mat.SelectionStart = 0;
            this.txt_ap_mat.ShortcutsEnabled = true;
            this.txt_ap_mat.Size = new System.Drawing.Size(121, 20);
            this.txt_ap_mat.TabIndex = 54;
            this.txt_ap_mat.UseSelectable = true;
            this.txt_ap_mat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ap_mat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_ap_mat.TextChanged += new System.EventHandler(this.txt_ap_mat_TextChanged);
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
            this.txt_ap_pat.Location = new System.Drawing.Point(138, 125);
            this.txt_ap_pat.MaxLength = 32767;
            this.txt_ap_pat.Name = "txt_ap_pat";
            this.txt_ap_pat.PasswordChar = '\0';
            this.txt_ap_pat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ap_pat.SelectedText = "";
            this.txt_ap_pat.SelectionLength = 0;
            this.txt_ap_pat.SelectionStart = 0;
            this.txt_ap_pat.ShortcutsEnabled = true;
            this.txt_ap_pat.Size = new System.Drawing.Size(121, 20);
            this.txt_ap_pat.TabIndex = 53;
            this.txt_ap_pat.UseSelectable = true;
            this.txt_ap_pat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ap_pat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_ap_pat.TextChanged += new System.EventHandler(this.txt_ap_pat_TextChanged);
            // 
            // lbl_run
            // 
            this.lbl_run.AutoSize = true;
            this.lbl_run.Location = new System.Drawing.Point(24, 73);
            this.lbl_run.Name = "lbl_run";
            this.lbl_run.Size = new System.Drawing.Size(36, 19);
            this.lbl_run.TabIndex = 52;
            this.lbl_run.Text = "RUN";
            // 
            // txt_run
            // 
            // 
            // 
            // 
            this.txt_run.CustomButton.Image = null;
            this.txt_run.CustomButton.Location = new System.Drawing.Point(75, 2);
            this.txt_run.CustomButton.Name = "";
            this.txt_run.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txt_run.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_run.CustomButton.TabIndex = 1;
            this.txt_run.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_run.CustomButton.UseSelectable = true;
            this.txt_run.CustomButton.Visible = false;
            this.txt_run.Lines = new string[0];
            this.txt_run.Location = new System.Drawing.Point(138, 70);
            this.txt_run.MaxLength = 8;
            this.txt_run.Name = "txt_run";
            this.txt_run.PasswordChar = '\0';
            this.txt_run.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_run.SelectedText = "";
            this.txt_run.SelectionLength = 0;
            this.txt_run.SelectionStart = 0;
            this.txt_run.ShortcutsEnabled = true;
            this.txt_run.Size = new System.Drawing.Size(93, 20);
            this.txt_run.TabIndex = 51;
            this.txt_run.UseSelectable = true;
            this.txt_run.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_run.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_run.TextChanged += new System.EventHandler(this.txt_run_TextChanged);
            this.txt_run.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_run_KeyPress);
            this.txt_run.Leave += new System.EventHandler(this.txt_run_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 48;
            this.label6.Text = "Unidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 47;
            this.label5.Text = "Cargo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 46;
            this.label4.Text = "Habilitado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 45;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 44;
            this.label2.Text = "Correo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "Nombre";
            // 
            // ddl_unidad
            // 
            this.ddl_unidad.FormattingEnabled = true;
            this.ddl_unidad.ItemHeight = 23;
            this.ddl_unidad.Location = new System.Drawing.Point(137, 313);
            this.ddl_unidad.Name = "ddl_unidad";
            this.ddl_unidad.Size = new System.Drawing.Size(121, 29);
            this.ddl_unidad.TabIndex = 41;
            this.ddl_unidad.UseSelectable = true;
            this.ddl_unidad.SelectedIndexChanged += new System.EventHandler(this.ddl_unidad_SelectedIndexChanged);
            // 
            // chk_habilitado
            // 
            this.chk_habilitado.AutoSize = true;
            this.chk_habilitado.Location = new System.Drawing.Point(137, 293);
            this.chk_habilitado.Name = "chk_habilitado";
            this.chk_habilitado.Size = new System.Drawing.Size(15, 14);
            this.chk_habilitado.TabIndex = 40;
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
            this.txt_direccion.Location = new System.Drawing.Point(137, 245);
            this.txt_direccion.MaxLength = 32767;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.PasswordChar = '\0';
            this.txt_direccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_direccion.SelectedText = "";
            this.txt_direccion.SelectionLength = 0;
            this.txt_direccion.SelectionStart = 0;
            this.txt_direccion.ShortcutsEnabled = true;
            this.txt_direccion.Size = new System.Drawing.Size(121, 20);
            this.txt_direccion.TabIndex = 39;
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
            this.txt_nombre.Location = new System.Drawing.Point(138, 99);
            this.txt_nombre.MaxLength = 32767;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PasswordChar = '\0';
            this.txt_nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_nombre.SelectedText = "";
            this.txt_nombre.SelectionLength = 0;
            this.txt_nombre.SelectionStart = 0;
            this.txt_nombre.ShortcutsEnabled = true;
            this.txt_nombre.Size = new System.Drawing.Size(121, 20);
            this.txt_nombre.TabIndex = 38;
            this.txt_nombre.UseSelectable = true;
            this.txt_nombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_nombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // txt_dv
            // 
            // 
            // 
            // 
            this.txt_dv.CustomButton.Image = null;
            this.txt_dv.CustomButton.Location = new System.Drawing.Point(4, 2);
            this.txt_dv.CustomButton.Name = "";
            this.txt_dv.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txt_dv.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_dv.CustomButton.TabIndex = 1;
            this.txt_dv.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_dv.CustomButton.UseSelectable = true;
            this.txt_dv.CustomButton.Visible = false;
            this.txt_dv.Lines = new string[0];
            this.txt_dv.Location = new System.Drawing.Point(237, 70);
            this.txt_dv.MaxLength = 1;
            this.txt_dv.Name = "txt_dv";
            this.txt_dv.PasswordChar = '\0';
            this.txt_dv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_dv.SelectedText = "";
            this.txt_dv.SelectionLength = 0;
            this.txt_dv.SelectionStart = 0;
            this.txt_dv.ShortcutsEnabled = true;
            this.txt_dv.Size = new System.Drawing.Size(22, 20);
            this.txt_dv.TabIndex = 60;
            this.txt_dv.UseSelectable = true;
            this.txt_dv.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_dv.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_dv.TextChanged += new System.EventHandler(this.txt_dv_TextChanged);
            this.txt_dv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dv_KeyPress);
            this.txt_dv.Leave += new System.EventHandler(this.txt_dv_Leave);
            // 
            // lblErrorRun
            // 
            this.lblErrorRun.AutoSize = true;
            this.lblErrorRun.ForeColor = System.Drawing.Color.Red;
            this.lblErrorRun.Location = new System.Drawing.Point(266, 73);
            this.lblErrorRun.Name = "lblErrorRun";
            this.lblErrorRun.Size = new System.Drawing.Size(85, 19);
            this.lblErrorRun.Style = MetroFramework.MetroColorStyle.Red;
            this.lblErrorRun.TabIndex = 61;
            this.lblErrorRun.Text = "RUN Invalido";
            this.lblErrorRun.UseCustomForeColor = true;
            this.lblErrorRun.Visible = false;
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNombre.Location = new System.Drawing.Point(267, 102);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(108, 19);
            this.lblErrorNombre.Style = MetroFramework.MetroColorStyle.Red;
            this.lblErrorNombre.TabIndex = 62;
            this.lblErrorNombre.Text = "Nombre Invalido";
            this.lblErrorNombre.UseCustomForeColor = true;
            this.lblErrorNombre.Visible = false;
            // 
            // lblErrorApellidoPaterno
            // 
            this.lblErrorApellidoPaterno.AutoSize = true;
            this.lblErrorApellidoPaterno.ForeColor = System.Drawing.Color.Red;
            this.lblErrorApellidoPaterno.Location = new System.Drawing.Point(267, 128);
            this.lblErrorApellidoPaterno.Name = "lblErrorApellidoPaterno";
            this.lblErrorApellidoPaterno.Size = new System.Drawing.Size(156, 19);
            this.lblErrorApellidoPaterno.Style = MetroFramework.MetroColorStyle.Red;
            this.lblErrorApellidoPaterno.TabIndex = 63;
            this.lblErrorApellidoPaterno.Text = "Apellido Paterno Invalido";
            this.lblErrorApellidoPaterno.UseCustomForeColor = true;
            this.lblErrorApellidoPaterno.Visible = false;
            // 
            // lblErrorApellidoMaterno
            // 
            this.lblErrorApellidoMaterno.AutoSize = true;
            this.lblErrorApellidoMaterno.ForeColor = System.Drawing.Color.Red;
            this.lblErrorApellidoMaterno.Location = new System.Drawing.Point(267, 154);
            this.lblErrorApellidoMaterno.Name = "lblErrorApellidoMaterno";
            this.lblErrorApellidoMaterno.Size = new System.Drawing.Size(161, 19);
            this.lblErrorApellidoMaterno.Style = MetroFramework.MetroColorStyle.Red;
            this.lblErrorApellidoMaterno.TabIndex = 64;
            this.lblErrorApellidoMaterno.Text = "Apellido Materno Invalido";
            this.lblErrorApellidoMaterno.UseCustomForeColor = true;
            this.lblErrorApellidoMaterno.Visible = false;
            // 
            // lblErrorCorreo
            // 
            this.lblErrorCorreo.AutoSize = true;
            this.lblErrorCorreo.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCorreo.Location = new System.Drawing.Point(266, 222);
            this.lblErrorCorreo.Name = "lblErrorCorreo";
            this.lblErrorCorreo.Size = new System.Drawing.Size(100, 19);
            this.lblErrorCorreo.Style = MetroFramework.MetroColorStyle.Red;
            this.lblErrorCorreo.TabIndex = 65;
            this.lblErrorCorreo.Text = "Correo Invalido";
            this.lblErrorCorreo.UseCustomForeColor = true;
            this.lblErrorCorreo.Visible = false;
            // 
            // lblErrorDireccion
            // 
            this.lblErrorDireccion.AutoSize = true;
            this.lblErrorDireccion.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDireccion.Location = new System.Drawing.Point(266, 248);
            this.lblErrorDireccion.Name = "lblErrorDireccion";
            this.lblErrorDireccion.Size = new System.Drawing.Size(111, 19);
            this.lblErrorDireccion.Style = MetroFramework.MetroColorStyle.Red;
            this.lblErrorDireccion.TabIndex = 66;
            this.lblErrorDireccion.Text = "Direccion Invalida";
            this.lblErrorDireccion.UseCustomForeColor = true;
            this.lblErrorDireccion.Visible = false;
            // 
            // lblErrorFechaNacimiento
            // 
            this.lblErrorFechaNacimiento.AutoSize = true;
            this.lblErrorFechaNacimiento.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFechaNacimiento.Location = new System.Drawing.Point(344, 183);
            this.lblErrorFechaNacimiento.Name = "lblErrorFechaNacimiento";
            this.lblErrorFechaNacimiento.Size = new System.Drawing.Size(162, 19);
            this.lblErrorFechaNacimiento.Style = MetroFramework.MetroColorStyle.Red;
            this.lblErrorFechaNacimiento.TabIndex = 67;
            this.lblErrorFechaNacimiento.Text = "Fecha Nacimiento Invalida";
            this.lblErrorFechaNacimiento.UseCustomForeColor = true;
            this.lblErrorFechaNacimiento.Visible = false;
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
            this.txt_cargo.Location = new System.Drawing.Point(137, 269);
            this.txt_cargo.MaxLength = 32767;
            this.txt_cargo.Name = "txt_cargo";
            this.txt_cargo.PasswordChar = '\0';
            this.txt_cargo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_cargo.SelectedText = "";
            this.txt_cargo.SelectionLength = 0;
            this.txt_cargo.SelectionStart = 0;
            this.txt_cargo.ShortcutsEnabled = true;
            this.txt_cargo.Size = new System.Drawing.Size(121, 20);
            this.txt_cargo.TabIndex = 68;
            this.txt_cargo.UseSelectable = true;
            this.txt_cargo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_cargo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_cargo.TextChanged += new System.EventHandler(this.txt_cargo_TextChanged);
            // 
            // lblErrorCargo
            // 
            this.lblErrorCargo.AutoSize = true;
            this.lblErrorCargo.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCargo.Location = new System.Drawing.Point(266, 272);
            this.lblErrorCargo.Name = "lblErrorCargo";
            this.lblErrorCargo.Size = new System.Drawing.Size(95, 19);
            this.lblErrorCargo.Style = MetroFramework.MetroColorStyle.Red;
            this.lblErrorCargo.TabIndex = 69;
            this.lblErrorCargo.Text = "Cargo Invalido";
            this.lblErrorCargo.UseCustomForeColor = true;
            this.lblErrorCargo.Visible = false;
            // 
            // mtAgregar
            // 
            this.mtAgregar.ActiveControl = null;
            this.mtAgregar.Location = new System.Drawing.Point(24, 381);
            this.mtAgregar.Name = "mtAgregar";
            this.mtAgregar.Size = new System.Drawing.Size(94, 58);
            this.mtAgregar.TabIndex = 70;
            this.mtAgregar.Text = "Agregar";
            this.mtAgregar.UseSelectable = true;
            this.mtAgregar.Click += new System.EventHandler(this.mtAgregar_Click);
            // 
            // mtVolver
            // 
            this.mtVolver.ActiveControl = null;
            this.mtVolver.Location = new System.Drawing.Point(300, 381);
            this.mtVolver.Name = "mtVolver";
            this.mtVolver.Size = new System.Drawing.Size(94, 58);
            this.mtVolver.TabIndex = 71;
            this.mtVolver.Text = "Volver";
            this.mtVolver.UseSelectable = true;
            this.mtVolver.Click += new System.EventHandler(this.mtVolver_Click);
            // 
            // Form_M_Funcionario_Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 531);
            this.Controls.Add(this.mtVolver);
            this.Controls.Add(this.mtAgregar);
            this.Controls.Add(this.lblErrorCargo);
            this.Controls.Add(this.txt_cargo);
            this.Controls.Add(this.lblErrorFechaNacimiento);
            this.Controls.Add(this.lblErrorDireccion);
            this.Controls.Add(this.lblErrorCorreo);
            this.Controls.Add(this.lblErrorApellidoMaterno);
            this.Controls.Add(this.lblErrorApellidoPaterno);
            this.Controls.Add(this.lblErrorNombre);
            this.Controls.Add(this.lblErrorRun);
            this.Controls.Add(this.txt_dv);
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
            this.Name = "Form_M_Funcionario_Agregar";
            this.Text = "Form_M_Funcionario_Agregar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_M_Funcionario_Agregar_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime cld_nacimiento;
        private MetroFramework.Controls.MetroLabel label9;
        private MetroFramework.Controls.MetroTextBox txt_correo;
        private MetroFramework.Controls.MetroLabel label8;
        private MetroFramework.Controls.MetroLabel label7;
        private MetroFramework.Controls.MetroTextBox txt_ap_mat;
        private MetroFramework.Controls.MetroTextBox txt_ap_pat;
        private MetroFramework.Controls.MetroLabel lbl_run;
        private MetroFramework.Controls.MetroTextBox txt_run;
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
        private MetroFramework.Controls.MetroTextBox txt_dv;
        private MetroFramework.Controls.MetroLabel lblErrorRun;
        private MetroFramework.Controls.MetroLabel lblErrorNombre;
        private MetroFramework.Controls.MetroLabel lblErrorApellidoPaterno;
        private MetroFramework.Controls.MetroLabel lblErrorApellidoMaterno;
        private MetroFramework.Controls.MetroLabel lblErrorCorreo;
        private MetroFramework.Controls.MetroLabel lblErrorDireccion;
        private MetroFramework.Controls.MetroLabel lblErrorFechaNacimiento;
        private MetroFramework.Controls.MetroTextBox txt_cargo;
        private MetroFramework.Controls.MetroLabel lblErrorCargo;
        private MetroFramework.Controls.MetroTile mtAgregar;
        private MetroFramework.Controls.MetroTile mtVolver;
    }
}