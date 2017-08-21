using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejercicio_grupo.Modelo
{
    public class Domicilio
    {
        public string pais { get; set; }
        public string provincia { get; set; }
        public string municipio { get; set; }
        public int codigoPostal { get; set; }
        public string direccion { get; set; }

        public Domicilio()
        { }

        public Domicilio(string pais, string provincia, string municipio, int codigoPostal, string direccion)
        {
            this.pais = pais;
            this.provincia = provincia;
            this.municipio = municipio;
            this.codigoPostal = codigoPostal;
            this.direccion = direccion;
        }
    }
}