﻿using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IFlightMethods
    {
      List<DateTime> GetFlightDates(string destination);
      void GetFlights(string filterType, string filterValue);
        void showFlightDetails(Plane plane);
       void ShowFlightDetails(BoingPlane planeType );

    }
}
