using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core2MvcPartyInvites.Models
{
    public static class Responses
    {
        private static List<Guest> guestResponses = new List<Guest>();

        public static IEnumerable<Guest> GetAttendees
        {
            get { return guestResponses; }
        }

        public static void AddResponse(Guest guest)
        {
            guestResponses.Add(guest);
        }
    }
}
