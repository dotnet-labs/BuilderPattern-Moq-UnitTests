namespace DomainModels
{
    public class Address
    {
        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }

        protected Address()
        {
            ZipCode = "00000";
        }
        public Address(string street, string city, string state, string zipCode) : this()
        {
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
        }
    }
}
