using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appoint.Models
{
    public class EFAppointRepository : IAppointRepository
    {
        private ApplicationDbContext context;
        //Initializing the entityframework Db context and retrieving
        //dataset(tables) of object of relational database
        public EFAppointRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<User_Client> User_Clients => context.User_Clients;

        IQueryable<Booking> IAppointRepository.Bookings => context.Bookings;

        IQueryable<Service> IAppointRepository.Services => context.Services;



        IQueryable<Partner_Client> IAppointRepository.Partner_Clients => context.Partner_Clients;

        IQueryable<Schedule> IAppointRepository.Schedules => context.Schedules;

        public void SaveBooking(Booking booking)
        {
            throw new NotImplementedException();
        }

        public void SavePartner_Client(Partner_Client client)
        {
            throw new NotImplementedException();
        }

        public void SaveSchedule(Schedule schedule)
        {
            throw new NotImplementedException();
        }

        public void SaveService(Service service)
        {
            throw new NotImplementedException();
        }

        public void SaveUser_Client(User_Client User_Client)
        {
            if (User_Client.User_ClientID == 0)
            {
                context.User_Clients.Add(User_Client);
            }
            else
            {
                User_Client dbEntry = context.User_Clients
                .FirstOrDefault(p => p.User_ClientID == User_Client.User_ClientID);
                if (dbEntry != null)
                {
                    dbEntry.Email = User_Client.Email;
                    dbEntry.Password = User_Client.Password;
                    dbEntry.Name = User_Client.Name;
                    dbEntry.Street = User_Client.Street;
                    dbEntry.Phone = User_Client.Phone;
                    dbEntry.Postcode = User_Client.Postcode;
                    dbEntry.City = User_Client.City;
                    
                }
            }
            context.SaveChanges();
        }
        public User_Client delete_UserClient(int clientID)
        {
            User_Client dbEntry = context.User_Clients
            .FirstOrDefault(p => p.User_ClientID == clientID);
            if (dbEntry != null)
            {
                context.User_Clients.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        public Partner_Client delete_PartnerClient(int clientID)
        {
            throw new NotImplementedException();
        }

        public Booking delete_Booking(int bookingID)
        {
            throw new NotImplementedException();
        }

        public Schedule delete_Schedule(int scheduleID)
        {
            throw new NotImplementedException();
        }

        public Service delete_Service(int serviceID)
        {
            throw new NotImplementedException();
        }
    }
}
