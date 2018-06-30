using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appoint.Models
{
    public class FakeAppointRepository/*IAppointRepository*/
    {
        

        public IQueryable<Booking> Bookings => throw new NotImplementedException();

        public IQueryable<Service> Services => throw new NotImplementedException();

        public IQueryable<Partner_Client> Partner_Clients => throw new NotImplementedException();

        public IQueryable<User_Client> User_Clients => new List<User_Client> {
            new User_Client{ Name = "Uche", Email ="ujay.noble@gmail.com", Password = "secreat", Phone ="7099860099"},
            new User_Client{ Name = "Wilson", Email ="wilson@yahoo.com", Password = "secreat1", Phone ="7099860098"},
            new User_Client{ Name = "Sampson", Email ="Sampson@yahoo.com", Password = "secreat2", Phone ="7099860097"},
            new User_Client{ Name = "Baban", Email ="baban@yahoo.com", Password = "secreat1", Phone ="7099860096"}

        }.AsQueryable<User_Client>();

        public IQueryable<Schedule> Schedules => throw new NotImplementedException();
    }
}
