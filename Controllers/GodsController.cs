using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class GodsController : ApiController
    {
        // GET: api/Gods
        public IEnumerable<Gods> Get()
        {
            using(mydbformobileEntities entities = new mydbformobileEntities())
            {
                return entities.Gods.ToList();
            }
        }

        // GET: api/Gods/5
        public Gods Get(int id)
        {
            using (mydbformobileEntities entities = new mydbformobileEntities())
            {
                return entities.Gods.FirstOrDefault(e => e.Id == id);
            }
        }

        // POST: api/Gods
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Gods/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Gods/5
        public void Delete(int id)
        {
        }
    }
}
