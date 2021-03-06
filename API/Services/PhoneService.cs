using API.DataAccess;
using API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;

namespace API.Services
{
    public class PhoneService
    {
        public IEnumerable<Phone> GetAllPhones()
        {
            using (Context context = new Context())
            {
                List<Phone> list = new List<Phone>();
                foreach (var phone in context.Products.OfType<Phone>().ToArray())
                {
                    list.Add(phone);
                }
                return list;
            }
        }

        public Phone GetPhone(int id)
        {
            using (Context context = new Context())
            {
                var phone = context.Products.OfType<Phone>().FirstOrDefault(q => q.Id == id);
                if (phone != null)
                {
                    return phone;
                }
                else
                    return null;
            }
        }

        public Phone CreatePhone(Phone phone)
        {
            if (phone != null)
            {
                using (Context context = new Context())
                {
                    context.Products.Add(phone);
                    context.SaveChanges();
                    return phone;
                }
            }
            else
                return null;
        }

        public Phone ChangePhone(Phone phone , int id)
        {
            return null;
        }

    }
}