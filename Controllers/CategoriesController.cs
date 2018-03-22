using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CategoriesController : ApiController
    {
        // GET: api/Categories
        public IEnumerable<Categories> Get()
        {
           using(mydbformobileEntities1 entities = new mydbformobileEntities1())
            {
                return entities.Categories.ToList();
            }
        }

        // GET: api/Categories/5
        public Categories Get(int id)
        {
            using (mydbformobileEntities1 entities = new mydbformobileEntities1())
            {
                return entities.Categories.FirstOrDefault(e => e.Id == id);
            }
        }

        // POST: api/Categories
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Categories/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Categories/5
        public void Delete(int id)
        {
        }
    }
}
