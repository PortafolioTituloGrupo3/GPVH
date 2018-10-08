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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.chk_habilitado = new System.Windows.Forms.CheckBox();
            this.ddl_padre = new System.Windows.Forms.ComboBox();
            this.ddl_jefe = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblHabilitado = new System.Windows.Forms.Label();
            this.lblUnidadPadre = new System.Windows.Forms.Label();
            this.lblJefe = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.lblErrorDescripcion = new System.Windows.Forms.Label();
            this.lblErrorDireccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(85, 38);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(121, 20);
            this.txt_nombre.TabIndex = 0;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            this.txt_nombre.Leave += new System.EventHandler(this.txt_nombre_Leave);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(85, 67);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(121, 40);
            this.txt_descripcion.TabIndex = 1;
            this.txt_descripcion.TextChanged += new System.EventHandler(this.txt_descripcion_TextChanged);
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(85, 113);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(121, 20);
            this.txt_direccion.TabIndex = 2;
            this.txt_direccion.TextChanged += new System.EventHandler(this.txt_direccion_TextChanged);
            // 
            // chk_habilitado
            // 
            this.chk_habilitado.AutoSize = true;
            this.chk_habilitado.Location = new System.Drawing.Point(85, 140);
            this.chk_habilitado.Name = "chk_habilitado";
            this.chk_habilitado.Size = new System.Drawing.Size(15, 14);
            this.chk_habilitado.TabIndex = 3;
            this.chk_habilitado.UseVisualStyleBackColor = true;
            this.chk_habilitado.CheckedChanged += new System.EventHandler(this.chk_habilitado_CheckedChanged);
            // 
            // ddl_padre
            // 
            this.ddl_padre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_padre.FormattingEnabled = true;
            this.ddl_padre.Location = new System.Drawing.Point(85, 164);
            this.ddl_padre.Name = "ddl_padre";
            this.ddl_padre.Size = new System.Drawing.Size(121, 21);
            this.ddl_padre.TabIndex = 4;
            this.ddl_padre.SelectedIndexChanged += new System.EventHandler(this.ddl_padre_SelectedIndexChanged);
            // 
            // ddl_jefe
            // 
            this.ddl_jefe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ddl_jefe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_jefe.FormattingEnabled = true;
            this.ddl_jefe.Location = new System.Drawing.Point(85, 192);
            this.ddl_jefe.Name = "ddl_jefe";
            this.ddl_jefe.Size = new System.Drawing.Size(121, 21);
            this.ddl_jefe.TabIndex = 5;
            this.ddl_jefe.SelectedIndexChanged += new System.EventHandler(this.ddl_jefe_SelectedIndexChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(13, 67);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(13, 116);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblHabilitado
            // 
            this.lblHabilitado.AutoSize = true;
            this.lblHabilitado.Location = new System.Drawing.Point(13, 141);
            this.lblHabilitado.Name = "lblHabilitado";
            this.lblHabilitado.Size = new System.Drawing.Size(54, 13);
            this.lblHabilitado.TabIndex = 9;
            this.lblHabilitado.Text = "Habilitado";
            // 
            // lblUnidadPadre
            // 
            this.lblUnidadPadre.AutoSize = true;
            this.lblUnidadPadre.Location = new System.Drawing.Point(13, 167);
            this.lblUnidadPadre.Name = "lblUnidadPadre";
            this.lblUnidadPadre.Size = new System.Drawing.Size(71, 13);
            this.lblUnidadPadre.TabIndex = 10;
            this.lblUnidadPadre.Text = "Unidad padre";
            // 
            // lblJefe
            // 
            this.lblJefe.AutoSize = true;
            this.lblJefe.Location = new System.Drawing.Point(13, 195);
            this.lblJefe.Name = "lblJefe";
            this.lblJefe.Size = new System.Drawing.Size(27, 13);
            this.lblJefe.TabIndex = 11;
            this.lblJefe.Text = "Jefe";
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(85, 219);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 12;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(166, 219);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "Volver";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNombre.Location = new System.Drawing.Point(213, 38);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(87, 13);
            this.lblErrorNombre.TabIndex = 14;
            this.lblErrorNombre.Text = "Caracter Invalido";
            this.lblErrorNombre.Visible = false;
            // 
            // lblErrorDescripcion
            // 
            this.lblErrorDescripcion.AutoSize = true;
            this.lblErrorDescripcion.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDescripcion.Location = new System.Drawing.Point(212, 70);
            this.lblErrorDescripcion.Name = "lblErrorDescripcion";
            this.lblErrorDescripcion.Size = new System.Drawing.Size(87, 13);
            this.lblErrorDescripcion.TabIndex = 15;
            this.lblErrorDescripcion.Text = "Caracter Invalido";
            this.lblErrorDescripcion.Visible = false;
            // 
            // lblErrorDireccion
            // 
            this.lblErrorDireccion.AutoSize = true;
            this.lblErrorDireccion.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDireccion.Location = new System.Drawing.Point(213, 116);
            this.lblErrorDireccion.Name = "lblErrorDireccion";
            this.lblErrorDireccion.Size = new System.Drawing.Size(87, 13);
            this.lblErrorDireccion.TabIndex = 16;
            this.lblErrorDireccion.Text = "Caracter Invalido";
            this.lblErrorDireccion.Visible = false;
            // 
            // Form_M_Unidad_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 267);
            this.Controls.Add(this.lblErrorDireccion);
            this.Controls.Add(this.lblErrorDescripcion);
            this.Controls.Add(this.lblErrorNombre);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_modificar);
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

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.CheckBox chk_habilitado;
        private System.Windows.Forms.ComboBox ddl_padre;
        private System.Windows.Forms.ComboBox ddl_jefe;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblHabilitado;
        private System.Windows.Forms.Label lblUnidadPadre;
        private System.Windows.Forms.Label lblJefe;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.Label lblErrorDescripcion;
        private System.Windows.Forms.Label lblErrorDireccion;
    }
}