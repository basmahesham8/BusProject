using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusProject
{
    class RideTrip
    {
        
        private int numOfStartStation;
        private int numOfEndStation;

        
        public void setnumOfStartStation(int numOfStartStation)
        {
            this.numOfStartStation = numOfStartStation;
        }
        public int getnumOfStartStation()
        {
            return numOfStartStation;
        }

        public void setnumOfEndStation(int numOfEndStation)
        {
            this.numOfEndStation = numOfEndStation;
        }
        public int getnumOfEndStation()
        {
            return numOfEndStation;
        }

       
        public int cost(int numOfStartStation, int numOfEndStation)
        {
            int Cost = Math.Abs((numOfStartStation - numOfEndStation) * 2);

            return Cost;
        }


    }
}
