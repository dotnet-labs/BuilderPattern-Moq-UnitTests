using System;
using DomainModels;

namespace UnitTestProject.Builders
{
    public class EmployeeBuilder
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private DateTime _birthDate;
        private Address _address;

        public EmployeeBuilder()
        {
            _id = 0;
            _firstName = string.Empty;
            _lastName = string.Empty;
            _birthDate = DateTime.Today;
        }

        public EmployeeBuilder WithId(int id)
        {
            _id = id;
            return this;
        }

        public EmployeeBuilder WithFirstName(string firstName)
        {
            _firstName = firstName;
            return this;
        }

        public EmployeeBuilder WithLastName(string lastName)
        {
            _lastName = lastName;
            return this;
        }

        public EmployeeBuilder WithBirthDate(DateTime date)
        {
            _birthDate = date;
            return this;
        }

        public EmployeeBuilder WithAddress(Address address)
        {
            _address = address;
            return this;
        }

        public Employee Build()
        {
            return new Employee(_id, _firstName, _lastName, _birthDate, _address);
        }
    }
}
