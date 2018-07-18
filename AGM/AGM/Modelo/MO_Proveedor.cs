using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AGM.Modelo
{
    class MO_Proveedor
    {
        private string vDniP;
        private String vNombreP; //Nombre de la empresa o compañia
        private String vDireccionP;
        private String vCorreoP;
        private String vNumeroTelP;
        private String vTipoP;



        public string VDniP
        {
            get
            {
                return vDniP;
            }

            set
            {
                vDniP = value;
            }
        }

        public string VCorreoP
        {
            get
            {
                return vCorreoP;
            }

            set
            {
                vCorreoP = value;
            }
        }

        public string VNombreP
        {
            get
            {
                return vNombreP;
            }

            set
            {
                vNombreP = value;
            }
        }



        public string VDireccionP
        {
            get
            {
                return vDireccionP;
            }

            set
            {
                vDireccionP = value;
            }
        }

        public string VNumeroTelP
        {
            get
            {
                return vNumeroTelP;
            }

            set
            {
                vNumeroTelP = value;
            }
        }

        public string VTipoP
        {
            get
            {
                return vTipoP;
            }

            set
            {
                vTipoP = value;
            }
        }

    }
}

