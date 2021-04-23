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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }
        CapaNegocio.Notas notas1 = new CapaNegocio.Notas();
        private void btnleer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string docente = txtdocente.Text;
            int nota = int.Parse(txtnota.Text);
            string notacurso = txtnotacurso.Text;
            string nombrealumno = txtnotaalumno.Text;
            notas1.Docente = docente;
            notas1.Nota = nota;
            notas1.NotaCurso = notacurso;
            notas1.NombreAlumno = nombrealumno;
            MessageBox.Show("Se han generado correctamente los datos de nota1");
        }

        private void btnescribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string docente = notas1.Docente;
            int nota = notas1.Nota;
            string notacurso = notas1.NotaCurso;
            string nombrealumno = notas1.NombreAlumno;
            MessageBox.Show("Docente: " + docente + "Nota: " + nota + "Nota Curso: " + notacurso + "Nombre Alumno: " + nombrealumno);

        }

        private void btnentregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas1.entregar());
        }

        private void btntrabajar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas1.trabajar());
        }

        private void btnaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas1.Aprobar());
        }
    }
}
