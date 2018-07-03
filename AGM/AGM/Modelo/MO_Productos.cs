using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGM.Clases
{
    class MO_Productos
    {
        private String vCodigoProducto;
        private String vTipoProducto;
        private int vCantidadProducto;
        private String vDescripcionProducto;
        private String vPrecioProducto;
        private String vFabricanteProducto;


        //CONSTRUCTOR DE LA CLASE MO_PRODUCTOS.
        public MO_Productos(string vCodigoProducto, string vTipoProducto, int vCantidadProducto, string vDescripcionProducto, string vPrecioProducto, string vFabricanteProducto)
        {
            this.VCodigoProducto = vCodigoProducto;
            this.VTipoProducto = vTipoProducto;
            this.VCantidadProducto = vCantidadProducto;
            this.VDescripcionProducto = vDescripcionProducto;
            this.VPrecioProducto = vPrecioProducto;
            this.VFabricanteProducto = vFabricanteProducto;
        }


        //GET Y SET DE LOS ATRIBUTOS.
        public string VCodigoProducto { get => vCodigoProducto; set => vCodigoProducto = value; }
        public string VTipoProducto { get => vTipoProducto; set => vTipoProducto = value; }
        public int VCantidadProducto { get => vCantidadProducto; set => vCantidadProducto = value; }
        public string VDescripcionProducto { get => vDescripcionProducto; set => vDescripcionProducto = value; }
        public string VPrecioProducto { get => vPrecioProducto; set => vPrecioProducto = value; }
        public string VFabricanteProducto { get => vFabricanteProducto; set => vFabricanteProducto = value; }
    }

}
