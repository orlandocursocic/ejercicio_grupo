using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ejercicio_grupo.Modelo;

namespace ejercicio_grupo.Repository
{
    public class DomicilioRepository : IDomicilioRepository
    {
        public Domicilio Create(Domicilio domicilio)
        {
            return ApplicationDbContext.applicationDbContext.Domicilio.Add(domicilio);
        }

        public Domicilio Delete(long id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Domicilio> Get()
        {
            IList<Domicilio> lista = new List<Domicilio>(ApplicationDbContext.applicationDbContext.Domicilio);

            return lista.AsQueryable();
        }

        public Domicilio Get(long id)
        {
            return ApplicationDbContext.applicationDbContext.Domicilio.Find(id);
        }

        public void Put(Domicilio domicilio)
        {
            throw new NotImplementedException();
        }
    }
}