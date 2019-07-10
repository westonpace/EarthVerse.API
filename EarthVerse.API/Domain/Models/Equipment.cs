using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarthVerse.API.Domains.Models
{
    public class Equipment
    {
        public int EquipmentID { get; set; }
        public EquipmentType equipmentType { get; set; }

        //Foreign key
        public int ItemID { get; set; }
        public Item Item {get; set; }
    }
}