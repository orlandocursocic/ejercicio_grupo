using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejercicio_grupo.Modelo
{
    public class Persona
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }

        public Persona() {
        }

        public Persona(int id, string nombre, string apellido, int edad){
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }  
    }
}