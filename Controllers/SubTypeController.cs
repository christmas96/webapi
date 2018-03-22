using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SubTypeController : ApiController
    {
        // GET: api/SubType
        public IEnumerable<SubType> Get()
        {
            using(mydbformobileEntities3 entities = new mydbformobileEntities3())
            {
                return entities.SubType.ToList();
            }
        }

        // GET: api/SubType/5
        public SubType Get(int id)
        {
            using (mydbformobileEntities3 entities = new mydbformobileEntities3())
            {
                return entities.SubType.FirstOrDefault(e => e.Id == id);
            }
        }

        // POST: api/SubType
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SubType/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SubType/5
        public void Delete(int id)
        {
        }
    }
}
