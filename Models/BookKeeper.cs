using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookKeeping.Models
{
    public class BookKeeper
    {
        public int BookKeeperID { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public int PayRate { get; set; }
        public string FirstName { get; set; }
        public string Image { get; set; }

    }
}
