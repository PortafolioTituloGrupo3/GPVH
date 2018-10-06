﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LB_GPVH.Controlador;

namespace WF_GPVH.Formularios.Menu
{
    public partial class Form_Menu_Jefe_Unidad_Superior : Form
    {
        Login.Form_Login mainForm;
        Sesion sesion;

        public Form_Menu_Jefe_Unidad_Superior(Login.Form_Login pMainForm, Sesion pSesion)
        {
            InitializeComponent();
            mainForm = pMainForm;
            sesion = pSesion;
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Dispose();
        }

        private void Form_Menu_Jefe_Unidad_Superior_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Dispose();
        }
    }
}
