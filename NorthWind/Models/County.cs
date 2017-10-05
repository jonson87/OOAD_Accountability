using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.Models
{
    public class County
    {
        public int CountyId { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
    }
}
