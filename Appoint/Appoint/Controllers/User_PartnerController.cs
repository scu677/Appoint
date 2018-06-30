using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appoint.Models;
using Microsoft.AspNetCore.Mvc;

namespace Appoint.Controllers
{
    public class User_PartnerController : Controller
    {
        private IAppointRepository repository;
        public User_PartnerController(IAppointRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}