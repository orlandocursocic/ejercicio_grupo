using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ejercicio_grupo.Modelo;
using ejercicio_grupo.Repository;

namespace ejercicio_grupo.Service
{
    public class DomicilioService : IDomicilioService
    {
        private IDomicilioRepository domicilioRepository;
        public DomicilioService(IDomicilioRepository _domicilioRepository)
        {
            this.usuariosRepository = _usuariosRepository;
        }

        public Domicilio Create(Domicilio domicilio)
        {
            throw new NotImplementedException();
        }

        public Domicilio Delete(long id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Domicilio> Get()
        {
            throw new NotImplementedException();
        }

        public Domicilio Get(long id)
        {
            throw new NotImplementedException();
        }

        public void Put(Domicilio domicilio)
        {
            throw new NotImplementedException();
        }
    }
}