using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LB_GPVH.Modelo
{
    public class Antecedentes
    {
        int permisos_administrativos_restantes = -1;
        int feriados_anuales_restantes = -1;
        List<List<object>> filas = new List<List<object>>();

        #region propiedades
        public int Permisos_administrativos_restantes
        {
            get
            {
                return permisos_administrativos_restantes;
            }

            set
            {
                permisos_administrativos_restantes = value;
            }
        }
        public int Feriados_anuales_restantes
        {
            get
            {
                return feriados_anuales_restantes;
            }

            set
            {
                feriados_anuales_restantes = value;
            }
        }
        public List<List<object>> Filas
        {
            get
            {
                return filas;
            }

            set
            {
                filas = value;
            }
        }
        #endregion
        
        //Carga la propiedades mediante un documento
        public void LeerXML(XElement antecedentesXML)
        {
            if (antecedentesXML.Element("permisos_administrativos_restantes") != null)
            {
                try
                {
                    this.permisos_administrativos_restantes = int.Parse(antecedentesXML.Element("permisos_administrativos_restantes").Value);
                }
                catch { };
            }
            if (antecedentesXML.Element("feriados_anuales_restantes") != null)
            {
                this.feriados_anuales_restantes = int.Parse(antecedentesXML.Element("feriados_anuales_restantes").Value);
            }
            if (antecedentesXML.Element("filas") != null)
            {
                try
                {
                    List<List<object>> filasTemp = new List<List<object>>();
                    foreach (XElement fila in antecedentesXML.Element("filas").Elements("fila"))
                    {
                        List<object> filaTemp = new List<object>();
                        filaTemp.Add(int.Parse(fila.Element("estado").Value));
                        filaTemp.Add(fila.Element("tipo_permiso").Value);
                        filaTemp.Add(int.Parse(fila.Element("cantidad").Value));
                        filasTemp.Add(filaTemp);
                    }
                    this.Filas= filasTemp;
                }
                catch { };
            }
        }
    }
}
