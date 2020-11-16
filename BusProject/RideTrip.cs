using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusProject
{
    class RideTrip
    {
        private string startPoint;
        private string endPoint;
        private int numOfStartStation;
        private int numOfEndStation;

        public void setStartPoint(string startPoint)
        {
            this.startPoint = startPoint;
        }
        public string getStartPoint()
        {
            return startPoint;
        }

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

        public void setEndPoint(string endPoint)
        {
            this.endPoint = endPoint;
        }
        public string getEndPoint()
        {
            return endPoint;
        }

        public int cost(int numOfStartStation, int numOfEndStation)
        {
            int Cost = Math.Abs((numOfStartStation - numOfEndStation) * 2);

            return Cost;
        }

    }
}
