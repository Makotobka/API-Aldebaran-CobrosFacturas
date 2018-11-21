using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api_Aldebaran_CobrosPedidos.Controllers
{
    public class CtsCobrarController : ApiController
    {
        AldebaranPlus_JavierJrEntities db = new AldebaranPlus_JavierJrEntities();

        [HttpGet]
        //[Route("F/getMesCV/{Acc}/{IDSU}/{AnoAct}")]
        [Route("CTS/getCtsPagarFactura/{IDFV}")]
        public IQueryable<CtasCobrar> getCtsFactura(int IDFV)
        {
            db.Configuration.LazyLoadingEnabled = false;
            var lista = db.CtasCobrar.Where(x=>x.IDFV> IDFV).Where(x=>x.Saldo>0);
            return lista;
        }

        // GET: api/CtsCobrar/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CtsCobrar
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CtsCobrar/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CtsCobrar/5
        public void Delete(int id)
        {
        }
    }
}
