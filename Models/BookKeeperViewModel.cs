using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookKeeping.Models
{
    public class BookKeeperViewModel
    {
        public BookKeeper bookKeeper { get; set; } 
        public Client client { get; set; } 
        public Reviews review { get; set; } 
    }
}
