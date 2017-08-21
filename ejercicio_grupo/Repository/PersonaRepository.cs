using ejercicio_grupo.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejercicio_grupo.Repository
{
    public class PersonaRepository : IPersonaRepository, IPersonaRepository
    {
        public Persona Create(Persona persona)
        {
            return ApplicationDbContext.applicationDbContext.personas.Add(persona);
        }

        public Persona Get(long id)
        {
            return ApplicationDbContext.applicationDbContext.personas.Find(id);
        }

        public IQueryable<Persona> Get()
        {
            IList<Persona> lista = new List<Persona>(ApplicationDbContext.applicationDbContext.personas);

            return lista.AsQueryable();
        }


        public void Put(Persona persona)
        {
            if (ApplicationDbContext.applicationDbContext.personas.Count(e => e.id == persona.id) == 0)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.Entry(persona).State = EntityState.Modified;
        }

        public Persona Delete(long id)
        {
            Persona persona = ApplicationDbContext.applicationDbContext.personas.Find(id);
            if (persona == null)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }

            ApplicationDbContext.applicationDbContext.personas.Remove(persona);
            return persona;
        }

    }
}