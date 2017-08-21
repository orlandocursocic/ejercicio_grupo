using ejercicio_grupo.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_grupo.Service
{
    interface ICuentaBancariaService
    {
        CuentaBancaria Create(CuentaBancaria cuentaBancaria);
        CuentaBancaria Get(long id);
        IQueryable<CuentaBancaria> Get();
        void Put(CuentaBancaria cuentaBancaria);
        CuentaBancaria Delete(long id);
    }
}
