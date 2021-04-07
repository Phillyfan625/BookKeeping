using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookKeeping.Models
{
    public class BookKeeperListModel
    {
        public readonly BookKeepingContext context;

        public BookKeeperListModel(BookKeepingContext context)
        {
            this.context = context;
        }

        //public IList<BookKeeper> Bookkeepers { get; set; }


    }
}
