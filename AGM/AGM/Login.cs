﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Thread th;
        Thread go;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void getUsername()
        {
            if (txtUsuario.Text == "admin")
            {
                getPassword();
            }
        }

        private void getPassword()
        {
         /*   if (txtcontraseña.Text == "123")
            {
                Principal H = new Principal();
                H.Show();
                this.Hide();

            } */
        }

        private void Opennewform(object obj)
        {
            Application.Run(new FrmUsuario());
        }

        private void Opennewform1(object obj)
        {
            Application.Run(new Administrador());
        }




        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "alejo" && txtContraseña.Text == "123456")
            {
                MessageBox.Show("BIENVENIDO", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                getPassword();

                th = new Thread(Opennewform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                Close();
            }

            if (txtUsuario.Text == "admin" && txtContraseña.Text == "alejo")
            {
                go = new Thread(Opennewform1);
                go.SetApartmentState(ApartmentState.STA);
                go.Start();
                Close();
            }

            else  

            {

                MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTA", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtContraseña.Text = "";
            txtUsuario.Text = "";
        }
    }
}
