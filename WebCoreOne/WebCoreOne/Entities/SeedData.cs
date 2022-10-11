using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCoreOne.Data;

namespace WebCoreOne.Entities
{
    public static class SeedData
    {
        public static void Seed(DataContext context)
        {
            using (context)
            {
                //context.AddRange(new People
                //{
                //    //PeopleId = 1,
                //    FirstName = "Rowan",
                //    LastName = "Ahmed"
                //},
                //new People
                //{
                //    //PeopleId = 2,
                //    FirstName = "Menna",
                //    LastName = "Ahmed"
                //}
                //    );
                context.AddRange(
                    new PersonAdresss
                    {
                        //PersonAdresssId = 1,
                        City = "Alex",
                        StreetName = "123 st name",
                        PeopleId = 1,
                        ZipCode = "61211",
                        State = "TX"
                    },
                      new PersonAdresss
                      {
                          //PersonAdresssId = 2,
                          City = "Cairo",
                          StreetName = "123 st name",
                          PeopleId = 2,
                          ZipCode = "61211",
                          State = "TX"
                      }

                    );
                context.SaveChanges();
                context.Dispose();//to remove the allocated resources
            }

        }
    }
}
