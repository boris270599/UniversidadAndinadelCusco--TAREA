using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Docente
    {

        //atributos
        private string apellidos;
        private string nombres;
        private int edad;
        private int dni;
        private string especialidad;
        private DateTime fechanacimiento;
        //propiedades
        public string Apellidos
        {
            get { return apellidos; } //lecutra de atributo
            set { apellidos = value; }//escritura de atributo
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }

        }
        public int DNI
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Especialidad
        {
            get { return this.especialidad; }
            set { this.especialidad = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return this.fechanacimiento; }
            set { this.fechanacimiento = value; }

        }

        public string enseñar()
        {
            return "No se ha implementado el metodo enseñar";
        }
        public string matricular()
        {
            return "No se ha implementado el metodo matricular";
        }
        public string aprobar()
        {
            return "No se ha implementado el metodo aprobar ";
        }
        public string desaprobar()
        {
            return "No se ha implementado el metodo desaprobar";
        }
    }
}
