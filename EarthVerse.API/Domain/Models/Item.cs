using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarthVerse.API.Domains.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }

        //For linking purposes
        public Equipment Equipment { get; set; }
    }
}
