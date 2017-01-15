using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Healthcare_domain;
using Healthcare_Interface;
using Healthcare_Repository;
namespace HealthCare_api.Controllers
{
    public class ProceduresController : Controller
    {
        IProcedure Proc = new ProcedureRepository();
        // GET: Procedures
        public ActionResult Index()
        {
            var a = Proc.GetProcedure();
            return View();
        }
    }
}