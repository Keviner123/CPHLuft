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
   
                foreach (var Route in AE.Routes)
                {

                    var OriginAirport = (from p in AE.Routes
                                  join e in AE.Airports
                                  on p.OriginAirportID equals e.AirportID
                                  where p.AirlineID == Route.AirlineID
                                  select new
                                  {
                                      AirportName = e.Name,
                                  }).ToList()[0];


                    var DestinationAirport = (from p in AE.Routes
                                         join e in AE.Airports
                                         on p.DestinationAirportID equals e.AirportID
                                         where p.AirlineID == Route.AirlineID
                                         select new
                                         {
                                             AirportName = e.Name,
                                         }).ToList()[0];



                    resultstring += Route.OriginAirportID + " - " + OriginAirport.AirportName + " - " + DestinationAirport.AirportName + " " +
                                    Route.DepatureDate + "-" + Route.ArrivalDate + "\n";
                }
            }

            return (resultstring);
        }

    }
}
