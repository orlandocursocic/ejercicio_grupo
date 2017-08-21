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

        public CuentaBancariaService(ICuentaBancariaRepository cuentaBancariaRepository)
        {
            this.cuentaBancariaRepository = cuentaBancariaRepository;
        }

        public CuentaBancaria Create(CuentaBancaria cuentaBancaria)
        {
            return cuentaBancariaRepository.Create(cuentaBancaria);
        }

        public CuentaBancaria Delete(long id)
        {
            return cuentaBancariaRepository.Delete(id);
        }

        public IQueryable<CuentaBancaria> ReadAll()
        {
            return cuentaBancariaRepository.ReadAll();
        }

        public CuentaBancaria Read(long id)
        {
            return cuentaBancariaRepository.Read(id);
        }

        public void Update(CuentaBancaria cuentaBancaria)
        {
            cuentaBancariaRepository.Update(cuentaBancaria);
        }
    }
}