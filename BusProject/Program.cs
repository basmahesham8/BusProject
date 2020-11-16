

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

            Console.WriteLine("Please enter the Start station and its number : ");
            string startPoint = Console.ReadLine();
            int numOfStartPoint = int.Parse(Console.ReadLine());
            rt.setStartPoint(startPoint);
            rt.setnumOfStartStation(numOfStartPoint);
            Console.WriteLine("Please enter the End station and its number :");
            string endPoint = Console.ReadLine();
            int numOfEndPoint = int.Parse(Console.ReadLine());
            rt.setEndPoint(endPoint);
            rt.setnumOfEndStation(numOfEndPoint);
            Console.WriteLine("The Trip cost is: {0}", rt.cost(rt.getnumOfStartStation(), rt.getnumOfEndStation()));



            Console.ReadKey();
        }
    }
}
