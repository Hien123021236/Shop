using API.DataAccess;
using API.Models;
using Newtonsoft.Json;
using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace API.Controllers
{
    public class PhonesController : ApiController
    {
        private Context context;
        public PhonesController()
        {
            context = new Context();
        }
        private bool PhoneExits(int id)
        {
            return context.Products.OfType<Phone>().Count(p => p.Id == id) > 0;
        }

        // GET: api/Phones
        public IEnumerable<Phone> Get()
        {
            List<Phone> list = new List<Phone>();
            foreach (Phone phone in context.Products.OfType<Phone>().ToArray())
            {
                list.Add(phone);
            }
            return list;
        }

        // GET: api/Phones/5
        [ResponseType(typeof(Phone))]
        public IHttpActionResult Get(int id)
        {
            try
            {
                var phone = context.Products.OfType<Phone>().FirstOrDefault(q => q.Id == id);
                if (phone == null)
                {
                    return NotFound();
                }
                return Ok(phone);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        // POST: api/Phones
        [ResponseType(typeof(Phone))]
        public HttpResponseMessage Post()
        {
            var httpRequest = HttpContext.Current.Request;
            try
            {
                var data = httpRequest.Form.Get("data");
                if (data == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }
                Phone phone = JsonConvert.DeserializeObject<Phone>(data);
               
                context.Products.Add(phone);
                context.SaveChanges();

                int id = phone.Id;

                foreach (var name in httpRequest.Files.AllKeys)
                {
                    if (!string.IsNullOrEmpty(name))
                    {
                        var img = httpRequest.Files.Get("img");
                        var extension = System.IO.Path.GetExtension(img.FileName);
                        img.SaveAs(HttpContext.Current.Server.MapPath("~/App_Data/Images/") + id + "_" + name + extension);
                    }
                }
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // PUT: api/Phones/5
        [ResponseType(typeof(Phone))]
        public HttpResponseMessage Put(int id, [FromBody] Phone item)
        {
            try
            {
                if(item==null || item.Id != id)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }
                else
                {
                    var phone = context.Products.Find(id);

                    if(phone == null)
                    {   
                        return Request.CreateResponse(HttpStatusCode.NotFound);
                    }
                    else
                    {
                        phone.Quantity = item.Quantity;
                       
                        context.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, phone);
                    }
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

           
        }

        // DELETE: api/Phones/5
        [ResponseType(typeof(Phone))]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                if (id < 1)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }
                else
                {
                    var phone = context.Products.OfType<Phone>().FirstOrDefault(p => p.Id == id);
                    if (phone == null)
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound);
                    }
                    context.Products.Remove(phone);
                    context.SaveChanges();
                }
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            } 
        }

        [ResponseType(typeof(Phone))]
        public HttpResponseMessage GetPhonesOfProduction(int productionId)
        {
            var phones =  context.Products.OfType<Phone>().Where(p => p.Production.Id == productionId).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, phones);
        }
    }
}
