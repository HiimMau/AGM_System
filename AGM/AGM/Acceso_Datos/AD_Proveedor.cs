using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGM.Acceso_Datos;
using System.Data.Entity.Infrastructure;
using AGM.Logica_Negocios;
using AGM.Modelo;

namespace AGM.Acceso_Datos
{
    class AD_Proveedor
    {

        public Boolean fn_InsertarProveedor(Proveedor pProveedor)
        {

            try
            {
                using (PracticaEntities contexto = new PracticaEntities())
                {
                    contexto.Database.Connection.Open();
                    // MÉTODO 1: Método Add – Versiones 4.1 y superiores
                    contexto.Proveedor.Add(pProveedor);
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

        public Proveedor fn_ConsultaProveedor(Proveedor pProveedor)
        {
            Proveedor sProveedor = new Proveedor();
            using (PracticaEntities contexto = new PracticaEntities())
            {
                try
                {
                    contexto.Database.Connection.Open();
                    sProveedor = contexto.Proveedor.Where(c => c.DNI == pProveedor.DNI).First();
                }
                catch (Exception e)
                {


                }

            }
            return sProveedor;
        }

        public List<Proveedor> fn_ConsultaProveedores()
        {
            List<Proveedor> sProveedores = new List<Proveedor>();
            using (PracticaEntities contexto = new PracticaEntities())
            {
                try
                {
                    contexto.Database.Connection.Open();
                    sProveedores = contexto.Proveedor.ToList();
                }
                catch (Exception e)
                {


                }
            }
            return sProveedores;
        }


       public Boolean fn_ActualizaProveedor(Proveedor pProveedor)
        {
            try
            {

                using (PracticaEntities contexto = new PracticaEntities())
                {// Realizamos la consulta
                    contexto.Database.Connection.Open();
                    var ProveedorActualizar = contexto.Proveedor.Where(sProveedor => sProveedor.DNI == pProveedor.DNI).First();
                    // Actualizamos el Proveedor            
                    ProveedorActualizar.Nombre = pProveedor.Nombre;
                    ProveedorActualizar.Encargado = pProveedor.Encargado;
                    ProveedorActualizar.NumeroTel = pProveedor.NumeroTel;
                    ProveedorActualizar.Direccion = pProveedor.Direccion;
                    ProveedorActualizar.Correo = pProveedor.Correo;
                    ProveedorActualizar.Tipo = pProveedor.Tipo;

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



        public Boolean fn_EliminaProveedor(Proveedor pProveedor)
        {
            try
            {
                using (PracticaEntities contexto = new PracticaEntities())
                {
                    // Realizamos la consulta
                    contexto.Database.Connection.Open();
                    // Realizamos la consulta
                    var ProveedorEliminar = contexto.Proveedor.Where(sProveedor => sProveedor.DNI == pProveedor.DNI).First();
                    // Eliminamos el Proveedor            
                    contexto.Proveedor.Remove(ProveedorEliminar);     // Para el Framework 4.1 o superior
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
