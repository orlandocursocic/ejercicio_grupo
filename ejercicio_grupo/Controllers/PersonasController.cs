using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ejercicio_grupo.Modelo;
using ejercicio_grupo.Models;
using ejercicio_grupo.Service;
using ejercicio_grupo.Repository;
using System.Web.Http.Cors;

namespace ejercicio_grupo.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]

    public class PersonasController : ApiController
    {
        private IPersonaService personaService;

        public PersonasController(IPersonaService personaService)
        {
            this.personaService = personaService;
        }

        // GET: api/Personas
        public IQueryable<Persona> GetPersonas()
        {
            return personaService.ReadAll();
        }

        // GET: api/Personas/5
        [ResponseType(typeof(Persona))]
        public IHttpActionResult GetEntrada(long id)
        {
            Persona persona = personaService.Read(id);
            if (persona == null)
            {
                return NotFound();
            }

            return Ok(persona);
        }

        // PUT: api/Personas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPersona(long id, Persona persona)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != persona.id)
            {
                return BadRequest();
            }

            try
            {
                personaService.Update(persona);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Personas
        [ResponseType(typeof(Persona))]
        public IHttpActionResult PostPersona(Persona persona)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            persona = personaService.Create(persona);

            return CreatedAtRoute("DefaultApi", new { id = persona.id }, persona);
        }

        // DELETE: api/Personas/5
        [ResponseType(typeof(Persona))]
        public IHttpActionResult DeletePersona(long id)
        {
            Persona persona;
            try
            {
                persona = personaService.Delete(id);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return Ok(persona);
        }
    }
}