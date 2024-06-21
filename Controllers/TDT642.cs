using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TDTBaiThiLai.Controllers
{
    public class TDT642 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int Id, int Name, int Day)
        {
            
            int = "xin chào " + Id + "tên " + Name + "ngày" + Day;

            ViewBag

            return View();
        }
    }
}