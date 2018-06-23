using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appoint.Models;
using Microsoft.AspNetCore.Mvc;

namespace Appoint.Controllers
{
    public class User_ClientController : Controller
    {
        private IAppointRepository repository;
        public User_ClientController(IAppointRepository repo)
        {
            repository = repo;
        }
        //user_Profile page
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult Edit_UserClient(int partnerId) => View(repository.Partner_Clients.FirstOrDefault(p => p.Partner_ClientID == partnerId));
        [HttpPost]
        public IActionResult Edit_UserClient(User_Client client)
        {
            if (ModelState.IsValid)
            {
                repository.SaveUser_Client(client);
                TempData["message"] = $"{client.Name} has been saved";
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                TempData["message"] = $"{client.Name} has not been saved";
                return View(client);
            }
        }
        public ViewResult Create_NewUser() => View("Edit_UserClient", new User_Client());

        [HttpPost]
        public IActionResult Delete_UserClient(int clientId)
        {
           User_Client deletedUser = repository.delete_UserClient(clientId);
            if (deletedUser != null)
            {
                TempData["message"] = $"{deletedUser.Name} was deleted";
            }
            return RedirectToAction("Index");
        }
    }
}