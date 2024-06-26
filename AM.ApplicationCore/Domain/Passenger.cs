using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public string PassportNumber { get; set; }
        public String FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int TelNumber { get; set; }
        public string EmailAddress { get; set; }
        public List<Flight> Flights { get; set; }
        public ICollection<Flight> Flights { get; set; } 
        //public Boolean CheckProfile(string FirstName, string LastName)
        //{
        //    return (this.FirstName == FirstName && this.LastName == LastName);

        //}
        //public Boolean CheckProfile(string FirstName, string nom, string email)
        //{
        //    return (this.FirstName == FirstName && LastName == nom && EmailAdress == email);

        //}
        public Boolean CheckProfile(string FirstName, string LastName,string email=null)
        {
            if(email==null)
            return (this.FirstName == FirstName && this.LastName == LastName);
            else
            return (this.FirstName == FirstName && this.LastName == LastName && EmailAddress == email);
        }

        public virtual void PassengerType()
        { 
            Console.Write("I am a passenger"); 
        }
    }
}
