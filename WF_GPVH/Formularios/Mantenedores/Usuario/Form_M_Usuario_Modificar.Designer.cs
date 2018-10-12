namespace WF_GPVH.Formularios.Mantenedores.Usuario
{
    partial class Form_M_Usuario_Modificar
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
            this.btn_modificar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Clave = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ddl_funcionarios = new System.Windows.Forms.ComboBox();
            this.ddl_tipo = new System.Windows.Forms.ComboBox();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lblErrorClaveConfirmacion = new System.Windows.Forms.Label();
            this.lblClaveConfirmacion = new System.Windows.Forms.Label();
            this.txt_clave_confirmacion = new System.Windows.Forms.TextBox();
            this.lblErrorClave = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(199, 173);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 27;
            this.btn_cancelar.Text = "Volver";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(118, 173);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 26;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Funcionario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tipo";
            // 
            // Clave
            // 
            this.Clave.AutoSize = true;
            this.Clave.Location = new System.Drawing.Point(28, 61);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(34, 13);
            this.Clave.TabIndex = 22;
            this.Clave.Text = "Clave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre";
            // 
            // ddl_funcionarios
            // 
            this.ddl_funcionarios.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddl_funcionarios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ddl_funcionarios.FormattingEnabled = true;
            this.ddl_funcionarios.Location = new System.Drawing.Point(118, 146);
            this.ddl_funcionarios.Name = "ddl_funcionarios";
            this.ddl_funcionarios.Size = new System.Drawing.Size(121, 21);
            this.ddl_funcionarios.TabIndex = 19;
            this.ddl_funcionarios.SelectedIndexChanged += new System.EventHandler(this.ddl_funcionarios_SelectedIndexChanged);
            // 
            // ddl_tipo
            // 
            this.ddl_tipo.FormattingEnabled = true;
            this.ddl_tipo.Location = new System.Drawing.Point(118, 118);
            this.ddl_tipo.Name = "ddl_tipo";
            this.ddl_tipo.Size = new System.Drawing.Size(121, 21);
            this.ddl_tipo.TabIndex = 18;
            this.ddl_tipo.SelectedIndexChanged += new System.EventHandler(this.ddl_tipo_SelectedIndexChanged);
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(118, 61);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.PasswordChar = '*';
            this.txt_clave.Size = new System.Drawing.Size(121, 20);
            this.txt_clave.TabIndex = 16;
            this.txt_clave.UseSystemPasswordChar = true;
            this.txt_clave.TextChanged += new System.EventHandler(this.txt_clave_TextChanged);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(118, 31);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(121, 20);
            this.txt_nombre.TabIndex = 14;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // lblErrorClaveConfirmacion
            // 
            this.lblErrorClaveConfirmacion.AutoSize = true;
            this.lblErrorClaveConfirmacion.ForeColor = System.Drawing.Color.Red;
            this.lblErrorClaveConfirmacion.Location = new System.Drawing.Point(245, 97);
            this.lblErrorClaveConfirmacion.Name = "lblErrorClaveConfirmacion";
            this.lblErrorClaveConfirmacion.Size = new System.Drawing.Size(108, 13);
            this.lblErrorClaveConfirmacion.TabIndex = 49;
            this.lblErrorClaveConfirmacion.Text = "Clave mal confirmada";
            this.lblErrorClaveConfirmacion.Visible = false;
            // 
            // lblClaveConfirmacion
            // 
            this.lblClaveConfirmacion.AutoSize = true;
            this.lblClaveConfirmacion.Location = new System.Drawing.Point(8, 90);
            this.lblClaveConfirmacion.Name = "lblClaveConfirmacion";
            this.lblClaveConfirmacion.Size = new System.Drawing.Size(104, 13);
            this.lblClaveConfirmacion.TabIndex = 48;
            this.lblClaveConfirmacion.Text = "Clave (Confirmacion)";
            // 
            // txt_clave_confirmacion
            // 
            this.txt_clave_confirmacion.Location = new System.Drawing.Point(118, 90);
            this.txt_clave_confirmacion.Name = "txt_clave_confirmacion";
            this.txt_clave_confirmacion.PasswordChar = '*';
            this.txt_clave_confirmacion.Size = new System.Drawing.Size(121, 20);
            this.txt_clave_confirmacion.TabIndex = 47;
            this.txt_clave_confirmacion.UseSystemPasswordChar = true;
            this.txt_clave_confirmacion.Leave += new System.EventHandler(this.txt_clave_confirmacion_Leave);
            // 
            // lblErrorClave
            // 
            this.lblErrorClave.AutoSize = true;
            this.lblErrorClave.ForeColor = System.Drawing.Color.Red;
            this.lblErrorClave.Location = new System.Drawing.Point(245, 68);
            this.lblErrorClave.Name = "lblErrorClave";
            this.lblErrorClave.Size = new System.Drawing.Size(113, 13);
            this.lblErrorClave.TabIndex = 46;
            this.lblErrorClave.Text = "Clave Usuario Invalido";
            this.lblErrorClave.Visible = false;
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNombre.Location = new System.Drawing.Point(245, 38);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(123, 13);
            this.lblErrorNombre.TabIndex = 45;
            this.lblErrorNombre.Text = "Nombre Usuario Invalido";
            this.lblErrorNombre.Visible = false;
            // 
            // Form_M_Usuario_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 228);
            this.Controls.Add(this.lblErrorClaveConfirmacion);
            this.Controls.Add(this.lblClaveConfirmacion);
            this.Controls.Add(this.txt_clave_confirmacion);
            this.Controls.Add(this.lblErrorClave);
            this.Controls.Add(this.lblErrorNombre);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Clave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddl_funcionarios);
            this.Controls.Add(this.ddl_tipo);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.txt_nombre);
            this.Name = "Form_M_Usuario_Modificar";
            this.Text = "Form_M_Usuario_Modificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Clave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddl_funcionarios;
        private System.Windows.Forms.ComboBox ddl_tipo;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lblErrorClaveConfirmacion;
        private System.Windows.Forms.Label lblClaveConfirmacion;
        private System.Windows.Forms.TextBox txt_clave_confirmacion;
        private System.Windows.Forms.Label lblErrorClave;
        private System.Windows.Forms.Label lblErrorNombre;
    }
}