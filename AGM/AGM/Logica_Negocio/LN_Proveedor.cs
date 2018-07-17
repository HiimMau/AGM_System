using AGM.Modelo;
using AGM.Acceso_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Collections;

namespace AGM.Logica_Negocio
{
    class LN_Proveedor
    {
        AD_Proveedor iAccesoDatos = new AD_Proveedor();

        public Boolean fn_InsertarProveedor(MO_Proveedor pProveedor)
        {
            Proveedor sProveedor = new Proveedor();
            sProveedor.DNI = pProveedor.VDniP;
            sProveedor.Nombre = pProveedor.VNombreP;
            sProveedor.Direccion = pProveedor.VDireccionP;
            sProveedor.NumeroTel = pProveedor.VNumeroTelP;
            sProveedor.Tipo = pProveedor.VTipoP;
            sProveedor.Correo = pProveedor.VCorreoP;

            //Ejecutamos la función de inserción de Acceso a Datos
            return iAccesoDatos.fn_InsertarProveedor(sProveedor);

        }

        public Boolean fn_ActualizarProveedor(MO_Proveedor pProveedor)
        {

            Proveedor sProveedor = new Proveedor();
            sProveedor.DNI = pProveedor.VDniP;
            sProveedor.Nombre = pProveedor.VNombreP;
            sProveedor.NumeroTel = pProveedor.VNumeroTelP;
            sProveedor.Direccion = pProveedor.VDireccionP;
            sProveedor.Correo = pProveedor.VCorreoP;
            sProveedor.Tipo = pProveedor.VTipoP;

            //Ejecutamos la función de actualización de Acceso a Datos
            return iAccesoDatos.fn_ActualizaProveedor(sProveedor);
        }

        public Boolean fn_EliminarProveedor(MO_Proveedor pProveedor)
        {
            Proveedor sProveedor = new Proveedor();
            sProveedor.DNI = pProveedor.VDniP;

            //Ejecutamos la función de eliminación de Acceso a Datos
            return iAccesoDatos.fn_EliminaProveedor(sProveedor);
        }



        public MO_Proveedor fn_ConsultarProveedor(MO_Proveedor pProveedor)
        {
            Proveedor iProveedor = new Proveedor();
            iProveedor.DNI = pProveedor.VDniP;

            //Ejecutamos la función de consulta de Acceso a Datos
            iProveedor = iAccesoDatos.fn_ConsultaProveedor(iProveedor);

            MO_Proveedor sProveedor = new MO_Proveedor();

            sProveedor.VDniP = iProveedor.DNI;
            sProveedor.VNombreP = iProveedor.Nombre;
            sProveedor.VNumeroTelP = iProveedor.NumeroTel;
            sProveedor.VDireccionP = iProveedor.Direccion;
            sProveedor.VCorreoP = iProveedor.Correo;
            sProveedor.VTipoP = iProveedor.Tipo;
            return sProveedor;
        }

        public List<MO_Proveedor> fn_ConsultarProveedors()
        {
            List<Proveedor> iProveedors = new List<Proveedor>();
            List<MO_Proveedor> sProveedores = new List<MO_Proveedor>();

            //Ejecutamos la función de consulta de Acceso a Datos
            iProveedors = iAccesoDatos.fn_ConsultaProveedores();

            foreach (Proveedor iProveedor in iProveedors)
            {
                MO_Proveedor sProveedor = new MO_Proveedor();
                sProveedor.VDniP = iProveedor.DNI;
                sProveedor.VNombreP = iProveedor.Nombre;
                sProveedor.VNumeroTelP = iProveedor.NumeroTel;
                sProveedor.VDireccionP = iProveedor.Direccion;
                sProveedor.VCorreoP = iProveedor.Correo;
                sProveedor.VTipoP = iProveedor.Tipo;
                sProveedores.Add(sProveedor);

            }
            return sProveedores;
        }
       







    }
}
