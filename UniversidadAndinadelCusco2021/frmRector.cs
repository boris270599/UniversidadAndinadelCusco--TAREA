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
    public partial class frmRector : Form
    {
        public frmRector()
        {
            InitializeComponent();
        }
        CapaNegocio.Rector rector1 = new CapaNegocio.Rector();
        private void btnleer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string apellido = txtapellido.Text;
            string nombre = txtnombre.Text;
            int edad = int.Parse(txtedad.Text);
            int dni = int.Parse(txtdni.Text);
            string especialidad = txtespecialidad.Text;
            DateTime fechanacimiento = dtfechanacimiento.Value;

            rector1.Apellidos = apellido;
            rector1.Nombres = nombre;
            rector1.Edad = edad;
            rector1.DNI = dni;
            rector1.Especialidad = especialidad;
            rector1.FechaNacimiento = fechanacimiento;
            MessageBox.Show("Se han generado correctamente los datos de rector1");


        }

        private void btnescribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string apellido = rector1.Apellidos;
            string nombre = rector1.Nombres;
            int edad = rector1.Edad;
            int dni = rector1.DNI;
            string especialidad = rector1.Especialidad;
            DateTime fechanacimiento = rector1.FechaNacimiento;

            MessageBox.Show("Apellido: " + apellido + "Nombre: " + nombre + "Edad: " + edad + "DNI: " + dni + "Especialidad: " + especialidad + "Fecha de Nacimiento: " + fechanacimiento);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.reglamento());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.decretos());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.convenios());
        }
    }
}
