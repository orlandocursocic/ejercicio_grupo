using ejercicio_grupo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejercicio_grupo.Service
{
    public class PersonaService
    {
        private IPersonaRepository PersonasRepository;
        public PersonasService(IPersonasRepository _personasRepository)
        {
            this.PersonasRepository = _personasRepository;
        }

        public Persona Get(long id)
        {
            return PersonasRepository.Get(id);
        }

        public IQueryable<Persona> Get()
        {
            return PersonasRepository.Get();
        }

        public Persona Create(Persona entrada)
        {
            return PersonasRepository.Create(entrada);
        }

        public void Put(Persona entrada)
        {
            PersonasRepository.Put(entrada);
        }

        public Persona Delete(long id)
        {
            return PersonasRepository.Delete(id);
        }

        public Persona create(Persona entrada)
        {
            throw new NotImplementedException();
        }
    }
}