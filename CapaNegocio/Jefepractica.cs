using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Jefepractica
    {

        //atributos
        private string apellidos;
        private string nombres;
        private int edad;
        private int dni;
        private string area;
        private string lugarnacimiento;
        private DateTime fechadenacimiento;
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
            get { return this.dni; }
            set { this.dni = value; }

        }
        public string Area
        {
            get { return this.area; }
            set { this.area = value; }

        }
        public string LugarNacimiento
        {
            get { return this.lugarnacimiento; }
            set { this.lugarnacimiento = value; }

        }
        public DateTime FechaNacimiento
        {
            get { return this.fechadenacimiento; }
            set { this.fechadenacimiento = value; }

        }
        public string Enseñar()
        {
            return "NO se ha implementado el metodo Enseñar";
        }
        public string Horas()
        {
            return "NO se ha implementado el metodo Horas";
        }
        public string Trabajar()
        {
            return "No se ha implementado el metodo trabajar";
        }
        public string Aprobar()
        {
            return "No se ha implementado el metodo aprobar";
        }
    }
}
