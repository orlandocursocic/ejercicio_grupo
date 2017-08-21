using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ejercicio_grupo.Modelo;
using ejercicio_grupo.Repository;

namespace ejercicio_grupo.Service
{
    public class CuentaBancariaService : ICuentaBancariaService
    {
        private ICuentaBancariaRepository cuentaBancariaRepository;

        public CuentaBancaria Create(CuentaBancaria cuentaBancaria)
        {
            return cuentaBancariaRepository.Create(cuentaBancaria);
        }
        
        public CuentaBancaria Delete(long id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<CuentaBancaria> Get()
        {
            throw new NotImplementedException();
        }

        public CuentaBancaria Get(long id)
        {
            throw new NotImplementedException();
        }

        public void Put(CuentaBancaria cuentaBancaria)
        {
            throw new NotImplementedException();
        }
    }
}