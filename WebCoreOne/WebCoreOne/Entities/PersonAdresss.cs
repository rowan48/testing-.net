using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreOne.Entities
{
    public class PersonAdresss
    {

        public int PersonAdresssId { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public int PeopleId { get; set; }
        public People People { get; set; }
    }
}
