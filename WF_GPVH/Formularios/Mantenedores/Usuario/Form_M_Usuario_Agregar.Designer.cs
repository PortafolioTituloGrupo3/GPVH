namespace WF_GPVH.Formularios.Mantenedores.Usuario
{
    partial class Form_M_Usuario_Agregar
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
            this.Clave = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ddl_funcionarios = new System.Windows.Forms.ComboBox();
            this.ddl_tipo = new System.Windows.Forms.ComboBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(181, 174);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 37;
            this.btn_cancelar.Text = "Volver";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(100, 174);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 36;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Funcionario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Tipo";
            // 
            // Clave
            // 
            this.Clave.AutoSize = true;
            this.Clave.Location = new System.Drawing.Point(28, 96);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(34, 13);
            this.Clave.TabIndex = 33;
            this.Clave.Text = "Clave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre";
            // 
            // ddl_funcionarios
            // 
            this.ddl_funcionarios.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddl_funcionarios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ddl_funcionarios.FormattingEnabled = true;
            this.ddl_funcionarios.Location = new System.Drawing.Point(100, 147);
            this.ddl_funcionarios.Name = "ddl_funcionarios";
            this.ddl_funcionarios.Size = new System.Drawing.Size(121, 21);
            this.ddl_funcionarios.TabIndex = 31;
            // 
            // ddl_tipo
            // 
            this.ddl_tipo.FormattingEnabled = true;
            this.ddl_tipo.Location = new System.Drawing.Point(100, 119);
            this.ddl_tipo.Name = "ddl_tipo";
            this.ddl_tipo.Size = new System.Drawing.Size(121, 21);
            this.ddl_tipo.TabIndex = 30;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(100, 93);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.PasswordChar = '*';
            this.txt_direccion.Size = new System.Drawing.Size(121, 20);
            this.txt_direccion.TabIndex = 29;
            this.txt_direccion.UseSystemPasswordChar = true;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(100, 63);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(121, 20);
            this.txt_nombre.TabIndex = 28;
            // 
            // Form_M_Usuario_Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Clave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddl_funcionarios);
            this.Controls.Add(this.ddl_tipo);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_nombre);
            this.Name = "Form_M_Usuario_Agregar";
            this.Text = "Form_M_Usuario_Agregar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Clave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddl_funcionarios;
        private System.Windows.Forms.ComboBox ddl_tipo;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_nombre;
    }
}