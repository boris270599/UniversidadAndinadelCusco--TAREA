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
    public partial class frmAlumno : Form
    {
        public frmAlumno()
        {
            InitializeComponent();
        }
        //Instanciar la clase atravez de un objeto
        //En esta parte del codigo se declaran variables globales
        CapaNegocio.Alumno alumno1 = new CapaNegocio.Alumno();
        private void btnleer_Click(object sender, EventArgs e)
        {

            //Leer los datos del formulario
            string apellidos = txtapellido.Text;
            string nombres = txtnombre.Text;
            int edad = int.Parse(txtedad.Text);
            string lugarnacimiento = txtlugarnacimiento.Text;
            alumno1.Apellidos = apellidos;
            alumno1.Nombres = nombres;
            alumno1.Edad = edad;
            alumno1.LugarNacimiento = lugarnacimiento;
            MessageBox.Show("Se han generado correctamente los datos del Alumno1");

        }

        private void btnescribir_Click(object sender, EventArgs e)
        {

            //Mostrar los datos almacenados en el objeto 1
            string apellidos = alumno1.Apellidos;
            string nombres = alumno1.Nombres;
            int edad = alumno1.Edad;
            string lugarnacimiento = alumno1.LugarNacimiento;
            MessageBox.Show("Apellidos: " + apellidos + "Nombres: " + nombres + "Edad: " + edad + "Lugar de Nacimiento: " + lugarnacimiento);


        }

        private void btnestudiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno1.estudiar());
        }

        private void btntrabajar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno1.trabajar());
        }

        private void btnaprobarexamen_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno1.AprobarExamen());
        }
    }
}
