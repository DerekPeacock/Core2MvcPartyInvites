using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core2MvcPartyInvites.Models
{
    public class Guest
    {
        public int GuestID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required(ErrorMessage ="Please say yes or no!")]
        public bool? WillAttend { get; set; }
    }
}
