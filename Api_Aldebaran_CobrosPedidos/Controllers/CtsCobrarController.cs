using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Api_Aldebaran_CobrosPedidos.Controllers
{
    public class CtsCobrarController : ApiController
    {
        AldebaranPlus db = new AldebaranPlus();

        [HttpGet]
        [Route("CTS/getCtsPagarFactura/{IDFV}")]
        public IQueryable<CtasCobrar> getCtsFactura(int IDFV)
        {
            db.Configuration.LazyLoadingEnabled = false;
            var lista = db.CtasCobrar.Where(x=>x.IDFV>= IDFV).Where(x=>x.Saldo>0);
            return lista;
        }


        [HttpPost]
        [Route("CTS/setCtasAll")]
        [ResponseType(typeof(CtasCobrar[]))]
        public ObjectResult<int?> Get(CtasCobrar[] datos)
        {
            ObjectResult<int?> res = null;
            for (int c = 0; c < datos.Length; c++)
            {
                string estado = "";
                if (datos[c].Estado)
                {
                    estado = "1";
                }
                else
                {
                    estado = "0";
                }
                res = db.Ins_CtasCobrar(                    datos[c].IDSU,                    datos[c].IDPT,                    datos[c].IDFV,                    datos[c].IDUS,                    datos[c].IDEP,                    datos[c].Fecha,                    datos[c].Tipo,                    datos[c].FormaPago,                    datos[c].Valor,                    datos[c].Saldo,                    datos[c].PorcentajeComision,                    datos[c].Comision,                    estado                );
                string asdasd = "asda";
            }
            return res;
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

        [HttpOptions]
        [Route("CTS/setCtasAll")]
        [ResponseType(typeof(CtasCobrar[]))]
        public HttpResponseMessage OptionsUbicacionGeograficaCustom(CtasCobrar[] datos)
        {
            return new HttpResponseMessage { StatusCode = HttpStatusCode.OK };
        }
    }
}
