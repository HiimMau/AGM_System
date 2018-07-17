using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGM.Modelo
{
    class MO_Cliente
    {
        private string vDni;
        private string vNombre;
        private string vApellidos;
        private DateTime vFechaNacimiento;
        private string vDireccion;
        private string vTelefono;
        private string vCorreo;


        public string VDni
        {
            get
            {
                return vDni;
            }

            set
            {
                vDni = value;
            }
        }

        public string VCorreo
        {
            get
            {
                return vCorreo;
            }

            set
            {
                vCorreo = value;
            }
        }

        public string VNombre
        {
            get
            {
                return vNombre;
            }

            set
            {
                vNombre = value;
            }
        }

        public string VApellidos
        {
            get
            {
                return vApellidos;
            }

            set
            {
                vApellidos = value;
            }
        }

        public DateTime VFechaNacimiento
        {
            get
            {
                return vFechaNacimiento;
            }

            set
            {
                vFechaNacimiento = value;
            }
        }

        public string VDireccion
        {
            get
            {
                return vDireccion;
            }

            set
            {
                vDireccion = value;
            }
        }

        public string VTelefono
        {
            get
            {
                return vTelefono;
            }

            set
            {
                vTelefono = value;
            }
        }


    }
}
