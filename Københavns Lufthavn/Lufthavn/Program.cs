using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lufthavn
{
    class Program
    {



        static void Main(string[] args)
        {
            AirportDAL AD = new AirportDAL();

            Console.WriteLine(AD.GetRoutes());



            Console.ReadKey();
        }
    }
}
