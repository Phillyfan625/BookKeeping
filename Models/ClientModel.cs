using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookKeeping.Models
{
    public class ClientModel
    {
        public int ClientID { get; set; } 
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string PhoneNumner { get; set; } 
        public string EmailAddress { get; set; } 
        public int BookKeeperID { get; set; }
    }
}
