using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookKeeping.Models
{
    public class BookKeeperListModel
    {
        public readonly BookKeepingContext context;

        public BookKeeperListModel()
        {
            //this.context = context;
        }

        public IEnumerable<BookKeeper> Bookkeepers { get; set; }



    }
}
