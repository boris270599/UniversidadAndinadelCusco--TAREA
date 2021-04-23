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
    public partial class frmLaboratorio : Form
    {
        public frmLaboratorio()
        {
            InitializeComponent();
        }
        CapaNegocio.Laboratorio laboratorio1 = new CapaNegocio.Laboratorio();
        private void btnleer_Click(object sender, EventArgs e)
        {

            //Leer los datos del formulario
            string nombre = txtnombre.Text;
            int capacidad = int.Parse(txtcapacidad.Text);
            int cantidadddeinstrumentos = int.Parse(txtcantidaddeinstrumentos.Text);
            string especialidad = txtespecialidad.Text;
            laboratorio1.Nombre = nombre;
            laboratorio1.Capacidad = capacidad;
            laboratorio1.CantidadInstrumentos = cantidadddeinstrumentos;
            laboratorio1.Especialidad = especialidad;
            MessageBox.Show("Se han generado correctamente los datos de laboratorio1");
        }

        private void btnescribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string nombre = laboratorio1.Nombre;
            int capacidad = laboratorio1.Capacidad;
            int cantidaddeinstrumentos = laboratorio1.CantidadInstrumentos;
            string especialidad = laboratorio1.Especialidad;
            MessageBox.Show("Nombre: " + nombre + "Capacidad: " + capacidad + "Cantidad de Instrumentos: " + cantidaddeinstrumentos + "Especialidad: " + especialidad);

        }

        private void btnenseñar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.enseñar());
        }

        private void btnmatricular_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.matricular());
        }

        private void btnaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.aprobar());
        }

        private void btndesaproabr_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.desaprobar());
        }
    }
}
