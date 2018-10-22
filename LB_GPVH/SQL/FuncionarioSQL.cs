using LB_GPVH.Controlador;
using LB_GPVH.Modelo;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_GPVH.SQL
{
    class FuncionarioSQL
    {

        /// <summary>
        /// Lista todos los funcionarios pertenecientes a una unidad en especifica y de todas sus unidades hijas directas.
        /// </summary>
        /// <param name="idUnidad"></param>
        /// <returns></returns>
        public List<Funcionario> getListadoFuncionariosHijosUnidad(int idUnidad)
        {
            List<Funcionario> ListadoFuncionario = new List<Funcionario>();
            //Creacion de comando Oracle
            OracleConnection con = new OracleConnection();
            con.ConnectionString = ConexionSQL.conexionString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "select f.run_sin_dv, f.run_dv ,f.nom_funcionario ,f.ap_paterno ,f.ap_materno ,f.fec_nacimiento ,f.correo ,f.direc_funcionario ,f.cargo ,f.habilitado, f.unidad_id_unidad " +
                "from funcionario f " +
                "left join unidad u on u.id_unidad = f.unidad_id_unidad " +
                "left join unidad pa on u.unidad_padre_id_unidad = pa.id_unidad " +
                "where u.id_unidad = "+idUnidad+" OR pa.id_unidad = "+idUnidad;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //Se crea un objeto unidad vacio
                Funcionario funcionario = new Funcionario();
                //Se agregan los datos al objeto unidad
                funcionario.Run = reader.GetInt32(0);
                funcionario.Dv = reader.GetInt32(1);
                funcionario.Nombre = reader.GetString(2);
                funcionario.ApellidoPaterno = reader.GetString(3);
                funcionario.ApellidoMaterno = reader.GetString(4);
                funcionario.FechaNacimiento = reader.GetDateTime(5);
                funcionario.Correo = reader.GetString(6);
                funcionario.Direccion = reader.GetString(7);
                funcionario.Cargo = reader.GetString(8);
                funcionario.Habilitado = reader.GetInt32(9) != 0;
                funcionario.Unidad = new GestionadorUnidad().BuscarPorIdParcial(reader.GetInt32(10)); reader.GetInt32(10);
                //Se agrega la unidad
                ListadoFuncionario.Add(funcionario);
            }
            con.Close();
            return ListadoFuncionario;
        }
    }
}
