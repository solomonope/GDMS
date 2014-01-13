using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using GDataLib.SOL;
using GDataLib.BO;
using GDataLib.BLL;

namespace GDataWeb.Controllers
{
    public class ReadingController : Controller
    {
        ReadingsManager m_Manager;
        public ReadingController()
        {
            m_Manager = new ReadingsManager();
        }
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {

            if (file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/App_Data/uploads"), fileName);
                file.SaveAs(path);

                Processor Per = new Processor(Path.Combine(Server.MapPath("~/App_Data/uploads"), fileName));

                var _Result = Per.Process();

                foreach (var Re in _Result)
                {
                    m_Manager.Upsert(Re);
                }
                return View("summary", _Result);

            }

            return View();
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Readings Reading)
        {
            if (ModelState.IsValid)
            {
                m_Manager.Upsert(Reading);
                return RedirectToAction("AllReadings");
            }
            else
            {
                return View(Reading);
            }
        }

        [HttpGet]
        public ActionResult AllReadings()
        {
            try
            {
                var _Readings = m_Manager.GetAllReadings();
                return View(_Readings);
            }
            catch (Exception Ew)
            {
               return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult Edit(String Id)
        {
            try
            {
                var _Reading = m_Manager.GetById(Id);
                return View(_Reading);
            }
            catch (Exception Ew)
            {
                return RedirectToAction("Index");
            }
        }


        [HttpPost]
        public ActionResult Edit(Readings Reading)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    m_Manager.Update(Reading);
                    return RedirectToAction("AllReadings");
                }
                else
                {
                    return View(Reading);
                }
            }
            catch (Exception Ew)
            {
                return RedirectToAction("AllReadings");
            }
        }


        public ActionResult Delete(String Id)
        {
            try
            {
                var _Reading = m_Manager.GetById(Id);

                m_Manager.Delete(_Reading);

                return RedirectToAction("AllReadings");
            }
            catch (Exception Ew)
            {
                return RedirectToAction("AllReadings");
            }
        }
    }
}
