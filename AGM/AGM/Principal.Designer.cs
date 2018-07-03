namespace AGM
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.txt_Cedula = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lbl_Cedula = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbl_Correo = new System.Windows.Forms.Label();
            this.lbl_NombrePro = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.txt_CodPro = new System.Windows.Forms.TextBox();
            this.txt_NombrePro = new System.Windows.Forms.TextBox();
            this.txt_TipoPro = new System.Windows.Forms.TextBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.RichTextBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 696);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_Correo);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.lbl_Direccion);
            this.tabPage1.Controls.Add(this.lbl_Cedula);
            this.tabPage1.Controls.Add(this.lbl_Nombre);
            this.tabPage1.Controls.Add(this.txt_Correo);
            this.tabPage1.Controls.Add(this.txt_Cedula);
            this.tabPage1.Controls.Add(this.txt_Nombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 670);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cliente";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(6, 34);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(96, 13);
            this.lbl_Nombre.TabIndex = 5;
            this.lbl_Nombre.Text = "Nombre del Cliente";
            this.lbl_Nombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Correo
            // 
            this.txt_Correo.ForeColor = System.Drawing.Color.Silver;
            this.txt_Correo.Location = new System.Drawing.Point(690, 95);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(258, 20);
            this.txt_Correo.TabIndex = 3;
            this.txt_Correo.Text = "alguien@algo.com";
            // 
            // txt_Cedula
            // 
            this.txt_Cedula.ForeColor = System.Drawing.Color.Silver;
            this.txt_Cedula.Location = new System.Drawing.Point(660, 27);
            this.txt_Cedula.Name = "txt_Cedula";
            this.txt_Cedula.Size = new System.Drawing.Size(288, 20);
            this.txt_Cedula.TabIndex = 1;
            this.txt_Cedula.Text = "Sin guiones";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.ForeColor = System.Drawing.Color.Silver;
            this.txt_Nombre.Location = new System.Drawing.Point(116, 31);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(367, 20);
            this.txt_Nombre.TabIndex = 0;
            this.txt_Nombre.Text = "Nombre y apellidos";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_Precio);
            this.tabPage2.Controls.Add(this.txt_Descripcion);
            this.tabPage2.Controls.Add(this.txt_Cantidad);
            this.tabPage2.Controls.Add(this.txt_TipoPro);
            this.tabPage2.Controls.Add(this.txt_NombrePro);
            this.tabPage2.Controls.Add(this.txt_CodPro);
            this.tabPage2.Controls.Add(this.lbl_Precio);
            this.tabPage2.Controls.Add(this.lbl_Tipo);
            this.tabPage2.Controls.Add(this.lbl_Cantidad);
            this.tabPage2.Controls.Add(this.lbl_Codigo);
            this.tabPage2.Controls.Add(this.lbl_Descripcion);
            this.tabPage2.Controls.Add(this.lbl_NombrePro);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 670);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Proveedores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(976, 670);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Facturar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(976, 670);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Productos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lbl_Cedula
            // 
            this.lbl_Cedula.AutoSize = true;
            this.lbl_Cedula.Location = new System.Drawing.Point(559, 34);
            this.lbl_Cedula.Name = "lbl_Cedula";
            this.lbl_Cedula.Size = new System.Drawing.Size(95, 13);
            this.lbl_Cedula.TabIndex = 6;
            this.lbl_Cedula.Text = "Numero de Cedula";
            this.lbl_Cedula.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Location = new System.Drawing.Point(6, 95);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(55, 13);
            this.lbl_Direccion.TabIndex = 7;
            this.lbl_Direccion.Text = "Dirección.";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(116, 95);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(367, 140);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.Location = new System.Drawing.Point(562, 101);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(94, 13);
            this.lbl_Correo.TabIndex = 9;
            this.lbl_Correo.Text = "Correo Electronico";
            // 
            // lbl_NombrePro
            // 
            this.lbl_NombrePro.AutoSize = true;
            this.lbl_NombrePro.Location = new System.Drawing.Point(27, 49);
            this.lbl_NombrePro.Name = "lbl_NombrePro";
            this.lbl_NombrePro.Size = new System.Drawing.Size(107, 13);
            this.lbl_NombrePro.TabIndex = 0;
            this.lbl_NombrePro.Text = "Nombre del Producto";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(27, 185);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(125, 13);
            this.lbl_Descripcion.TabIndex = 1;
            this.lbl_Descripcion.Text = "Descripción del producto";
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Location = new System.Drawing.Point(717, 24);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(102, 13);
            this.lbl_Codigo.TabIndex = 2;
            this.lbl_Codigo.Text = "Codigo del producto";
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(717, 108);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(115, 13);
            this.lbl_Cantidad.TabIndex = 3;
            this.lbl_Cantidad.Text = "Cantidad de Productos";
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Location = new System.Drawing.Point(27, 105);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(92, 13);
            this.lbl_Tipo.TabIndex = 4;
            this.lbl_Tipo.Text = "Tipro de Producto";
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Location = new System.Drawing.Point(719, 169);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(100, 13);
            this.lbl_Precio.TabIndex = 5;
            this.lbl_Precio.Text = "Precio del Producto";
            // 
            // txt_CodPro
            // 
            this.txt_CodPro.Location = new System.Drawing.Point(837, 21);
            this.txt_CodPro.Name = "txt_CodPro";
            this.txt_CodPro.Size = new System.Drawing.Size(133, 20);
            this.txt_CodPro.TabIndex = 6;
            // 
            // txt_NombrePro
            // 
            this.txt_NombrePro.Location = new System.Drawing.Point(166, 46);
            this.txt_NombrePro.Name = "txt_NombrePro";
            this.txt_NombrePro.Size = new System.Drawing.Size(244, 20);
            this.txt_NombrePro.TabIndex = 7;
            // 
            // txt_TipoPro
            // 
            this.txt_TipoPro.ForeColor = System.Drawing.Color.Silver;
            this.txt_TipoPro.Location = new System.Drawing.Point(166, 105);
            this.txt_TipoPro.Name = "txt_TipoPro";
            this.txt_TipoPro.Size = new System.Drawing.Size(244, 20);
            this.txt_TipoPro.TabIndex = 8;
            this.txt_TipoPro.Text = "Cinta, plastico";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(870, 105);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_Cantidad.TabIndex = 9;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(166, 241);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(567, 143);
            this.txt_Descripcion.TabIndex = 10;
            this.txt_Descripcion.Text = "";
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(846, 169);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(124, 20);
            this.txt_Precio.TabIndex = 11;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 795);
            this.Controls.Add(this.tabControl1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.TextBox txt_Cedula;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Cedula;
        private System.Windows.Forms.Label lbl_Correo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.RichTextBox txt_Descripcion;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.TextBox txt_TipoPro;
        private System.Windows.Forms.TextBox txt_NombrePro;
        private System.Windows.Forms.TextBox txt_CodPro;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_NombrePro;
    }
}