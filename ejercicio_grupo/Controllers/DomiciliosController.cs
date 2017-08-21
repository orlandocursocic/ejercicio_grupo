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
using System.Web.Http.Cors;
using ejercicio_grupo.Service;

namespace ejercicio_grupo.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]

    public class DomiciliosController : ApiController
    {
        private IDomicilioService domicilioService;

        public DomiciliosController(IDomicilioService domicilioService)
        {
            this.domicilioService = domicilioService;
        }

        // GET: api/Domicilios
        public IQueryable<Domicilio> GetDomicilios()
        {
            return domicilioService.Get();
        }

        // GET: api/Domicilios/5
        [ResponseType(typeof(Domicilio))]
        public IHttpActionResult GetDomicilio(long id)
        {
            Domicilio domicilio = domicilioService.Get(id);
            if (domicilio == null)
            {
                return NotFound();
            }

            return Ok(domicilio);
        }

        // PUT: api/Domicilios/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDomicilio(long id, Domicilio domicilio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != domicilio.id)
            {
                return BadRequest();
            }

            db.Entry(domicilio).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DomicilioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Domicilios
        [ResponseType(typeof(Domicilio))]
        public IHttpActionResult PostDomicilio(Domicilio domicilio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Domicilios.Add(domicilio);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = domicilio.id }, domicilio);
        }

        // DELETE: api/Domicilios/5
        [ResponseType(typeof(Domicilio))]
        public IHttpActionResult DeleteDomicilio(long id)
        {
            Domicilio domicilio = db.Domicilios.Find(id);
            if (domicilio == null)
            {
                return NotFound();
            }

            db.Domicilios.Remove(domicilio);
            db.SaveChanges();

            return Ok(domicilio);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DomicilioExists(long id)
        {
            return db.Domicilios.Count(e => e.id == id) > 0;
        }
    }
}