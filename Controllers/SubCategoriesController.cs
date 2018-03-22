using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SubCategoriesController : ApiController
    {
        // GET: api/SubCategories
        public IEnumerable<SubCategories> Get()
        {
            using(mydbformobileEntities2 entities = new mydbformobileEntities2())
            {
                return entities.SubCategories.ToList();
            }
        }

        // GET: api/SubCategories/5
        public SubCategories Get(int id)
        {
            using (mydbformobileEntities2 entities = new mydbformobileEntities2())
            {
                return entities.SubCategories.FirstOrDefault(e => e.Id == id);
            }
        }

        // POST: api/SubCategories
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SubCategories/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SubCategories/5
        public void Delete(int id)
        {
        }
    }
}
