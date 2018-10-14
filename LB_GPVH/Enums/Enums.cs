﻿using System;
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

    public enum TipoPermiso
    {
        FeriadoLegal,
        Administrativo,
        DecesoDeFamiliar,
        NacimientoDeHijo
    }

    public enum EstadoPermiso
    {
        Pendiente = 2,
        Autorizado = 1,
        Rechazado = 0,
    }

    public enum EstadoResolucion
    {
        Pendiente = 2,
        Validado = 1,
        Invalidado = 0,
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
                    throw new Exception("Tipo de usuario no corresponde");
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

    public static class MetodosTipoPermiso
    {
        public static string GetString(TipoPermiso tipo)
        {
            switch (tipo)
            {
                case TipoPermiso.Administrativo:
                    return "Administrativo";
                case TipoPermiso.DecesoDeFamiliar:
                    return "Deceso de Familiar";
                case TipoPermiso.FeriadoLegal:
                    return "Feriado Legal";
                case TipoPermiso.NacimientoDeHijo:
                    return "Nacimiento de Hijo";
                default:
                    return "";
            }
        }

        public static TipoPermiso setTipo(string tipo)
        {
            switch (tipo)
            {
                case "Administrativo":
                    return TipoPermiso.Administrativo;
                case "Deceso de Familiar":
                    return TipoPermiso.DecesoDeFamiliar;
                case "Feriado Legal":
                    return TipoPermiso.FeriadoLegal;
                case "Nacimiento de Hijo":
                    return TipoPermiso.NacimientoDeHijo;
                default:
                    throw new Exception("Tipo de permiso no corresponde");
            }
        }

        public static List<string> Listar()
        {
            List<string> lista = new List<string>();
            lista.Add(GetString(TipoPermiso.Administrativo));
            lista.Add(GetString(TipoPermiso.DecesoDeFamiliar));
            lista.Add(GetString(TipoPermiso.FeriadoLegal));
            lista.Add(GetString(TipoPermiso.NacimientoDeHijo));
            return lista;
        }
    }

}
