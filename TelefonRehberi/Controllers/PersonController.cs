using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelefonRehberi.Controllers
{
    public class PersonController : Controller
    {
        PersonManager pm = new PersonManager(new EfPersonDal());
        public IActionResult Index()
        {
            var values = pm.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPerson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPerson(Person p)
        {
            pm.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeletePerson(int id)
        {
            var value = pm.GetByID(id);
            pm.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditPerson(int id)
        {
            var value = pm.GetByID(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult EditPerson(Person p)
        {
            pm.TUpdate(p);
            return RedirectToAction("Index");
        }


    }
}
