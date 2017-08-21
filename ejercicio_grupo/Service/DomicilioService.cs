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
            this.domicilioRepository = _domicilioRepository;
        }

        public Domicilio Create(Domicilio domicilio)
        {
            return domicilioRepository.Create(domicilio);
        }

        public Domicilio Delete(long id)
        {
            return domicilioRepository.Delete(id);
        }

        public IQueryable<Domicilio> ReadAll()
        {
            return domicilioRepository.ReadAll();
        }

        public Domicilio Read(long id)
        {
            return domicilioRepository.Read(id);
        }

        public void Update(Domicilio domicilio)
        {
            domicilioRepository.Update(domicilio);
        }
    }
}