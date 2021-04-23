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
    public partial class frmAsignatura : Form
    {
        public frmAsignatura()
        {
            InitializeComponent();
        }
        //Instanciar la clase atravez de un objeto
        //En esta parte del codigo se declaran variables globales
        CapaNegocio.Asignatura asignatura1 = new CapaNegocio.Asignatura();
        private void btnleer_Click(object sender, EventArgs e)
        {

            //Leer los datos del formulario
            string nombre = txtnombre.Text;
            string nombredocente = txtnombredocente.Text;
            int capacidad = int.Parse(txtcapacidad.Text);
            int horas = int.Parse(txthoras.Text);
            asignatura1.Nombre = nombre;
            asignatura1.NombreDocente = nombredocente;
            asignatura1.Capacidad = capacidad;
            asignatura1.Horas = horas;
            MessageBox.Show("Se han generado correctamente los datos de asignatura1");

        }

        private void btnescribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string nombre = asignatura1.Nombre;
            string nombredocente = asignatura1.NombreDocente;
            int capacidad = asignatura1.Capacidad;
            int horas = asignatura1.Horas;
            MessageBox.Show("Nombre: " + nombre + "Nombre Docente: " + nombredocente + "Capacidad: " + capacidad + "Horas: " + horas);

        }

        private void btndictar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Dictar());
        }

        private void btncursos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Cursos());
        }
    }
}
