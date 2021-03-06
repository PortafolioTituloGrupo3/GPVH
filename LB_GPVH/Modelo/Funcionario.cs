﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LB_GPVH.Auxiliares;

namespace LB_GPVH.Modelo
{
    public class Funcionario
    {
        private int run;
        private int dv;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private DateTime fechaNacimiento;
        private string correo;
        private string direccion;
        private string cargo;
        private bool habilitado;
        private Unidad unidad;
        private List<Permiso> permisos;
        
        public Funcionario()
        {
            run = -1;
            dv = -1;
            nombre = "";
            apellidoPaterno = "";
            apellidoMaterno = "";
            correo = "";
            direccion = "";
            cargo = "";
            habilitado = true;
            unidad = null;
            permisos = null;
        }

        #region propiedades
        public List<Permiso> Permisos
        {
            get { return permisos; }
            set { permisos = value; } 
        }
        public string NombreUnidad
        {
            get { return unidad.Nombre; }
        }
        public Unidad Unidad
        {
            get { return unidad; }
            set { unidad = value; }
        }
        public bool Habilitado
        {
            get { return habilitado; }
            set { habilitado = value; }
        }
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public string ApellidoMaterno
        {
            get { return apellidoMaterno; }
            set { apellidoMaterno = value; }
        }
        public string ApellidoPaterno
        {
            get { return apellidoPaterno; }
            set { apellidoPaterno = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Dv
        {
            get { return dv; }
            set { dv = value; }
        }
        public int Run
        {
            get { return run; }
            set { run = value; }
        }
        #endregion

        #region validaciones
        public bool Modulo11(int run, int dv)
        {
            int resto = run, suma = 0, multiplicador = 2;
            if (dv == 0)
                dv = 11;
            while (true)
            {
                suma += multiplicador * (resto % 10);
                resto /= 10;
                if (resto == 0)
                {
                    break;
                }
                if (multiplicador == 7)
                {
                    multiplicador = 2;
                }
                else
                {
                    multiplicador++;
                }
            }
            if (dv == (11 - (suma % 11)))
            {
                this.run = run;
                this.dv = dv;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ValidarDireccion(string pDireccion)
        {
            //Validacion de caracteres
            if (AuxiliarString.ContieneCaracteresInvalidos(pDireccion,true,true,false))
            {
                return false;
            }

            direccion = pDireccion;
            return true;
        }
        public bool ValidarNombre(string pNombre)
        {
            //Validacion de caracteres
            if (!AuxiliarString.ContieneCaracteresAlfabeto(pNombre,false))
            {
                return false;
            }

            nombre = pNombre;
            return true;
        }
        public bool ValidarApellidoPaterno(string pApellidoPaterno)
        {
            //Validacion de caracteres
            if (!AuxiliarString.ContieneCaracteresAlfabeto(pApellidoPaterno, false))
            {
                return false;
            }

            this.apellidoPaterno = pApellidoPaterno;
            return true;
        }
        public bool ValidarApellidoMaterno(string pApellidoMaterno)
        {
            //Validacion de caracteres
            if (!AuxiliarString.ContieneCaracteresAlfabeto(pApellidoMaterno, false))
            {
                return false;
            }

            this.apellidoMaterno = pApellidoMaterno;
            return true;
        }
        public bool ValidarCargo(string pCargo)
        {
            //Validacion de caracteres
            if (!AuxiliarString.ContieneCaracteresAlfabeto(pCargo, false))
            {
                return false;
            }

            this.cargo = pCargo;
            return true;
        }
        public bool ValidarCaracteresCorreo(string pCorreo)
        {
            //Validacion de caracteres
            if (AuxiliarString.ContieneCaracteresInvalidos(pCorreo,false,false, true))
            {
                return false;
            }
            return true;
        }
        public bool ValidarFormatoCorreo(string pCorreo)
        {
            if (!this.ValidarCaracteresCorreo(pCorreo))
                return false;
            if(pCorreo.Count(f => f == '@') != 1)
            {
                return false;
            }
            else
            {
                int arobaPos = 0, pointPos = 0;
                bool caracterEspecialAnterior = false;
                for (int i = 0; i < pCorreo.Length; i++)
                {
                    if (i == 0 || i == pCorreo.Length-1)
                    {
                        if (pCorreo[i] == '@' || pCorreo[i] == '.' || pCorreo[i] == '_')
                        {
                            return false;
                        }
                    }

                    if (pCorreo[i] == '@' || pCorreo[i] == '.' || pCorreo[i] == '_')
                    {
                        if (caracterEspecialAnterior)
                            return false;
                        caracterEspecialAnterior = true;
                    }
                    else
                    {
                        caracterEspecialAnterior = false;
                    }
                    
                    if (pCorreo[i] == '@')
                    {
                        arobaPos = i;
                    }
                    if (pCorreo[i] == '.')
                    {
                        pointPos = i;
                    }
                }
                if(arobaPos >= pointPos-1) // Se asegura que un punto tenga que proceder despues de por lo menos un espacio al caracter a '@' 
                {
                    return false;
                }
                Correo = pCorreo;
                return true;
            }
        }
        public bool ValidaFechaNacimiento(DateTime pFechaNacimiento)
        {
            //Verificar que sea mayor de edad
            if((System.DateTime.Today - pFechaNacimiento).Days < 365.25 * 18)
            {
                return false;
            }
            this.fechaNacimiento = pFechaNacimiento;
            return true;
        }
        #endregion


        //Retorna la concatenacion de nombre y apellidos
        public string NombreCompleto
        {
            get
            {
                return nombre + " " + apellidoPaterno + " " + apellidoMaterno;
            }
        }
        //Carga la propiedades mediante un documento
        public void LeerXML(XElement funcionarioXML)
        {
            if (funcionarioXML.Element("run") != null)
            {
                try
                {
                    this.run = int.Parse(funcionarioXML.Element("run").Value);
                }
                catch { };
            }
            if (funcionarioXML.Element("dv") != null)
            {
                try
                {
                    this.dv = int.Parse(funcionarioXML.Element("dv").Value);
                }
                catch { };
            }
            if (funcionarioXML.Element("nombre") != null)
            {
                this.nombre = funcionarioXML.Element("nombre").Value;
            }
            if (funcionarioXML.Element("apellidoPaterno") != null)
            {
                this.apellidoPaterno = funcionarioXML.Element("apellidoPaterno").Value;
            }
            if (funcionarioXML.Element("apellidoMaterno") != null)
            {
                this.apellidoMaterno = funcionarioXML.Element("apellidoMaterno").Value;
            }
            if (funcionarioXML.Element("fechaNacimiento") != null)
            {
                this.fechaNacimiento = DateTime.Parse(funcionarioXML.Element("fechaNacimiento").Value);
            }
            if (funcionarioXML.Element("correo") != null)
            {
                this.correo = funcionarioXML.Element("correo").Value;
            }
            if (funcionarioXML.Element("direccion") != null)
            {
                this.direccion = funcionarioXML.Element("direccion").Value;
            }
            if (funcionarioXML.Element("cargo") != null)
            {
                this.cargo = funcionarioXML.Element("cargo").Value;
            }
            if (funcionarioXML.Element("habilitado") != null)
            {
                try
                {
                    this.habilitado = (int.Parse(funcionarioXML.Element("habilitado").Value) != 0);
                }
                catch { };
            }
            if (funcionarioXML.Element("Unidad") != null)
            {
                Unidad unidad = new Unidad();
                unidad.LeerXML(funcionarioXML.Element("Unidad"));
                this.unidad = unidad;
            }
        }
    }
}
