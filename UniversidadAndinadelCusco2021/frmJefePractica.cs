using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversidadAndinadelCusco2021
{
    public partial class frmJefePractica : Form
    {
        public frmJefePractica()
        {
            InitializeComponent();
        }
        //Instanciar la clase atravez de un objeto
        //En esta parte del codigo se declaran variables globales
        CapaNegocio.Jefepractica jefepractica1 = new CapaNegocio.Jefepractica();
        private void btnleer_Click(object sender, EventArgs e)
        {

            //Leer los datos del formulario
            string apellidos = txtapellido.Text;
            string nombre = txtnombre.Text;
            int edad = int.Parse(txtedad.Text);
            int dni = int.Parse(txtDNI.Text);
            string area = txtarea.Text;
            string lugarnacimiento = txtlugarnacimiento.Text;
            DateTime fechanacimiento = dtfechanacimiento.Value;
            jefepractica1.Apellidos = apellidos;
            jefepractica1.Nombres = nombre;
            jefepractica1.Edad = edad;
            jefepractica1.DNI = dni;
            jefepractica1.Area = area;
            jefepractica1.LugarNacimiento = lugarnacimiento;
            jefepractica1.FechaNacimiento = fechanacimiento;
            MessageBox.Show("Se han generado correctamente los datos de jefepractica1");

        }

        private void btnescribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string apellidos = jefepractica1.Apellidos;
            string nombre = jefepractica1.Nombres;
            int edad = jefepractica1.Edad;
            int dni = jefepractica1.DNI;
            string area = jefepractica1.Area;
            string lugarnacimiento = jefepractica1.LugarNacimiento;
            DateTime fechanacimiento = jefepractica1.FechaNacimiento;
            MessageBox.Show("Apellidos: " + apellidos + "Nombres: " + nombre + "Edad: " + edad + "DNI: " + dni + "Area: " + area + "Lugar de Nacimiento: " + lugarnacimiento + "Fecha Nacimiento: " + fechanacimiento);
        }

        private void btnenseñar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefepractica1.Enseñar());
        }

        private void btnmatricular_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefepractica1.Horas());
        }

        private void btndesaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefepractica1.Trabajar());
        }

        private void btnaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefepractica1.Aprobar());
        }
    }
}
