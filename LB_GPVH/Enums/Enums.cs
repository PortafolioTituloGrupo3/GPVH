using System;
using System.Collections.Generic;

namespace LB_GPVH.Enums
{
    public enum TipoUsuario
    {
        Administrador,
        JefeUnidadSuperior,
        JefeUnidadInterna,
        Alcalde,
        Funcionario
    }

    public static class MetodosTipoUsuario
    {
        public static string GetString(TipoUsuario tipo)
        {
            switch (tipo)
            {
                case TipoUsuario.Administrador:
                    return "Administrador";
                case TipoUsuario.JefeUnidadSuperior:
                    return "Jefe Unidad Superior";
                case TipoUsuario.JefeUnidadInterna:
                    return "Jefe Unidad Interna";
                case TipoUsuario.Alcalde:
                    return "Alcalde";
                case TipoUsuario.Funcionario:
                    return "Funcionario";
                default:
                    return "";
            }
        }

        public static TipoUsuario setTipo(string tipo)
        {
            switch (tipo)
            {
                case "Administrador":
                    return TipoUsuario.Administrador;
                case "Jefe Unidad Superior":
                    return TipoUsuario.JefeUnidadSuperior;
                case "Jefe Unidad Interna":
                    return TipoUsuario.JefeUnidadInterna;
                case "Alcalde":
                    return TipoUsuario.Alcalde;
                case "Funcionario":
                    return TipoUsuario.Funcionario;
                default:
                    throw new Exception("Tipo no corresponde");
            }
        }

        public static List<string> Listar()
        {
            List<string> lista = new List<string>();
            lista.Add(GetString(TipoUsuario.Administrador));
            lista.Add(GetString(TipoUsuario.JefeUnidadSuperior));
            lista.Add(GetString(TipoUsuario.JefeUnidadInterna));
            lista.Add(GetString(TipoUsuario.Alcalde));
            lista.Add(GetString(TipoUsuario.Funcionario));
            return lista;
        }
    }

}
