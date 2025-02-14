﻿using SmartShop.Web.Areas.Admin.Models;
using SmartShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartShop.Web.Areas.Admin.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Admin/Customer
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetJsonData(DataTablesAjaxRequestModel request)
        {
            var jsonData = new CustomerModel().GetCustomerJsonData(request);

            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }
    }
}