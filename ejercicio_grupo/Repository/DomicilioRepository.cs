using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ejercicio_grupo.Modelo;
using ejercicio_grupo.Models;
using System.Data.Entity;

namespace ejercicio_grupo.Repository
{
    public class DomicilioRepository : IDomicilioRepository
    {
        public Domicilio Create(Domicilio domicilio)
        {
            return ApplicationDbContext.applicationDbContext.Domicilios.Add(domicilio);
        }

        public Domicilio Delete(long id)
        {
            Domicilio domicilio = ApplicationDbContext.applicationDbContext.Domicilios.Find(id);
            if (domicilio == null)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }

            ApplicationDbContext.applicationDbContext.Domicilios.Remove(domicilio);
            return domicilio;
        }

        public IQueryable<Domicilio> Get()
        {
            IList<Domicilio> lista = new List<Domicilio>(ApplicationDbContext.applicationDbContext.Domicilios);

            return lista.AsQueryable();
        }

        public Domicilio Get(long id)
        {
            return ApplicationDbContext.applicationDbContext.Domicilios.Find(id);
        }

        public void Put(Domicilio domicilio)
        {
            if (ApplicationDbContext.applicationDbContext.Domicilios.Count(e => e.id == domicilio.id) == 0)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.Entry(domicilio).State = EntityState.Modified;
        }
    }
}