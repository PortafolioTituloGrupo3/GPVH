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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ddl_jefe = new System.Windows.Forms.ComboBox();
            this.ddl_padre = new System.Windows.Forms.ComboBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.lblErrorDescripcion = new System.Windows.Forms.Label();
            this.lblErrorDireccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(180, 188);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 27;
            this.btn_cancelar.Text = "Volver";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(99, 188);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 26;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Jefe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Unidad padre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre";
            // 
            // ddl_jefe
            // 
            this.ddl_jefe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ddl_jefe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_jefe.FormattingEnabled = true;
            this.ddl_jefe.Location = new System.Drawing.Point(99, 161);
            this.ddl_jefe.Name = "ddl_jefe";
            this.ddl_jefe.Size = new System.Drawing.Size(121, 21);
            this.ddl_jefe.TabIndex = 19;
            this.ddl_jefe.SelectedIndexChanged += new System.EventHandler(this.ddl_jefe_SelectedIndexChanged);
            // 
            // ddl_padre
            // 
            this.ddl_padre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_padre.FormattingEnabled = true;
            this.ddl_padre.Location = new System.Drawing.Point(99, 133);
            this.ddl_padre.Name = "ddl_padre";
            this.ddl_padre.Size = new System.Drawing.Size(121, 21);
            this.ddl_padre.TabIndex = 18;
            this.ddl_padre.SelectedIndexChanged += new System.EventHandler(this.ddl_padre_SelectedIndexChanged);
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(99, 107);
            this.txt_direccion.MaxLength = 80;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(121, 20);
            this.txt_direccion.TabIndex = 16;
            this.txt_direccion.TextChanged += new System.EventHandler(this.txt_direccion_TextChanged);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(99, 61);
            this.txt_descripcion.MaxLength = 254;
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(121, 40);
            this.txt_descripcion.TabIndex = 15;
            this.txt_descripcion.TextChanged += new System.EventHandler(this.txt_descripcion_TextChanged);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(99, 32);
            this.txt_nombre.MaxLength = 30;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(121, 20);
            this.txt_nombre.TabIndex = 14;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            this.txt_nombre.Leave += new System.EventHandler(this.txt_nombre_Leave);
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNombre.Location = new System.Drawing.Point(227, 35);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(86, 13);
            this.lblErrorNombre.TabIndex = 28;
            this.lblErrorNombre.Text = "Caracter invalido";
            this.lblErrorNombre.Visible = false;
            // 
            // lblErrorDescripcion
            // 
            this.lblErrorDescripcion.AutoSize = true;
            this.lblErrorDescripcion.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDescripcion.Location = new System.Drawing.Point(227, 61);
            this.lblErrorDescripcion.Name = "lblErrorDescripcion";
            this.lblErrorDescripcion.Size = new System.Drawing.Size(87, 13);
            this.lblErrorDescripcion.TabIndex = 29;
            this.lblErrorDescripcion.Text = "Caracter Invalido";
            this.lblErrorDescripcion.Visible = false;
            // 
            // lblErrorDireccion
            // 
            this.lblErrorDireccion.AutoSize = true;
            this.lblErrorDireccion.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDireccion.Location = new System.Drawing.Point(226, 107);
            this.lblErrorDireccion.Name = "lblErrorDireccion";
            this.lblErrorDireccion.Size = new System.Drawing.Size(87, 13);
            this.lblErrorDireccion.TabIndex = 30;
            this.lblErrorDireccion.Text = "Caracter Invalido";
            this.lblErrorDireccion.Visible = false;
            // 
            // Form_M_Unidad_Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 301);
            this.Controls.Add(this.lblErrorDireccion);
            this.Controls.Add(this.lblErrorDescripcion);
            this.Controls.Add(this.lblErrorNombre);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_agregar);
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

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddl_jefe;
        private System.Windows.Forms.ComboBox ddl_padre;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.Label lblErrorDescripcion;
        private System.Windows.Forms.Label lblErrorDireccion;
    }
}