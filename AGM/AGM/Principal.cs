using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AGM.Logica_Negocios;
using AGM.Logica_Negocio;
using AGM.Modelo;


namespace AGM
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        List<Cliente> vLista_Clientes = new List<Cliente>();
        LN_Cliente iLogica_NegocioCliente = new LN_Cliente();


        List<Proveedor> vLista_Proveedores = new List<Proveedor>();
        LN_Proveedor iLogica_NegocioProveedor = new LN_Proveedor();




        public void fn_limpiar_campos()
        {
            txtDni.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            dtpFecha.Text = "";





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                MO_Cliente iCliente = new MO_Cliente();
                iCliente.VDni = txtDni.Text;
                iCliente.VNombre = txtNombre.Text;
                iCliente.VTelefono = txtTelefono.Text;
                iCliente.VDireccion = txtDireccion.Text;
                iCliente.VTelefono = txtTelefono.Text;
                iCliente.VFechaNacimiento = Convert.ToDateTime(dtpFecha.Text);
                iCliente.VCorreo = txtCorreo.Text;

                if (iLogica_NegocioCliente.fn_ActualizarCliente(iCliente) == true)
                {
                    MessageBox.Show("Cliente Actualizado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fn_limpiar_campos();
                }
                else
                {
                    MessageBox.Show("Cliente NO Actualizado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fn_limpiar_campos();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MO_Cliente iCliente = new MO_Cliente();

            iCliente.VDni = txtDni.Text;
            iCliente.VNombre = txtNombre.Text;
            // iCliente.VApellidos = txtApellidoCliente.Text; 
            iCliente.VDireccion = txtDireccion.Text;
            iCliente.VTelefono = txtTelefono.Text;
            iCliente.VFechaNacimiento = Convert.ToDateTime(dtpFecha.Text);
            iCliente.VCorreo = txtCorreo.Text;


            if (iLogica_NegocioCliente.fn_InsertarCliente(iCliente) == true)
            {
                MessageBox.Show("Cliente Registrado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //cbLista_Conductores.Items.Clear();
                //vGestion.fn_lista_conductores(vLista_Conductores, cbLista_Conductores);
                // fn_limpiar_campos(); 
            }
            else
            {
                MessageBox.Show("Cliente NO Registrado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 // fn_limpiar_campos();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MO_Cliente iCliente = new MO_Cliente();
            iCliente.VDni = txtDni.Text;
        
            if (iLogica_NegocioCliente.fn_EliminarCliente(iCliente) == true)
            {
                MessageBox.Show("Cliente Eliminado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fn_limpiar_campos();
            }
            else
            {
                MessageBox.Show("Cliente NO Eliminado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fn_limpiar_campos();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            MO_Cliente cCliente = new MO_Cliente();
            cCliente.VDni = txtDni.Text;
            MO_Cliente iCliente = iLogica_NegocioCliente.fn_ConsultarCliente(cCliente);
            if (iCliente.VDni != null)
            {
                txtDni.Text = iCliente.VDni;
                txtNombre.Text = iCliente.VNombre;
               /* txtApellidoCliente.Text = iCliente.VApellidos; */
                txtTelefono.Text = iCliente.VTelefono;
                txtDireccion.Text = iCliente.VDireccion;
                // Fecha.Text = iCliente.VFechaNacimiento.ToString();
                txtCorreo.Text = iCliente.VCorreo;
            }
            else
            {
                MessageBox.Show("Cliente NO Registrado", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            MO_Proveedor iProveedor = new MO_Proveedor();

            iProveedor.VDniP = txtDniProv.Text;
            iProveedor.VNombreP = txtNombreProv.Text;
            iProveedor.VDireccionP = txtDireccionProv.Text;
            iProveedor.VNumeroTelP = txtTelefonoProv.Text;
            iProveedor.VTipoP = cbTipoProv.Text;
            iProveedor.VCorreoP = txtCorreoProv.Text;
        
            

            if (iLogica_NegocioProveedor.fn_InsertarProveedor(iProveedor) == true)
            {
                MessageBox.Show("Proveedor Registrado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //cbLista_Conductores.Items.Clear();
                //vGestion.fn_lista_conductores(vLista_Conductores, cbLista_Conductores);
                fn_limpiar_campos();
            }
            else
            {
                MessageBox.Show("Proveedor NO Registrado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fn_limpiar_campos();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MO_Proveedor cProveedor = new MO_Proveedor();
            cProveedor.VDniP = txtDniProv.Text;
            MO_Proveedor iProveedor = iLogica_NegocioProveedor.fn_ConsultarProveedor(cProveedor);
            if (iProveedor.VDniP != null)
            {
                txtDniProv.Text = iProveedor.VDniP;
                txtNombreProv.Text = iProveedor.VNombreP;
                txtTelefonoProv.Text = iProveedor.VNumeroTelP;
                txtDireccionProv.Text = iProveedor.VDireccionP;
                txtCorreoProv.Text = iProveedor.VCorreoP;
                cbTipoProv.Text = iProveedor.VTipoP;
            }
            else
            {
                MessageBox.Show("Proveedor NO Registrado", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


        }
    

        private void btnModificarProv_Click(object sender, EventArgs e)
        {
            {
                MO_Proveedor iProveedor = new MO_Proveedor();
                iProveedor.VDniP = txtDniProv.Text;
                iProveedor.VNombreP = txtNombreProv.Text;
                iProveedor.VDireccionP = txtDireccionProv.Text;
                iProveedor.VNumeroTelP = txtTelefonoProv.Text;
                iProveedor.VTipoP = cbTipoProv.Text;
                iProveedor.VCorreoP = txtCorreoProv.Text;


                if (iLogica_NegocioProveedor.fn_ActualizarProveedor(iProveedor) == true)
                {
                    MessageBox.Show("Proveedor Actualizado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fn_limpiar_campos();
                }
                else
                {
                    MessageBox.Show("Proveedor NO Actualizado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fn_limpiar_campos();
                }
            }






        }

        private void btnEliminarProv_Click(object sender, EventArgs e)
        {
            MO_Proveedor iProveedor = new MO_Proveedor();
            iProveedor.VDniP = txtDniProv.Text;

            if (iLogica_NegocioProveedor.fn_EliminarProveedor(iProveedor) == true)
            {
                MessageBox.Show("Proveedor Eliminado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fn_limpiar_campos();
            }
            else
            {
                MessageBox.Show("Proveedor NO Eliminado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fn_limpiar_campos();
            }






        }
    }
    }
    
    

