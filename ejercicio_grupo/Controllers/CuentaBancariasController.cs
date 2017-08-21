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

namespace ejercicio_grupo.Controllers
{
    public class CuentaBancariasController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/CuentaBancarias
        public IQueryable<CuentaBancaria> GetCuentasBancarias()
        {
            return db.CuentasBancarias;
        }

        // GET: api/CuentaBancarias/5
        [ResponseType(typeof(CuentaBancaria))]
        public IHttpActionResult GetCuentaBancaria(long id)
        {
            CuentaBancaria cuentaBancaria = db.CuentasBancarias.Find(id);
            if (cuentaBancaria == null)
            {
                return NotFound();
            }

            return Ok(cuentaBancaria);
        }

        // PUT: api/CuentaBancarias/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCuentaBancaria(long id, CuentaBancaria cuentaBancaria)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cuentaBancaria.id)
            {
                return BadRequest();
            }

            db.Entry(cuentaBancaria).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CuentaBancariaExists(id))
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

        // POST: api/CuentaBancarias
        [ResponseType(typeof(CuentaBancaria))]
        public IHttpActionResult PostCuentaBancaria(CuentaBancaria cuentaBancaria)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CuentasBancarias.Add(cuentaBancaria);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = cuentaBancaria.id }, cuentaBancaria);
        }

        // DELETE: api/CuentaBancarias/5
        [ResponseType(typeof(CuentaBancaria))]
        public IHttpActionResult DeleteCuentaBancaria(long id)
        {
            CuentaBancaria cuentaBancaria = db.CuentasBancarias.Find(id);
            if (cuentaBancaria == null)
            {
                return NotFound();
            }

            db.CuentasBancarias.Remove(cuentaBancaria);
            db.SaveChanges();

            return Ok(cuentaBancaria);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CuentaBancariaExists(long id)
        {
            return db.CuentasBancarias.Count(e => e.id == id) > 0;
        }
    }
}