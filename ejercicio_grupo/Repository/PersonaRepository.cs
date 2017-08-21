﻿using ejercicio_grupo.Modelo;
using ejercicio_grupo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ejercicio_grupo.Repository
{
    public class PersonaRepository : IPersonaRepository
    {
        public Persona Create(Persona persona)
        {
            return ApplicationDbContext.applicationDbContext.Personas.Add(persona);
        }

        public Persona Get(long id)
        {
            return ApplicationDbContext.applicationDbContext.Personas.Find(id);
        }

        public IQueryable<Persona> Get()
        {
            IList<Persona> lista = new List<Persona>(ApplicationDbContext.applicationDbContext.Personas);

            return lista.AsQueryable();
        }


        public void Put(Persona persona)
        {
            if (ApplicationDbContext.applicationDbContext.Personas.Count(e => e.id == persona.id) == 0)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.Entry(persona).State = EntityState.Modified;
        }

        public Persona Delete(long id)
        {
            Persona persona = ApplicationDbContext.applicationDbContext.Personas.Find(id);
            if (persona == null)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }

            ApplicationDbContext.applicationDbContext.Personas.Remove(persona);
            return persona;
        }

    }
}