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

        public Persona Read(long id)
        {
            return PersonaRepository.Read(id);
        }

        public IQueryable<Persona> ReadAll()
        {
            return PersonaRepository.ReadAll();
        }

        public Persona Create(Persona entrada)
        {
            return PersonaRepository.Create(entrada);
        }

        public void Update(Persona entrada)
        {
            PersonaRepository.Update(entrada);
        }

        public Persona Delete(long id)
        {
            return PersonaRepository.Delete(id);
        }
    }
}