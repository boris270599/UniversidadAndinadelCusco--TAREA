using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Rector
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

        public string reglamento()
        {
            return "No se ha implementado el metodo reglamento";
        }
        public string decretos()
        {
            return "No se ha implementado el metodo adecretos ";
        }
        public string convenios()
        {
            return "No se ha implementado el metodo convenios";
        }
    }
}
