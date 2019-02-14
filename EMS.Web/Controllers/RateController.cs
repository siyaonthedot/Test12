using System;
using System.Collections.Generic;
using System.Linq;
using EMS.Web.EMS.Service;
//using EMS.Web.Models;;
using EMS.Web.Models;
using System.Web.Mvc;

namespace EMS.Web.Controllers
{
    public class RateController : Controller
    {
        EmsService emsObj = new EmsService();

        // GET: Rate
        public ActionResult Index()
        {
           IList<Models.RateModel> List = emsObj.GetAllRates().
           Select(m=> new Models.RateModel { Amount = m.Amount, Description = m.Description, ID = m.ID}).ToList();

           return View(List);
        }

        // GET: Rate/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Rate/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rate/Create
        [HttpPost]
        public ActionResult Create(Models.RateModel model)
        {
            try
            {
                EMS.Service.RateModel Servicemodel = new EMS.Service.RateModel();
                Servicemodel.Description = model.Description;
                Servicemodel.Amount = model.Amount ?? 0;
                string result = emsObj.CreateRate(Servicemodel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rate/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Rate/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rate/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Rate/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
