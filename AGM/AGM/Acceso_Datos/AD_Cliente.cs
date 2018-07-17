using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGM.Modelo;
using System.Data.Entity.Infrastructure;

namespace AGM.Acceso_Datos
{
    class AD_Cliente
    {
        public Boolean fn_InsertarCliente(Cliente pCliente)
        {

            try
            {
                using (PracticaEntities contexto = new PracticaEntities())
                {
                    contexto.Database.Connection.Open();
                    // MÉTODO 1: Método Add – Versiones 4.1 y superiores
                    contexto.Cliente.Add(pCliente);
                    // Guardamos los cambios
                    contexto.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Cliente fn_ConsultaCliente(Cliente pCliente)
        {
            Cliente sCliente = new Cliente();
            using (PracticaEntities contexto = new PracticaEntities())
            {
                try
                {
                    contexto.Database.Connection.Open();
                    sCliente = contexto.Cliente.Where(c => c.DNI == pCliente.DNI).First();
                }
                catch (Exception e)
                {


                }

            }
            return sCliente;
        }

        public List<Cliente> fn_ConsultaClientes()
        {
            List<Cliente> sClientes = new List<Cliente>();
            using (PracticaEntities contexto = new PracticaEntities())
            {
                try
                {
                    contexto.Database.Connection.Open();
                    sClientes = contexto.Cliente.ToList();
                }
                catch (Exception e)
                {


                }
            }
            return sClientes;
        }


        public Boolean fn_ActualizaCliente(Cliente pCliente)
        {
            try
            {

                using (PracticaEntities contexto = new PracticaEntities())
                {// Realizamos la consulta
                    contexto.Database.Connection.Open();
                    var clienteActualizar = contexto.Cliente.Where(sCliente => sCliente.DNI == pCliente.DNI).First();
                    // Actualizamos el cliente            
                    clienteActualizar.Nombre = pCliente.Nombre;
                  //clienteActualizar.Apellido = pCliente.Apellido;
                    clienteActualizar.Telefono = pCliente.Telefono;
                    clienteActualizar.Direccion = pCliente.Direccion;
                    clienteActualizar.FechaNacimiento = pCliente.FechaNacimiento;
                    clienteActualizar.Correo = pCliente.Correo;

                    // Guardamos los cambios
                    contexto.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }



        public Boolean fn_EliminaCliente(Cliente pCliente)
        {
            try
            {
                using (PracticaEntities contexto = new PracticaEntities())
                {
                    // Realizamos la consulta
                    contexto.Database.Connection.Open();
                    // Realizamos la consulta
                    var clienteEliminar = contexto.Cliente.Where(sCliente => sCliente.DNI == pCliente.DNI).First();
                    // Eliminamos el cliente            
                    contexto.Cliente.Remove(clienteEliminar);     // Para el Framework 4.1 o superior
                    // Guardamos los cambios
                    contexto.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

    }
}
