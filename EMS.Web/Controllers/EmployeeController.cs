using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using EMS.Model;
//using EMS.Web.EmsService;
using EMS.Web.EMS.Service;
using System.Web.Mvc;

namespace EMS.Web.Controllers
{
    public class EmployeeController : Controller
    {

        EmsService emsObj = new EmsService();

        // GET: Employee
        public ActionResult Index()
        {
            IList<Models.EmployeeModel> List = emsObj.GetAllEmployees().
                Select(m => new Models.EmployeeModel { Name = m.Name, ID = m.ID, DateHired = m.DateHired.ToString("dd/MM/yyyy")
                ,DOB = m.DOB, IDNumber = m.IDNumber, Surname = m.Surname}).ToList();
            return View(List);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            Models.EmployeeModel model = new Models.EmployeeModel();
            model.Roles = emsObj.GetAllRoles().OrderBy(x => x.Description).Select(x => new SelectListItem { Value = x.ID.ToString(), Text = x.Description });
            return View(model);
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Models.EmployeeModel model)
        {
            try
            {
                EMS.Service.EmployeeModel serviceModel = new EMS.Service.EmployeeModel();
                serviceModel.Surname = model.Surname;
                serviceModel.Name = model.Name;
                serviceModel.IDNumber = model.IDNumber;
                serviceModel.SelectedRole = model.SelectedRole;
                serviceModel.DateHired = DateTime.Now;


                //serviceModel.DateHired = model.DateHired;
              //  serviceModel. = model.DOB;
               // serviceModel.DOB = model.DOB;



                string result = emsObj.CreateEmployee(serviceModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
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

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
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
