using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Appoint.Models;

namespace Appoint.Controllers
{
    public class HomeController : Controller
    {
        private IAppointRepository repository;
        public HomeController(IAppointRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult List() => View(repository.User_Clients);
       
    
}
}