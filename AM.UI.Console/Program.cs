// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;

Console.WriteLine("Hello, World!");
Plane plane = new Plane();
plane.Capacity = 100;
Console.WriteLine(plane.Capacity);
plane.ManufactureDate = DateTime.Now;
plane.PlaneType = PlaneType.Boeing;
//Initialiseur d'objets
Plane plane2 = new Plane { Capacity=200
                        ,ManufactureDate= new DateTime(2023,09,01) };
Console.WriteLine(plane);
//tester CheckProfile
Passenger p1 = new Passenger {FirstName="Amina",LastName="Aoun",EmailAddress="amina.aoun@esprit.tn" };
Console.WriteLine(p1.CheckProfile("Amina", "Aoun") );
Console.WriteLine(p1.CheckProfile("Amina", "Aoun", "a")); 
//tester la méthode PassengerType
Staff s1= new Staff();
Traveller t1 = new Traveller();

p1.PassengerType();
s1.PassengerType();
t1.PassengerType();
Console.WriteLine("**********GetFlightDates****************");
FlightMethods fm= new FlightMethods();
fm.Flights = TestData.listFlights;
fm.GetFlightDates("Madrid");
Console.WriteLine("**********GetFlights****************");
fm.GetFlights("Destination", "Paris");
Console.WriteLine("*********Show Flight Details***********");
fm.ShowFlightDetails(TestData.BoingPlane); 
DateTime()

