using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Alumno
    {
        //atributos
        private string apellidos;
        private string nombres;
        private int edad;
        private string lugarnacimiento;
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
        public string LugarNacimiento
        {
            get { return this.lugarnacimiento; }
            set { this.lugarnacimiento = value; }

        }

        public string estudiar()
        {
            return "NO se ha implementado el metodo estudiar";
        }
        public string trabajar()
        {
            return "No se ha implementado el metodo trabajar";
        }
        public string AprobarExamen()
        {
            return "No se ha implementado el metodo aprobar examen";
        }
    }
}
