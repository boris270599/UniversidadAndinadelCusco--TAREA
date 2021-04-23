using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Notas
    {
        //atributos
        private string docente;
        private int nota;
        private string notacurso;
        private string nombrealumno;
        //propiedades
        public string Docente
        {
            get { return docente; } //lecutra de atributo
            set { docente = value; }//escritura de atributo
        }
        public int Nota
        {
            get { return nota; }
            set { nota = value; }
        }
        public string NotaCurso
        {
            get { return this.notacurso; }
            set { this.notacurso = value; }

        }
        public string NombreAlumno
        {
            get { return this.nombrealumno; }
            set { this.nombrealumno = value; }

        }

        public string entregar()
        {
            return "NO se ha implementado el metodo entregar";
        }
        public string trabajar()
        {
            return "No se ha implementado el metodo trabajar";
        }
        public string Aprobar()
        {
            return "No se ha implementado el metodo aprobar";
        }
    }
}
