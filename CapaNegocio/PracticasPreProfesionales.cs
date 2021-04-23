using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class PracticasPreProfesionales
    {

        //atributos
        private string nombreestudiante;
        private string nombrejefe;
        private int horas;
        private string area;
        //propiedades
        public string NombreEstudiante
        {
            get { return nombreestudiante; } //lecutra de atributo
            set { nombreestudiante = value; }//escritura de atributo
        }
        public string NombreJefe
        {
            get { return nombrejefe; }
            set { nombrejefe = value; }
        }
        public int Horas
        {
            get { return this.horas; }
            set { this.horas = value; }

        }
        public string Area
        {
            get { return this.area; }
            set { this.area = value; }

        }

        public string entregar()
        {
            return "NO se ha implementado el metodo entregar";
        }
        public string trabajar()
        {
            return "No se ha implementado el metodo trabajar";
        }
        public string Practicantes()
        {
            return "No se ha implementado el metodo aprobar";
        }
    }
}
