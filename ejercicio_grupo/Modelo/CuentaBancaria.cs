using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ejercicio_grupo.Modelo
{
    public class CuentaBancaria
    {
        public long id { get; set; }
        public string numeroCuenta { get; set; }
        public string nombreTitular { get; set; }
        public string apellidosTitular { get; set; }

        public CuentaBancaria()
        {
        }

        public CuentaBancaria(string numeroCuenta, string nombreTitular, string apellidosTitular)
        {
            this.numeroCuenta = numeroCuenta;
            this.nombreTitular = nombreTitular;
            this.apellidosTitular = apellidosTitular;
        }
    }
}