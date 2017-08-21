using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ejercicio_grupo.Modelo;
using ejercicio_grupo.Models;
using System.Data.Entity;

namespace ejercicio_grupo.Repository
{
    public class CuentaBancariaRepository : ICuentaBancariaRepository
    {
        public CuentaBancaria Create(CuentaBancaria cuentaBancaria)
        {
            return ApplicationDbContext.applicationDbContext.CuentasBancarias.Add(cuentaBancaria);
        }

        public CuentaBancaria Delete(long id)
        {
            CuentaBancaria cuentaBancaria = ApplicationDbContext.applicationDbContext.CuentasBancarias.Find(id);
            if (cuentaBancaria == null)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }

            ApplicationDbContext.applicationDbContext.CuentasBancarias.Remove(cuentaBancaria);
            return cuentaBancaria;
        }

        public CuentaBancaria Read(long id)
        {
            return ApplicationDbContext.applicationDbContext.CuentasBancarias.Find(id); 
        }

        public IQueryable<CuentaBancaria> ReadAll()
        {
            IList<CuentaBancaria> lista = new List<CuentaBancaria>(ApplicationDbContext.applicationDbContext.CuentasBancarias);

            return lista.AsQueryable();
        }

        public void Update(CuentaBancaria cuentaBancaria)
        {
            // Si no existe la entrada en la bd
            if (!(ApplicationDbContext.applicationDbContext.Personas.Count(c => c.id == cuentaBancaria.id) > 0))
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.Entry(cuentaBancaria).State = EntityState.Modified;
        }
    }
}