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
    public partial class frmPracticasPreProfesionales : Form
    {
        public frmPracticasPreProfesionales()
        {
            InitializeComponent();
        }
        CapaNegocio.PracticasPreProfesionales practicaspreprofesionales1 = new CapaNegocio.PracticasPreProfesionales();
        private void btnleer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string nombreestudiante = txtnombreestudiante.Text;
            string nombrejefe = txtnombrejefe.Text;
            int horas = int.Parse(txthoras.Text);
            string area = txtarea.Text;
            practicaspreprofesionales1.NombreEstudiante = nombreestudiante;
            practicaspreprofesionales1.NombreJefe = nombrejefe;
            practicaspreprofesionales1.Horas = horas;
            practicaspreprofesionales1.Area = area;
            MessageBox.Show("Se han generado correctamente los datos de practicas pre profesionales1");


        }

        private void btnescribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string nombreestudiante = practicaspreprofesionales1.NombreEstudiante;
            string nombrejefe = practicaspreprofesionales1.NombreJefe;
            int horas = practicaspreprofesionales1.Horas;
            string area = practicaspreprofesionales1.Area;
            MessageBox.Show("Nombre Estudiante: " + nombreestudiante + "Nombre Jefe: " + nombrejefe + "Horas: " + horas + "Area: " + area);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(practicaspreprofesionales1.entregar());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(practicaspreprofesionales1.trabajar());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(practicaspreprofesionales1.Practicantes());
        }
    
    }
}
