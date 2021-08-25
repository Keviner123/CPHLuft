using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lufthavn
{
    public class AirportDAL
    {
        public string GetAirlines()
        {
            string resultstring = "";

            using (AirportEntities AE = new AirportEntities())
            {

                foreach (var item in AE.Airports)
                {
                    resultstring += item.Name + "\n";

                }
            }

            return (resultstring);
        }

        public string GetRoutes()
        {
            string resultstring = "";

            using (AirportEntities AE = new AirportEntities())
            {
   
                foreach (var item in AE.Routes)
                {

                    var person = (from p in AE.Routes
                                  join e in AE.Airports
                                  on p.OriginAirportID equals e.AirportID µ
                                  where p.AirlineID == item.AirlineID
                                  select new
                                  {
                                      ID = e.Name,


                                  }).ToList();
                    Console.WriteLine(item.OriginAirportID + " - " + person[0].ID);
                    //resultstring += item.OriginAirportID;
                }
            }

            return (resultstring);
        }

    }
}
