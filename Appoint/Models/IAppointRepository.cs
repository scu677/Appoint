using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appoint.Models
{
  public  interface IAppointRepository
    {
        IQueryable<Booking> Bookings { get; }
        IQueryable<Service> Services { get; }
        IQueryable<Partner_Client> Partner_Clients { get; }
        IQueryable<User_Client> User_Clients { get; }
        IQueryable<Schedule> Schedules { get; }
        void SaveUser_Client(User_Client client);
        void SavePartner_Client(Partner_Client client);
        void SaveBooking(Booking booking);
        void SaveService(Service service);
        void SaveSchedule(Schedule schedule);
        User_Client delete_UserClient(int clientID);
        Partner_Client delete_PartnerClient(int clientID);
        Booking delete_Booking(int bookingID);
        Schedule delete_Schedule(int scheduleID);
        Service delete_Service(int serviceID);
    }
}
