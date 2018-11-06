using LB_GPVH.Controlador;
using LB_GPVH.Enums;
using LB_GPVH.Modelo;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_GPVH.SQL
{
    public class UsuarioSQL
    {
        public UsuarioSQL()
        {

        }


        public Usuario autenticarUsuario(string nombre, string clave)
        {
            Usuario usuario = null;
            OracleConnection con = new OracleConnection();
            con.ConnectionString = ConexionSQL.conexionString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from usuario where nombre_usuario = '" + nombre + "' and clave = '" + clave + "'";
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                usuario = new Usuario();
                //Se agregan los datos al objeto unidad
                usuario.Id = reader.GetInt32(0);
                usuario.Nombre = reader.GetString(1);
                usuario.Clave = reader.GetString(2);
                usuario.Tipo = MetodosTipoUsuario.setTipo(reader.GetString(3));
                usuario.Funcionario = new GestionadorFuncionario().BuscarFuncionario((int)reader.GetInt32(4));
            }
            con.Close();
            return usuario;
        }
    }
}
