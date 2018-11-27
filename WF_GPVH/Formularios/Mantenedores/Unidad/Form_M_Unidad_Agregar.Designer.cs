namespace WF_GPVH.Formularios.Mantenedores.Unidad
{
    partial class Form_M_Unidad_Agregar
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
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.ddl_jefe = new MetroFramework.Controls.MetroComboBox();
            this.ddl_padre = new MetroFramework.Controls.MetroComboBox();
            this.txt_direccion = new MetroFramework.Controls.MetroTextBox();
            this.txt_descripcion = new MetroFramework.Controls.MetroTextBox();
            this.txt_nombre = new MetroFramework.Controls.MetroTextBox();
            this.lblErrorNombre = new MetroFramework.Controls.MetroLabel();
            this.lblErrorDescripcion = new MetroFramework.Controls.MetroLabel();
            this.lblErrorDireccion = new MetroFramework.Controls.MetroLabel();
            this.mtAgregar = new MetroFramework.Controls.MetroTile();
            this.mtVolver = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Jefe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Unidad padre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre";
            // 
            // ddl_jefe
            // 
            this.ddl_jefe.FormattingEnabled = true;
            this.ddl_jefe.ItemHeight = 23;
            this.ddl_jefe.Location = new System.Drawing.Point(121, 198);
            this.ddl_jefe.Name = "ddl_jefe";
            this.ddl_jefe.Size = new System.Drawing.Size(121, 29);
            this.ddl_jefe.TabIndex = 5;
            this.ddl_jefe.UseSelectable = true;
            this.ddl_jefe.SelectedIndexChanged += new System.EventHandler(this.ddl_padre_SelectedIndexChanged);
            // 
            // ddl_padre
            // 
            this.ddl_padre.FormattingEnabled = true;
            this.ddl_padre.ItemHeight = 23;
            this.ddl_padre.Location = new System.Drawing.Point(121, 163);
            this.ddl_padre.Name = "ddl_padre";
            this.ddl_padre.Size = new System.Drawing.Size(121, 29);
            this.ddl_padre.TabIndex = 4;
            this.ddl_padre.UseSelectable = true;
            this.ddl_padre.SelectedIndexChanged += new System.EventHandler(this.ddl_padre_SelectedIndexChanged);
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
            this.txt_direccion.Location = new System.Drawing.Point(121, 137);
            this.txt_direccion.MaxLength = 80;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.PasswordChar = '\0';
            this.txt_direccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_direccion.SelectedText = "";
            this.txt_direccion.SelectionLength = 0;
            this.txt_direccion.SelectionStart = 0;
            this.txt_direccion.ShortcutsEnabled = true;
            this.txt_direccion.Size = new System.Drawing.Size(121, 20);
            this.txt_direccion.TabIndex = 3;
            this.txt_direccion.UseSelectable = true;
            this.txt_direccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_direccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_direccion.TextChanged += new System.EventHandler(this.txt_direccion_TextChanged);
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
            this.txt_descripcion.Location = new System.Drawing.Point(121, 91);
            this.txt_descripcion.MaxLength = 254;
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.PasswordChar = '\0';
            this.txt_descripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_descripcion.SelectedText = "";
            this.txt_descripcion.SelectionLength = 0;
            this.txt_descripcion.SelectionStart = 0;
            this.txt_descripcion.ShortcutsEnabled = true;
            this.txt_descripcion.Size = new System.Drawing.Size(121, 40);
            this.txt_descripcion.TabIndex = 2;
            this.txt_descripcion.UseSelectable = true;
            this.txt_descripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_descripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_descripcion.TextChanged += new System.EventHandler(this.txt_descripcion_TextChanged);
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
            this.txt_nombre.Location = new System.Drawing.Point(121, 62);
            this.txt_nombre.MaxLength = 30;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PasswordChar = '\0';
            this.txt_nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_nombre.SelectedText = "";
            this.txt_nombre.SelectionLength = 0;
            this.txt_nombre.SelectionStart = 0;
            this.txt_nombre.ShortcutsEnabled = true;
            this.txt_nombre.Size = new System.Drawing.Size(121, 20);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.UseSelectable = true;
            this.txt_nombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_nombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            this.txt_nombre.Leave += new System.EventHandler(this.txt_nombre_Leave);
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNombre.Location = new System.Drawing.Point(249, 65);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(108, 19);
            this.lblErrorNombre.TabIndex = 28;
            this.lblErrorNombre.Text = "Caracter invalido";
            this.lblErrorNombre.UseCustomForeColor = true;
            this.lblErrorNombre.Visible = false;
            // 
            // lblErrorDescripcion
            // 
            this.lblErrorDescripcion.AutoSize = true;
            this.lblErrorDescripcion.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDescripcion.Location = new System.Drawing.Point(249, 91);
            this.lblErrorDescripcion.Name = "lblErrorDescripcion";
            this.lblErrorDescripcion.Size = new System.Drawing.Size(108, 19);
            this.lblErrorDescripcion.TabIndex = 29;
            this.lblErrorDescripcion.Text = "Caracter Invalido";
            this.lblErrorDescripcion.UseCustomForeColor = true;
            this.lblErrorDescripcion.Visible = false;
            // 
            // lblErrorDireccion
            // 
            this.lblErrorDireccion.AutoSize = true;
            this.lblErrorDireccion.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDireccion.Location = new System.Drawing.Point(248, 137);
            this.lblErrorDireccion.Name = "lblErrorDireccion";
            this.lblErrorDireccion.Size = new System.Drawing.Size(108, 19);
            this.lblErrorDireccion.TabIndex = 30;
            this.lblErrorDireccion.Text = "Caracter Invalido";
            this.lblErrorDireccion.UseCustomForeColor = true;
            this.lblErrorDireccion.Visible = false;
            // 
            // mtAgregar
            // 
            this.mtAgregar.ActiveControl = null;
            this.mtAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mtAgregar.Location = new System.Drawing.Point(24, 277);
            this.mtAgregar.Name = "mtAgregar";
            this.mtAgregar.Size = new System.Drawing.Size(91, 62);
            this.mtAgregar.TabIndex = 6;
            this.mtAgregar.Text = "Agregar";
            this.mtAgregar.UseSelectable = true;
            this.mtAgregar.Click += new System.EventHandler(this.mtAgregar_Click);
            // 
            // mtVolver
            // 
            this.mtVolver.ActiveControl = null;
            this.mtVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtVolver.Location = new System.Drawing.Point(393, 277);
            this.mtVolver.Name = "mtVolver";
            this.mtVolver.Size = new System.Drawing.Size(91, 62);
            this.mtVolver.TabIndex = 7;
            this.mtVolver.Text = "Volver";
            this.mtVolver.UseSelectable = true;
            this.mtVolver.Click += new System.EventHandler(this.mtVolver_Click);
            // 
            // Form_M_Unidad_Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 353);
            this.Controls.Add(this.mtVolver);
            this.Controls.Add(this.mtAgregar);
            this.Controls.Add(this.lblErrorDireccion);
            this.Controls.Add(this.lblErrorDescripcion);
            this.Controls.Add(this.lblErrorNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddl_jefe);
            this.Controls.Add(this.ddl_padre);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_nombre);
            this.Name = "Form_M_Unidad_Agregar";
            this.Text = "Form_M_Unidad_Agregar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_M_Unidad_Agregar_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel label6;
        private MetroFramework.Controls.MetroLabel label5;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroComboBox ddl_jefe;
        private MetroFramework.Controls.MetroComboBox ddl_padre;
        private MetroFramework.Controls.MetroTextBox txt_direccion;
        private MetroFramework.Controls.MetroTextBox txt_descripcion;
        private MetroFramework.Controls.MetroTextBox txt_nombre;
        private MetroFramework.Controls.MetroLabel lblErrorNombre;
        private MetroFramework.Controls.MetroLabel lblErrorDescripcion;
        private MetroFramework.Controls.MetroLabel lblErrorDireccion;
        private MetroFramework.Controls.MetroTile mtAgregar;
        private MetroFramework.Controls.MetroTile mtVolver;
    }
}