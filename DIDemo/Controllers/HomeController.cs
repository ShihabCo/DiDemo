using DIDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DIDemo.Services.IServices;

namespace DIDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPermissionServiceScoped _scopedService;
        private readonly IPermissionServiceSingleton _singletonService;
        private readonly IPermissionServiceTransient _transientService;


        public HomeController(IPermissionServiceScoped scopedService, IPermissionServiceSingleton singletonService,
            IPermissionServiceTransient transientService)
        {
            _scopedService = scopedService;
            _singletonService = singletonService;
            _transientService = transientService;
        }

        public IActionResult Index()
        {
    ;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Access(string secret)
        {
            //pass secret to service
            _scopedService.setPermission(secret);
            _singletonService.setPermission(secret);
            _transientService.setPermission(secret);

            return View();
            //return view
        }

       
    }
}
