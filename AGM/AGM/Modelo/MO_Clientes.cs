using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGM.Clases
{
    class MO_Clientes
    {
        private String Nombre;
        private int Cedula;
        private String Direccion;
        private String correo;
        private String Apellidos;
        private int Telefono;
        private String Genero;

        //Constuctor de la clase clientes.

        public MO_Clientes(string nombre, int cedula, string direccion, string correo, string apellidos, int telefono, string genero)
        {
            Nombre1 = nombre;
            Cedula1 = cedula;
            Direccion1 = direccion;
            this.Correo = correo;
            Apellidos1 = apellidos;
            Telefono1 = telefono;
            Genero1 = genero;
        }

        //ESTOS SON LOS GET Y SET DE LOS ATRIBUTOS.
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int Cedula1 { get => Cedula; set => Cedula = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Apellidos1 { get => Apellidos; set => Apellidos = value; }
        public int Telefono1 { get => Telefono; set => Telefono = value; }
        public string Genero1 { get => Genero; set => Genero = value; }
    }
}
