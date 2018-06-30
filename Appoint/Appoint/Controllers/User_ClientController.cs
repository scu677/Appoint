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
        //This interface talks to entity framework objects
        private IAppointRepository repository;
        public User_ClientController(IAppointRepository repo)
        {
            repository = repo;
        }
        //The index method populate the a user view with a User_Client Object
        public IActionResult Index()
        {
            return View(repository.User_Clients);
        }
        //The method queries the User_Clients table for a UserClient with an user_clientId equal to userid.
        //@param userid a userid of a User_Client
        public ViewResult Edit_UserClient(int userId) => View(repository.User_Clients.FirstOrDefault(p => p.User_ClientID == userId));

        //The method is called when a user_client updated an already existing profile or create a new one.
        //@param client An new User_Client object or an already existing User_Client object
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
        // This method is called when a user_client hit the create new user button
        //@param Edith_UserClient the method calls the Edit_UserClient method pass a new 
        // User_Client object to it.
        //@param new User_Client  a new User_Client object
        public ViewResult Create_NewUser() => View("Edit_UserClient", new User_Client());

        //Deletes an already existing User_Client object
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