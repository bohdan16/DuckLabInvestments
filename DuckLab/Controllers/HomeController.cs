﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using DuckLab.Models;
using System.Data.Entity;

namespace DuckLab.Controllers
{
    public class HomeController : Controller
    {
        private ducklabdbEntities db = new ducklabdbEntities();
        
        public ActionResult Index()
        {
            return View();
        }

    }
}