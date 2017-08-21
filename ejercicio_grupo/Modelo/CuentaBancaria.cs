using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejercicio_grupo.Modelo
{
    public class CuentaBancaria
    {
        private long id { get; set; }
        private string numeroCuenta { get; set; }
        private string nombreTitular { get; set; }
        private string apellidosTitular { get; set; }

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