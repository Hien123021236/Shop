//using API.DataAccess;
//using API.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;

//namespace API.Controllers
//{
//    public class LaptopsController : ApiController
//    {
//        private Context context;

//        public LaptopsController()
//        {
//            context = new Context();
//        }
//        // GET: api/Laptops
//        public HttpResponseMessage Get()
//        {
//            List<Laptop> list = new List<Laptop>();
//            foreach (Laptop laptop in context.Products.OfType<Laptop>().ToArray())
//            {
//                list.Add(
//                    new Laptop()
//                    {

//                    }
//                );
//            }

//            return Request.CreateResponse(HttpStatusCode.OK, list);
//        }

//        // GET: api/Laptops/5
//        public string Get(int id)
//        {
//            return "value";
//        }

//        // POST: api/Laptops
//        public void Post([FromBody] Phone value)
//        {

//        }

//        // PUT: api/Laptops/5
//        public void Put(int id, [FromBody] string value)
//        {
//        }

//        // DELETE: api/Laptops/5
//        public void Delete(int id)
//        {
//        }

//        public HttpResponseMessage GetLaptopsOfProduction(string productionId)
//        {
//            return null;
//        }
//    }
//}
