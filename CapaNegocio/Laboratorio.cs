using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Laboratorio
    {

        //atributos
        private string nombre;
        private int capacidad;
        private int cantidadinstrumentos;
        private string especialidad;
        //propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Capacidad
        {
            get { return this.capacidad; }
            set { this.capacidad = value; }

        }
        public int CantidadInstrumentos
        {
            get { return cantidadinstrumentos; }
            set { cantidadinstrumentos = value; }
        }
        public string Especialidad
        {
            get { return this.especialidad; }
            set { this.especialidad = value; }
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
