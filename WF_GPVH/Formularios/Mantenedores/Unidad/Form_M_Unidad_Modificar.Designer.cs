namespace WF_GPVH.Formularios.Mantenedores.Unidad
{
    partial class Form_M_Unidad_Modificar
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
            this.txt_nombre = new MetroFramework.Controls.MetroTextBox();
            this.txt_descripcion = new MetroFramework.Controls.MetroTextBox();
            this.txt_direccion = new MetroFramework.Controls.MetroTextBox();
            this.chk_habilitado = new System.Windows.Forms.CheckBox();
            this.ddl_padre = new MetroFramework.Controls.MetroComboBox();
            this.ddl_jefe = new MetroFramework.Controls.MetroComboBox();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.lblDescripcion = new MetroFramework.Controls.MetroLabel();
            this.lblDireccion = new MetroFramework.Controls.MetroLabel();
            this.lblHabilitado = new MetroFramework.Controls.MetroLabel();
            this.lblUnidadPadre = new MetroFramework.Controls.MetroLabel();
            this.lblJefe = new MetroFramework.Controls.MetroLabel();
            this.lblErrorNombre = new MetroFramework.Controls.MetroLabel();
            this.lblErrorDescripcion = new MetroFramework.Controls.MetroLabel();
            this.lblErrorDireccion = new MetroFramework.Controls.MetroLabel();
            this.mtAgregar = new MetroFramework.Controls.MetroTile();
            this.mtVolver = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
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
            this.txt_nombre.Location = new System.Drawing.Point(138, 58);
            this.txt_nombre.MaxLength = 32767;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PasswordChar = '\0';
            this.txt_nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_nombre.SelectedText = "";
            this.txt_nombre.SelectionLength = 0;
            this.txt_nombre.SelectionStart = 0;
            this.txt_nombre.ShortcutsEnabled = true;
            this.txt_nombre.Size = new System.Drawing.Size(121, 20);
            this.txt_nombre.TabIndex = 0;
            this.txt_nombre.UseSelectable = true;
            this.txt_nombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_nombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            this.txt_nombre.Leave += new System.EventHandler(this.txt_nombre_Leave);
            // 
            // txt_descripcion
            // 
            // 
            // 
            // 
            this.txt_descripcion.CustomButton.Image = null;
            this.txt_descripcion.CustomButton.Location = new System.Drawing.Point(83, 2);
            this.txt_descripcion.CustomButton.Name = "";
            this.txt_descripcion.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txt_descripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_descripcion.CustomButton.TabIndex = 1;
            this.txt_descripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_descripcion.CustomButton.UseSelectable = true;
            this.txt_descripcion.CustomButton.Visible = false;
            this.txt_descripcion.Lines = new string[0];
            this.txt_descripcion.Location = new System.Drawing.Point(138, 87);
            this.txt_descripcion.MaxLength = 32767;
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.PasswordChar = '\0';
            this.txt_descripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_descripcion.SelectedText = "";
            this.txt_descripcion.SelectionLength = 0;
            this.txt_descripcion.SelectionStart = 0;
            this.txt_descripcion.ShortcutsEnabled = true;
            this.txt_descripcion.Size = new System.Drawing.Size(121, 40);
            this.txt_descripcion.TabIndex = 1;
            this.txt_descripcion.UseSelectable = true;
            this.txt_descripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_descripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_descripcion.TextChanged += new System.EventHandler(this.txt_descripcion_TextChanged);
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
            this.txt_direccion.Location = new System.Drawing.Point(138, 133);
            this.txt_direccion.MaxLength = 32767;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.PasswordChar = '\0';
            this.txt_direccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_direccion.SelectedText = "";
            this.txt_direccion.SelectionLength = 0;
            this.txt_direccion.SelectionStart = 0;
            this.txt_direccion.ShortcutsEnabled = true;
            this.txt_direccion.Size = new System.Drawing.Size(121, 20);
            this.txt_direccion.TabIndex = 2;
            this.txt_direccion.UseSelectable = true;
            this.txt_direccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_direccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_direccion.TextChanged += new System.EventHandler(this.txt_direccion_TextChanged);
            // 
            // chk_habilitado
            // 
            this.chk_habilitado.AutoSize = true;
            this.chk_habilitado.Location = new System.Drawing.Point(138, 158);
            this.chk_habilitado.Name = "chk_habilitado";
            this.chk_habilitado.Size = new System.Drawing.Size(15, 14);
            this.chk_habilitado.TabIndex = 3;
            this.chk_habilitado.UseVisualStyleBackColor = true;
            this.chk_habilitado.CheckedChanged += new System.EventHandler(this.chk_habilitado_CheckedChanged);
            // 
            // ddl_padre
            // 
            this.ddl_padre.FormattingEnabled = true;
            this.ddl_padre.ItemHeight = 23;
            this.ddl_padre.Location = new System.Drawing.Point(138, 184);
            this.ddl_padre.Name = "ddl_padre";
            this.ddl_padre.Size = new System.Drawing.Size(121, 29);
            this.ddl_padre.TabIndex = 4;
            this.ddl_padre.UseSelectable = true;
            this.ddl_padre.SelectedIndexChanged += new System.EventHandler(this.ddl_padre_SelectedIndexChanged);
            // 
            // ddl_jefe
            // 
            this.ddl_jefe.FormattingEnabled = true;
            this.ddl_jefe.ItemHeight = 23;
            this.ddl_jefe.Location = new System.Drawing.Point(138, 219);
            this.ddl_jefe.Name = "ddl_jefe";
            this.ddl_jefe.Size = new System.Drawing.Size(121, 29);
            this.ddl_jefe.TabIndex = 5;
            this.ddl_jefe.UseSelectable = true;
            this.ddl_jefe.SelectedIndexChanged += new System.EventHandler(this.ddl_jefe_SelectedIndexChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 19);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(28, 84);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(76, 19);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(28, 133);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(63, 19);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblHabilitado
            // 
            this.lblHabilitado.AutoSize = true;
            this.lblHabilitado.Location = new System.Drawing.Point(28, 158);
            this.lblHabilitado.Name = "lblHabilitado";
            this.lblHabilitado.Size = new System.Drawing.Size(69, 19);
            this.lblHabilitado.TabIndex = 9;
            this.lblHabilitado.Text = "Habilitado";
            // 
            // lblUnidadPadre
            // 
            this.lblUnidadPadre.AutoSize = true;
            this.lblUnidadPadre.Location = new System.Drawing.Point(28, 184);
            this.lblUnidadPadre.Name = "lblUnidadPadre";
            this.lblUnidadPadre.Size = new System.Drawing.Size(90, 19);
            this.lblUnidadPadre.TabIndex = 10;
            this.lblUnidadPadre.Text = "Unidad padre";
            // 
            // lblJefe
            // 
            this.lblJefe.AutoSize = true;
            this.lblJefe.Location = new System.Drawing.Point(28, 219);
            this.lblJefe.Name = "lblJefe";
            this.lblJefe.Size = new System.Drawing.Size(32, 19);
            this.lblJefe.TabIndex = 11;
            this.lblJefe.Text = "Jefe";
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNombre.Location = new System.Drawing.Point(266, 58);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(108, 19);
            this.lblErrorNombre.TabIndex = 14;
            this.lblErrorNombre.Text = "Caracter Invalido";
            this.lblErrorNombre.Visible = false;
            // 
            // lblErrorDescripcion
            // 
            this.lblErrorDescripcion.AutoSize = true;
            this.lblErrorDescripcion.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDescripcion.Location = new System.Drawing.Point(265, 90);
            this.lblErrorDescripcion.Name = "lblErrorDescripcion";
            this.lblErrorDescripcion.Size = new System.Drawing.Size(108, 19);
            this.lblErrorDescripcion.TabIndex = 15;
            this.lblErrorDescripcion.Text = "Caracter Invalido";
            this.lblErrorDescripcion.Visible = false;
            // 
            // lblErrorDireccion
            // 
            this.lblErrorDireccion.AutoSize = true;
            this.lblErrorDireccion.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDireccion.Location = new System.Drawing.Point(266, 136);
            this.lblErrorDireccion.Name = "lblErrorDireccion";
            this.lblErrorDireccion.Size = new System.Drawing.Size(108, 19);
            this.lblErrorDireccion.TabIndex = 16;
            this.lblErrorDireccion.Text = "Caracter Invalido";
            this.lblErrorDireccion.Visible = false;
            // 
            // mtAgregar
            // 
            this.mtAgregar.ActiveControl = null;
            this.mtAgregar.Location = new System.Drawing.Point(28, 312);
            this.mtAgregar.Name = "mtAgregar";
            this.mtAgregar.Size = new System.Drawing.Size(90, 58);
            this.mtAgregar.TabIndex = 17;
            this.mtAgregar.Text = "Agregar";
            this.mtAgregar.UseSelectable = true;
            this.mtAgregar.Click += new System.EventHandler(this.mtAgregar_Click);
            // 
            // mtVolver
            // 
            this.mtVolver.ActiveControl = null;
            this.mtVolver.Location = new System.Drawing.Point(265, 312);
            this.mtVolver.Name = "mtVolver";
            this.mtVolver.Size = new System.Drawing.Size(90, 58);
            this.mtVolver.TabIndex = 18;
            this.mtVolver.Text = "Volver";
            this.mtVolver.UseSelectable = true;
            this.mtVolver.Click += new System.EventHandler(this.mtVolver_Click);
            // 
            // Form_M_Unidad_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 393);
            this.Controls.Add(this.mtVolver);
            this.Controls.Add(this.mtAgregar);
            this.Controls.Add(this.lblErrorDireccion);
            this.Controls.Add(this.lblErrorDescripcion);
            this.Controls.Add(this.lblErrorNombre);
            this.Controls.Add(this.lblJefe);
            this.Controls.Add(this.lblUnidadPadre);
            this.Controls.Add(this.lblHabilitado);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.ddl_jefe);
            this.Controls.Add(this.ddl_padre);
            this.Controls.Add(this.chk_habilitado);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_nombre);
            this.Name = "Form_M_Unidad_Modificar";
            this.Text = "Form_M_Unidad_Modificar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_M_Unidad_Modificar_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_nombre;
        private MetroFramework.Controls.MetroTextBox txt_descripcion;
        private MetroFramework.Controls.MetroTextBox txt_direccion;
        private System.Windows.Forms.CheckBox chk_habilitado;
        private MetroFramework.Controls.MetroComboBox ddl_padre;
        private MetroFramework.Controls.MetroComboBox ddl_jefe;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private MetroFramework.Controls.MetroLabel lblDescripcion;
        private MetroFramework.Controls.MetroLabel lblDireccion;
        private MetroFramework.Controls.MetroLabel lblHabilitado;
        private MetroFramework.Controls.MetroLabel lblUnidadPadre;
        private MetroFramework.Controls.MetroLabel lblJefe;
        private MetroFramework.Controls.MetroLabel lblErrorNombre;
        private MetroFramework.Controls.MetroLabel lblErrorDescripcion;
        private MetroFramework.Controls.MetroLabel lblErrorDireccion;
        private MetroFramework.Controls.MetroTile mtAgregar;
        private MetroFramework.Controls.MetroTile mtVolver;
    }
}