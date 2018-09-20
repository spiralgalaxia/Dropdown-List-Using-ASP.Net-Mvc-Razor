using App1_DropDownList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App1_DropDownList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("DropDown");
        }
        public ActionResult DropDown()
        {
            PartsViewModel partsViewModel = new PartsViewModel();

            //Get list of options
            utility utility = new utility();
            var sortOptions = utility.GetOptions();

            //DropDownList property of view model will contain a list of all options.
            partsViewModel.DropDownList = utility.SetOptions(sortOptions);

            return View(partsViewModel);
        }
        [HttpPost]
        public ActionResult DropDown(PartsViewModel partsViewModel)
        {
            if(ModelState.IsValid)
            {
                {
                    //'PartsViewModel.DropDownValue' property will contain your selected value
                    //Do your stuff with this value such as DB update, etc
                }

                //Get list of options
                utility utility = new utility();
                var sortOptions = utility.GetOptions();

                //DropDownList property of view model will contain a list of all options. 
                partsViewModel.DropDownList = utility.SetOptions(sortOptions);
            }
            return View(partsViewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return RedirectToAction("DropDown");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return RedirectToAction("DropDown");
        }
    }
}