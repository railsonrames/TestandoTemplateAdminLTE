using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestandoTemplateAdminLTE.Areas.Admin.Controllers
{
    [Area("admin")]
    public class DashboardController : Controller
    {
        [Route("")]
        [Route("admin")]
        [Route("index")]
        [Route("admin/dashboard")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("admin/dashboard2")]
        public IActionResult Dashboard2()
        {
            return View();
        }
    }
}