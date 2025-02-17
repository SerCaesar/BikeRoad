using System;
using System.Collections.Generic;
using System.Text;

namespace BikeRoad
{
    [Serializable()]
    public class Travel
    {
        public DateTime dateTravel;
        public decimal km;
        public decimal avarage;
        public int hours;
        public int mins;
        public int secs;
        public string road;

        public Travel(DateTime dt, decimal km, decimal avarage, int hours, int mins, int secs, string road)
        {
            dateTravel = dt;
            this.km = km;
            this.avarage = avarage;
            this.hours = hours;
            this.mins = mins;
            this.secs = secs;
            this.road = road;
        }

    }
}
