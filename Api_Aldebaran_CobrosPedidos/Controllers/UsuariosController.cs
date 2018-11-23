using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api_Aldebaran_CobrosPedidos.Controllers
{
    public class UsuariosController : ApiController
    {
        ChinoServer db = new ChinoServer();

        [HttpGet]
        [Route("U/getusuarios")]
        public IQueryable<Usuario> getUsuarios()
        {
            db.Configuration.LazyLoadingEnabled = false;
            var lista = db.Usuario;
            return lista;
        }

        // GET: api/Usuarios/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Usuarios
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Usuarios/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Usuarios/5
        public void Delete(int id)
        {
        }
    }
}
