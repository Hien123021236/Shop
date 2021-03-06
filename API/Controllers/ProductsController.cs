using API.DataAccess;
using API.Models;
using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace API.Controllers
{
    public class ProductsController : ApiController
    {
        private Context context;

        public ProductsController()
        {
            context = new Context();
        }

        private bool ProductExits(int id)
        {
            return context.Products.Count(p => p.Id == id) > 0;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                context.Dispose();
            }
            base.Dispose(disposing);
        }

        // GET: api/Products
        public IEnumerable<Product> Get()
        {
            var list = context.Products.AsNoTracking().ToList();
            return list;
        }

        // GET: api/Products/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult Get(int id)
        {
            try
            {
                var product = context.Products.AsNoTracking().FirstOrDefault(q => q.Id == id);
                if (product == null)
                {
                    return NotFound();
                }
                return Ok(product);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        // POST: api/Products
        [ResponseType(typeof(Product))]
        public IHttpActionResult Post([FromBody] Product product)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (product == null)
                {
                    return BadRequest();
                }
                else
                {
                    context.Products.Add(product);
                    context.SaveChanges();

                    return CreatedAtRoute("DefaultApi", new { id = product.Id }, product);
                }
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [ResponseType(typeof(void))]
        // PUT: api/Products/5
        public IHttpActionResult Put(int id, [FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (product == null || product.Id != id)
            {
                return BadRequest();
            }

            context.Entry(product).State = EntityState.Modified;
            try
            {
                context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExits(id))
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


        [ResponseType(typeof(Product))]
        // DELETE: api/Products/5
        public IHttpActionResult Delete(int id)
        {
            var product = context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            context.Products.Remove(product);
            context.SaveChanges();
            return Ok(product);
        }
    }
}
