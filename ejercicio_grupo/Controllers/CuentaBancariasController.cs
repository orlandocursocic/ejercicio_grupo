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
using ejercicio_grupo.Repository;

namespace ejercicio_grupo.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]

    public class CuentaBancariasController : ApiController
    {
        private ICuentaBancariaService cuentaBancariaService;

        public CuentaBancariasController(ICuentaBancariaService cuentaBancariaService)
        {
            this.cuentaBancariaService = cuentaBancariaService;
        }

        // GET: api/CuentaBancarias
        public IQueryable<CuentaBancaria> GetCuentasBancarias()
        {
            return cuentaBancariaService.ReadAll();
        }

        // GET: api/CuentaBancarias/5
        [ResponseType(typeof(CuentaBancaria))]
        public IHttpActionResult GetCuentaBancaria(long id)
        {
            CuentaBancaria cuentaBancaria = cuentaBancariaService.Read(id);
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

            try
            {
                cuentaBancariaService.Update(cuentaBancaria);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
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

            cuentaBancaria = cuentaBancariaService.Create(cuentaBancaria);

            return CreatedAtRoute("DefaultApi", new { id = cuentaBancaria.id }, cuentaBancaria);
        }

        // DELETE: api/CuentaBancarias/5
        [ResponseType(typeof(CuentaBancaria))]
        public IHttpActionResult DeleteCuentaBancaria(long id)
        {
            CuentaBancaria cuentaBancaria;
            try
            {
                cuentaBancaria = cuentaBancariaService.Delete(id);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return Ok(cuentaBancaria);
        }
    }
}