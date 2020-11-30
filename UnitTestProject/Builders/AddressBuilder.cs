using DomainModels;

namespace UnitTestProject.Builders
{
    public class AddressBuilder
    {
        private string _street;
        private string _city;
        private string _state;
        private string _zipCode;

        public AddressBuilder()
        {
            // set default values
            _street = string.Empty;
            _city = string.Empty;
            _state = string.Empty;
            _zipCode = string.Empty;
        }

        public AddressBuilder WithStreet(string street)
        {
            _street = street;
            return this;
        }

        public AddressBuilder WithCity(string city)
        {
            _city = city;
            return this;
        }

        public AddressBuilder WithState(string state)
        {
            _state = state;
            return this;
        }

        public AddressBuilder WithZipCode(string zipCode)
        {
            _zipCode = zipCode;
            return this;
        }

        public Address Build()
        {
            return new Address(_street, _city, _state, _zipCode);
        }
    }
}
