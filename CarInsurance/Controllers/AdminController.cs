using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModels;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        public ActionResult Index()
        {
            var insurees = db.Tables.ToList();
            var insureeVms = new List<InsureeVm>();
            foreach (var insuree in insurees)
			{
                var insureeVm = new InsureeVm();
                insureeVm.FirstName = insuree.FirstName;
                insureeVm.LastName = insuree.LastName;
                insureeVm.EmailAddress = insuree.EmailAddress;
                insureeVm.Quote = insuree.Quote;
                insureeVms.Add(insureeVm);
            }
            return View(insureeVms);

        }
    }
}