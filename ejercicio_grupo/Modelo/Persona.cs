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

        public Persona(int _id, string _nombre, string _apellido, string _edad){
            this.id = _id;
            this.nombre = _nombre;
            this.apellido = _apellido;
            this.edad = _edad;
        }  
    }
}