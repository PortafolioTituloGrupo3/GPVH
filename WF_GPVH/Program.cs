using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_GPVH.Formularios.Mantenedores.Unidad;
using WF_GPVH.Formularios.Mantenedores.Funcionario;
using WF_GPVH.Formularios.Mantenedores.Usuario;

namespace WF_GPVH
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_M_Usuario());
        }
    }
}
