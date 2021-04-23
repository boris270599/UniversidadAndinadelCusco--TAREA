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
    public partial class frmDocente : Form
    {
        public frmDocente()
        {
            InitializeComponent();
        }
        //Instanciar la clase atravez de un objeto
        //En esta parte del codigo se declaran variables globales
        CapaNegocio.Docente Docente1 = new CapaNegocio.Docente();
        private void btnleer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string apellidos = txtapellido.Text;
            string nombres = txtnombre.Text;
            int edad = int.Parse(txtedad.Text);
            int DNI = int.Parse(txtDNI.Text);
            string especialidad = txtespecialidad.Text;
            DateTime fechanacimiento = dtfechanacimiento.Value;
            Docente1.Apellidos = apellidos;
            Docente1.Nombres = nombres;
            Docente1.Edad = edad;
            Docente1.DNI = DNI;
            Docente1.Especialidad = especialidad;
            Docente1.FechaNacimiento = fechanacimiento;

            MessageBox.Show("Se han generado correctamente los datos del Docente");
        }

        private void btnescribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string apellidos = Docente1.Apellidos;
            string nombres = Docente1.Nombres;
            int edad = Docente1.Edad;
            int dni = Docente1.DNI;
            string especialidad = Docente1.Especialidad;
            DateTime fechanacimiento = Docente1.FechaNacimiento;
            MessageBox.Show("Apellidos: " + apellidos + "Nombres: " + nombres + "Edad: " + edad + "DNI: " + dni + "Especialidad: " + especialidad + "Fecha de Nacimiento: " + fechanacimiento);

        }

        private void btnenseñar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Docente1.enseñar());
        }

        private void btnmatricular_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Docente1.matricular());
        }

        private void btndesaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Docente1.desaprobar());
        }

        private void btnaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Docente1.aprobar());
        }
    }
}
