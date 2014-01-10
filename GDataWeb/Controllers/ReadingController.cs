using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using GDataLib.SOL;
using GDataLib.BO;

namespace GDataWeb.Controllers
{
    public class ReadingController : Controller
    {
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
                var _Table = "";

                if (_Result != null)
                {
                    ViewBag.Result = _Result;
                    var _Header = "<table border = '1'><tr> <td>Date</td> <td>Field</td> <td>Oil Produced(bbl/d)</td> <td>Gas Lift(mmscf/d)</td> <td>Nag Prod(mmscf/d)</td> <td>Cond Prod(bbl/d)</td> <td>BS & Prod(%)</td><td>AG(mmscf/d)</td></tr>";
                    var _Body = "";
                    foreach (var _datarow in _Result)
                    {
                        _Body += String.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td><td>{7}</td></tr>", _datarow.Date, _datarow.Field, _datarow.OilProduced, _datarow.GasLift, _datarow.NAGProduced, _datarow.CONGProduced, _datarow.BSWProduced, 0.0);

                    }

                    var _Footer = "</table>";

                    _Table = _Header + _Body + _Footer;
                }

                ViewBag.Rnd = _Table;

                return View("summary", _Result);

            }

            return View();
        }


       
       
    }
}
