using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookKeeping.Models
{
    public class Reviews
    {
        [Key]
        public int ReviewID { get; set; }
        public int ClientID { get; set; }
        public string Comment { get; set; } 
        public int Rating { get; set; } 
        public int BookKeeperID { get; set; }

    }
}
