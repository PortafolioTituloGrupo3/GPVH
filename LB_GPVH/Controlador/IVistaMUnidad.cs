using LB_GPVH.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_GPVH.Controlador
{
    public interface IVistaMUnidad
    {
        void CargarUnidadGridview(List<Unidad> unidades);
        void CargarHeadersGridView(List<String> nombrePropiedades); //Permite crear y nombrar las columnas del gridview, la lista de propiedades determina los parametros que asocian a cada columna


    }
}
