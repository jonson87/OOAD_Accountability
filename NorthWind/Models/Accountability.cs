using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.Models
{
    public class Accountability
    {
        public int AccountabilityId { get; set; }
        //public int AccountabilityTypeId { get; set; }
        //public AccountabilityType AccountabilityType { get; set; }
        public int CommissionerId { get; set; }
        public Party Commissioner { get; set; }
        public int ResponsibleId { get; set; }
        public Party Responsible { get; set; }
    }
}
