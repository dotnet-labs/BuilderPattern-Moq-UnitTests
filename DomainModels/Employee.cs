using System;

namespace DomainModels
{
    public class Employee
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Address Address { get; private set; }

        protected Employee() { }

        public Employee(int id, string firstname, string lastname, DateTime birthdate, Address address) : this()
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            if (birthdate == default)
            {
                throw new ArgumentException("Date of birth is invalid.", nameof(birthdate));
            }
            BirthDate = birthdate;
            Address = address;
        }

        public int GetAge(DateTime now)
        {
            if (BirthDate == default)
            {
                throw new Exception("BirthDate has not set a value.");
            }

            if (BirthDate >= now) return 0;

            var age = now.Year - BirthDate.Year;
            if (BirthDate.DayOfYear > now.DayOfYear)
            {
                age--;
            }
            return age;
        }
    }
}
