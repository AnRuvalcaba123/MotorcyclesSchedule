using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcyclesSchedule
{
    public class Schedule
    {
        public Schedule(int Rides, string Time)
        {
            this.Rides = Rides;
            this.Time = Time;
        }
        public int Rides { get; set; }
        public string Time { get; set; }
    }
}
