using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EMS.Web.EMS.Service;
using System.Web.Mvc;

namespace EMS.Web.Controllers
{
    public class RoleController : Controller
    {
        EmsService emsObj = new EmsService();
        // GET: Role
        public ActionResult Index()
        {

            IList<Models.RoleModel> List = emsObj.GetAllRoles().Select(m => new Models.RoleModel {  Description = m.Description, ID = m.ID }).ToList();
            return View(List);
        }

        // GET: Role/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: Role/Create
        public ActionResult Create()
        {
            Models.RoleModel model = new Models.RoleModel();
            model.Rates =  emsObj.GetAllRates().OrderBy(x => x.Description).Select(x => new SelectListItem { Value = x.ID.ToString(), Text = x.Description });
            return View(model);
        }

        // POST: Role/Create
        [HttpPost]
        public ActionResult Create(Models.RoleModel model)
        {
            try
            {
                // TODO: Add insert logic here

                EMS.Service.RoleModel Servicemodel = new EMS.Service.RoleModel();
                Servicemodel.Description = model.Description;
                Servicemodel.RateID =  Convert.ToInt32(model.SelectedRate);
                string result = emsObj.CreateRole(Servicemodel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Role/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Role/Edit/5
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

        // GET: Role/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Role/Delete/5
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
