using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreOne.Entities
{
    public class People
    {
        public int PeopleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
       public List<PersonAdresss> PersonAdressses { get; set; }
    }
}
