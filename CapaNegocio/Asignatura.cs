using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Asignatura
    {
        //atributos

        private string nombre;
        private string nombredocente;
        private int capacidad;
        private int horas;

        //propiedades

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string NombreDocente
        {
            get { return nombredocente; }
            set { nombredocente = value; }
        }
        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
        public int Horas
        {
            get { return horas; }
            set { horas = value; }
        }

        public string Dictar()
        {
            return "NO se ha implementado el metodo Dictar";
        }
        public string Cursos()
        {
            return "No se ha implementado el metodo Cursos";
        }
    }
}
