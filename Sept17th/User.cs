using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Sept17th
{
    [TestClass]
    public class User
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public int ID { get; }

        public DateTime BirthDate { get; set;}

        public User() { }

        public User(string firstName, string lastName, int id, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            BirthDate = birthDate;
        }

        public string FullName
        {
            get
            {
                string fullName = $"{FirstName} {LastName}";
                return fullName;
            }
        }

        public int CalculateAge(DateTime birthdate)
        {
                TimeSpan span = DateTime.Now - birthdate;
                double totalAgeDouble = span.Days / 365.25;
                int years = Convert.ToInt32(Math.Floor(totalAgeDouble));
                return years;
        }
    }
}
