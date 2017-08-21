using ejercicio_grupo.Modelo;
using ejercicio_grupo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejercicio_grupo.Service
{
    public class PersonaService : IPersonaService
    {
        private IPersonaRepository PersonaRepository;
        public PersonaService(IPersonaRepository personaRepository)
        {
            this.PersonaRepository = personaRepository;
        }

        public Persona Get(long id)
        {
            return PersonaRepository.Get(id);
        }

        public IQueryable<Persona> Get()
        {
            return PersonaRepository.Get();
        }

        public Persona Create(Persona entrada)
        {
            return PersonaRepository.Create(entrada);
        }

        public void Put(Persona entrada)
        {
            PersonaRepository.Put(entrada);
        }

        public Persona Delete(long id)
        {
            return PersonaRepository.Delete(id);
        }

        public Persona create(Persona entrada)
        {
            throw new NotImplementedException();
        }
    }
}