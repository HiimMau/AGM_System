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

namespace AGM.Logica_Negocios
{
    class LN_Cliente
    {
        AD_Cliente iAccesoDatos = new AD_Cliente();
        public Boolean fn_InsertarCliente(MO_Cliente pCliente)
        {
            Cliente sCliente = new Cliente();
            sCliente.DNI = pCliente.VDni;
            sCliente.Nombre = pCliente.VNombre;
             //sCliente.Apellido = pCliente.VApellidos;
            sCliente.FechaNacimiento = pCliente.VFechaNacimiento;
            sCliente.Direccion = pCliente.VDireccion;
            sCliente.Telefono = pCliente.VTelefono;
            sCliente.Correo = pCliente.VCorreo;

            //Ejecutamos la función de inserción de Acceso a Datos
            return iAccesoDatos.fn_InsertarCliente(sCliente);

        }

        public Boolean fn_ActualizarCliente(MO_Cliente pCliente)
        {

            Cliente sCliente = new Cliente();
            sCliente.DNI = pCliente.VDni;
            sCliente.Nombre = pCliente.VNombre;
           // sCliente.Apellido = pCliente.VApellidos;
            sCliente.Telefono = pCliente.VTelefono;
            sCliente.Direccion = pCliente.VDireccion;
            sCliente.FechaNacimiento = pCliente.VFechaNacimiento;
            sCliente.Correo = pCliente.VCorreo;

            //Ejecutamos la función de actualización de Acceso a Datos
            return iAccesoDatos.fn_ActualizaCliente(sCliente);
        }

        public Boolean fn_EliminarCliente(MO_Cliente pCliente)
        {
            Cliente sCliente = new Cliente();
            sCliente.DNI = pCliente.VDni;

            //Ejecutamos la función de eliminación de Acceso a Datos
            return iAccesoDatos.fn_EliminaCliente(sCliente);
        }



        public MO_Cliente fn_ConsultarCliente(MO_Cliente pCliente)
        {
            Cliente iCliente = new Cliente();
            iCliente.DNI = pCliente.VDni;

            //Ejecutamos la función de consulta de Acceso a Datos
            iCliente = iAccesoDatos.fn_ConsultaCliente(iCliente);

            MO_Cliente sCliente = new MO_Cliente();

            sCliente.VDni = iCliente.DNI;
            sCliente.VNombre = iCliente.Nombre;
          //  sCliente.VApellidos = iCliente.Apellido;
            sCliente.VTelefono = iCliente.Telefono;
            sCliente.VDireccion = iCliente.Direccion;
            sCliente.VFechaNacimiento = Convert.ToDateTime(iCliente.FechaNacimiento);
            sCliente.VCorreo = iCliente.Correo;
            return sCliente;
        }

        public List<MO_Cliente> fn_ConsultarClientes()
        {
            List<Cliente> iClientes = new List<Cliente>();
            List<MO_Cliente> sClientes = new List<MO_Cliente>();

            //Ejecutamos la función de consulta de Acceso a Datos
            iClientes = iAccesoDatos.fn_ConsultaClientes();

            foreach (Cliente iCliente in iClientes) 
            {
                MO_Cliente sCliente = new MO_Cliente();
                sCliente.VDni = iCliente.DNI;
                sCliente.VTelefono = iCliente.Nombre;
                sCliente.VDireccion = iCliente.Direccion;
                sCliente.VNombre = iCliente.Nombre;
                sCliente.VFechaNacimiento = Convert.ToDateTime(iCliente.FechaNacimiento);
                sClientes.Add(sCliente);
                sCliente.VCorreo = iCliente.Correo;
            }
            return sClientes;
        }
         







    }


}




