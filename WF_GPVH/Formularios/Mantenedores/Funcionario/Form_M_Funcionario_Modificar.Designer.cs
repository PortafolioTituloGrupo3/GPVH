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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ddl_tipo = new System.Windows.Forms.ComboBox();
            this.ddl_unidad = new System.Windows.Forms.ComboBox();
            this.chk_habilitado = new System.Windows.Forms.CheckBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_run = new System.Windows.Forms.TextBox();
            this.lbl_run = new System.Windows.Forms.Label();
            this.txt_ap_pat = new System.Windows.Forms.TextBox();
            this.txt_ap_mat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cld_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(199, 273);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 27;
            this.btn_cancelar.Text = "Volver";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(118, 273);
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
            this.label6.Location = new System.Drawing.Point(28, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Unidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tipo funcionario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Habilitado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Correo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre";
            // 
            // ddl_tipo
            // 
            this.ddl_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_tipo.FormattingEnabled = true;
            this.ddl_tipo.Location = new System.Drawing.Point(118, 246);
            this.ddl_tipo.Name = "ddl_tipo";
            this.ddl_tipo.Size = new System.Drawing.Size(121, 21);
            this.ddl_tipo.TabIndex = 19;
            // 
            // ddl_unidad
            // 
            this.ddl_unidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_unidad.FormattingEnabled = true;
            this.ddl_unidad.Location = new System.Drawing.Point(118, 218);
            this.ddl_unidad.Name = "ddl_unidad";
            this.ddl_unidad.Size = new System.Drawing.Size(121, 21);
            this.ddl_unidad.TabIndex = 18;
            // 
            // chk_habilitado
            // 
            this.chk_habilitado.AutoSize = true;
            this.chk_habilitado.Location = new System.Drawing.Point(118, 195);
            this.chk_habilitado.Name = "chk_habilitado";
            this.chk_habilitado.Size = new System.Drawing.Size(15, 14);
            this.chk_habilitado.TabIndex = 17;
            this.chk_habilitado.UseVisualStyleBackColor = true;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(118, 167);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(121, 20);
            this.txt_direccion.TabIndex = 16;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(118, 41);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(121, 20);
            this.txt_nombre.TabIndex = 14;
            // 
            // txt_run
            // 
            this.txt_run.Location = new System.Drawing.Point(118, 12);
            this.txt_run.Name = "txt_run";
            this.txt_run.Size = new System.Drawing.Size(121, 20);
            this.txt_run.TabIndex = 28;
            // 
            // lbl_run
            // 
            this.lbl_run.AutoSize = true;
            this.lbl_run.Location = new System.Drawing.Point(28, 15);
            this.lbl_run.Name = "lbl_run";
            this.lbl_run.Size = new System.Drawing.Size(31, 13);
            this.lbl_run.TabIndex = 29;
            this.lbl_run.Text = "RUN";
            // 
            // txt_ap_pat
            // 
            this.txt_ap_pat.Location = new System.Drawing.Point(118, 67);
            this.txt_ap_pat.Name = "txt_ap_pat";
            this.txt_ap_pat.Size = new System.Drawing.Size(121, 20);
            this.txt_ap_pat.TabIndex = 30;
            // 
            // txt_ap_mat
            // 
            this.txt_ap_mat.Location = new System.Drawing.Point(118, 93);
            this.txt_ap_mat.Name = "txt_ap_mat";
            this.txt_ap_mat.Size = new System.Drawing.Size(121, 20);
            this.txt_ap_mat.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Apellido Paterno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Apellido Materno";
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(118, 141);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(121, 20);
            this.txt_correo.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Fecha nacimiento";
            // 
            // cld_nacimiento
            // 
            this.cld_nacimiento.Location = new System.Drawing.Point(118, 116);
            this.cld_nacimiento.Name = "cld_nacimiento";
            this.cld_nacimiento.Size = new System.Drawing.Size(200, 20);
            this.cld_nacimiento.TabIndex = 37;
            // 
            // Form_M_Funcionario_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 309);
            this.Controls.Add(this.cld_nacimiento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_ap_mat);
            this.Controls.Add(this.txt_ap_pat);
            this.Controls.Add(this.lbl_run);
            this.Controls.Add(this.txt_run);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddl_tipo);
            this.Controls.Add(this.ddl_unidad);
            this.Controls.Add(this.chk_habilitado);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_nombre);
            this.Name = "Form_M_Funcionario_Modificar";
            this.Text = "Form_M_Funcionario_Modificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddl_tipo;
        private System.Windows.Forms.ComboBox ddl_unidad;
        private System.Windows.Forms.CheckBox chk_habilitado;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_run;
        private System.Windows.Forms.Label lbl_run;
        private System.Windows.Forms.TextBox txt_ap_pat;
        private System.Windows.Forms.TextBox txt_ap_mat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker cld_nacimiento;
    }
}