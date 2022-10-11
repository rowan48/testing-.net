using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreOne.Services
{
   public interface IServicenterface
    {
        Guid MyGuid { get; set; }
    }
    public class Iservice : IServicenterface
    {
        public Guid MyGuid { get; set; }
        public Iservice()
        {
            this.MyGuid = Guid.NewGuid();
        }

        public void sendEmail(string str)
        {
            //TODO

        }

    }
}
