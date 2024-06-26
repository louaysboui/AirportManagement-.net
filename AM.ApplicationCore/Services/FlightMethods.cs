using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class FlightMethods : IFlightMethods
    {
        public List<Flight> Flights { get; set; }=new List<Flight>();

        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> dates = new List<DateTime>();
            foreach(Flight f in Flights)
            {
                if (f.Destination == destination)
                {
                    dates.Add(f.FlightDate);
                    Console.WriteLine(f.FlightDate);
                }
            }
            return dates;
        }

        public void GetFlights(string filterType, string filterValue)
        {
            switch(filterType)
            {
                case "Destination":
                   {
                        foreach(Flight f in Flights)
                            if(f.Destination.Equals(filterValue))
                                Console.WriteLine(f);
                        break;
                    }
                case "Departure":
                    {
                        foreach (Flight f in Flights)
                            if (f.Departure.Equals(filterValue))
                                Console.WriteLine(f);
                        break;
                    }
                case "FlightDate":
                    {
                        foreach (Flight f in Flights)
                            if (f.FlightDate.Equals(DateTime.Parse(filterValue)))
                                Console.WriteLine(f);
                        break;
                    }
                case "EstimatedDuration":
                    {
                        foreach (Flight f in Flights)
                            if (f.EstimatedDuration.Equals(int.Parse(filterValue)))
                                Console.WriteLine(f);
                        break;
                    }
            }
             void ShowFlightDeatails(Plane plane)
            {
                var req = from f in Flights
                          where f.Plane == plane
                          select new(f.FlightDate, f.Destination);
                foreach (var f in req)
                {
                    Console.WriteLine(f);
                }
            }

            public void ProgrammedFlightNumber(DateTime startDate)
            {
                var req = from f in Flights 
                          where ( f.FlightDate - startDate).TotalDays<=7 && (f.FlightDate - startDate).TotalDays> 0 

                          return req.Count

            }
            public double DurationAverage(string destination  )
            {
                 var req=from f in Flights 
            }
            public IEmmerableTraveller > SeniorTravellers(Flight flight){
                var req = from f in Flights.Passsengers.
            }
            public IEnumerable<IGrouping<string, Flight>>DestintionGroupedFlights()
             {
              var req = from f in Flights
                        groupe f by 

             }
             public FlightMethods()
              {
                    

              }

    }
    }
}
