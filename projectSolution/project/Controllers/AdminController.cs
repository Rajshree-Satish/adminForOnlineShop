using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using project.Models;

namespace project.Controllers
{
    [EnableCors(origins: "http://localhost:4200", methods: "*", headers: "*")]
    public class AdminController : ApiController
    {
        Admin[] admins = new Admin[]{
         new Admin {adminId=1,adminName="Admin",password="admin123" },
         new Admin{ adminId=2,adminName="admin",password="admin"}
      };

        public IEnumerable<Admin> GetAllAdmin()
        {
            return admins;
        }

        public IHttpActionResult GetEmployee(int id)
        {
            var adm = admins.FirstOrDefault((p) => p.adminId == id);
            if (adm == null)
            {
                return NotFound();
            }
            return Ok(adm);
        }
    }
}
