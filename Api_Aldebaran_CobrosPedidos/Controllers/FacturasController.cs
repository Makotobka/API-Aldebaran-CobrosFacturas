using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api_Aldebaran_CobrosPedidos.Controllers
{
    public class FacturasController : ApiController
    {
        AldebaranPlus_HomeKino db = new AldebaranPlus_HomeKino();

        [HttpGet]
        [Route("F/getFacturasCredito")]
        public IQueryable<vVentaCab> getFacturasCredito()
        {
            db.Configuration.LazyLoadingEnabled = false;            
            var lista = db.vVentaCab.Where(x => x.FORMAPAGO == "CREDITO" && x.Saldo>0);
            return lista;
        }

        // GET: api/Facturas/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Facturas
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Facturas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Facturas/5
        public void Delete(int id)
        {
        }
    }
}
