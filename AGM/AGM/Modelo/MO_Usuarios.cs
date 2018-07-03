using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGM.Clases
{
    class MO_Usuarios
    {
        private int vId;
        private String vNombre;
        private String vCargo; //ejemplo -> bodega, admin, etc
        private String vCorreo;
        private String vNumCedula;
        private int vNumeroTel;

        //CONSTRUCTOR DE LA CLASE USUARIOS.
        public MO_Usuarios(int vId, string vNombre, string vCargo, string vCorreo, string vNumCedula, int vNumeroTel)
        {
            this.VId = vId;
            this.VNombre = vNombre;
            this.VCargo = vCargo;
            this.VCorreo = vCorreo;
            this.VNumCedula = vNumCedula;
            this.VNumeroTel = vNumeroTel;
        }

        //GET Y SET DE LOS ATRIBUTOS.
        public int VId { get => vId; set => vId = value; }
        public string VNombre { get => vNombre; set => vNombre = value; }
        public string VCargo { get => vCargo; set => vCargo = value; }
        public string VCorreo { get => vCorreo; set => vCorreo = value; }
        public string VNumCedula { get => vNumCedula; set => vNumCedula = value; }
        public int VNumeroTel { get => vNumeroTel; set => vNumeroTel = value; }
    }
}
