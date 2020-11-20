

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusProject
{
    class Program
    {
        static void Main(string[] args)
        {

            RideTrip rt = new RideTrip();
            Route lines = new Route();

            Console.WriteLine("Please Choose the Start point :");
            Console.WriteLine("Stations for line1: 1 for "+lines.line1[0]+ ", 2 for "+ lines.line1[1]+", 3 for "+lines.line1[2]
                +", 4 for "+lines.line1[3]+", 5 for "+lines.line1[4]+", 6 for "+lines.line1[5]+", 7 for "+ lines.line1[6]);
            Console.WriteLine("--------------------------------------------");

           
            
            int numOfStartPoint = int.Parse(Console.ReadLine());
            rt.setnumOfStartStation(numOfStartPoint);


            Console.WriteLine("Please Choose the End point :");
            Console.WriteLine("Stations for line1: 1 for "+ lines.line1[0]+ ", 2 for "+ lines.line1[1]+ ", 3 for "+ lines.line1[2]+ ", 4 for "+ lines.line1[3]+ ", 5 for "+ lines.line1[4]+ ", 6 for "+ lines.line1[5]+ ", 7 for "+ lines.line1[6]);
            Console.WriteLine("--------------------------------------------");

            int numOfEndPoint = int.Parse(Console.ReadLine());
            rt.setnumOfEndStation(numOfEndPoint);


            Console.WriteLine("The Trip cost is: {0}", rt.cost(rt.getnumOfStartStation(), rt.getnumOfEndStation()));
            Console.ReadKey();
        }
    }
}
