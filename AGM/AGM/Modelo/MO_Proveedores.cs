using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGM.Clases
{
    class MO_Proveedores
    {
        private int vId; 
        private int vCedJuridica; //cedula juridica.
        private String vNombre; //Nombre de la empresa o compañia
        private String vDireccion;
        private String vCorreo;
        private int vNumeroTel;
        private String vTipo;

        public MO_Proveedores(string vTipo)
        {
            this.VTipo = vTipo;
        }


        //CONSTRUCTOR DE LA CLASE PROVEEDORES.
        public MO_Proveedores(int vId, int vCedJuridica, string vNombre, string vDireccion, string vCorreo, int vNumeroTel)
        {
            this.VId = vId;
            this.VCedJuridica = vCedJuridica;
            this.VNombre = vNombre;
            this.VDireccion = vDireccion;
            this.VCorreo = vCorreo;
            this.VNumeroTel = vNumeroTel;
            
        }

        //GET Y SET DE LOS ATRIBUTOS
        public int VId { get => vId; set => vId = value; }
        public int VCedJuridica { get => vCedJuridica; set => vCedJuridica = value; }
        public string VNombre { get => vNombre; set => vNombre = value; }
        public string VDireccion { get => vDireccion; set => vDireccion = value; }
        public string VCorreo { get => vCorreo; set => vCorreo = value; }
        public int VNumeroTel { get => vNumeroTel; set => vNumeroTel = value; }
        public string VTipo { get => vTipo; set => vTipo = value; }
    }
}
