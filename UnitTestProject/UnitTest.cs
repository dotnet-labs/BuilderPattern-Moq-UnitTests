namespace UnitTestProject;

[TestClass]
public class UnitTest
{
    [TestMethod]
    public void TestDataUsingMoq()
    {
        var birthDate = new DateTime(2000, 11, 30);
        var today = new DateTime(2020, 11, 30);

        var employee = Mock.Of<Employee>(x => x.FirstName == "test");
        Assert.AreEqual("test", employee.FirstName);

        employee = Mock.Of<Employee>(x => x.LastName == "test" && x.BirthDate == birthDate);
        Assert.AreEqual("", employee.FirstName);
        Assert.AreEqual("test", employee.LastName);
        Assert.AreEqual(birthDate, employee.BirthDate);
        Assert.AreEqual(20, employee.GetAge(today));

        employee = Mock.Of<Employee>();
        Assert.AreEqual(DateTime.MinValue, employee.BirthDate);
        var exception = Assert.ThrowsException<Exception>(() => employee.GetAge(today));
        Assert.AreEqual("BirthDate has not set a value.", exception.Message);
    }

    [TestMethod]
    public void TestDataUsingBuilder()
    {
        var birthDate = new DateTime(2000, 11, 30);
        var today = new DateTime(2020, 11, 30);

        var employee = new EmployeeBuilder().WithFirstName("test").Build();
        Assert.AreEqual("test", employee.FirstName);

        employee = new EmployeeBuilder().WithLastName("test").WithBirthDate(birthDate).Build();
        Assert.AreEqual("", employee.FirstName);
        Assert.AreEqual("test", employee.LastName);
        Assert.AreEqual(birthDate, employee.BirthDate);
        Assert.AreEqual(20, employee.GetAge(today));
    }

    [TestMethod]
    public void TestNestedObjectUsingMoq()
    {
        var a = new Address { City = "Chicago" };
        var employee = Mock.Of<Employee>(x => x.FirstName == "test" && x.Address == a);
        Assert.AreEqual("test", employee.FirstName);
        Assert.AreEqual("Chicago", employee.Address.City);
        Assert.AreEqual("00000", employee.Address.ZipCode);
    }

    [TestMethod]
    public void TestNestedObjectUsingBuilders()
    {
        var employee = new EmployeeBuilder()
            .WithFirstName("test")
            .WithAddress(new AddressBuilder().WithCity("Chicago").Build())
            .Build();
        Assert.AreEqual("test", employee.FirstName);
        Assert.AreEqual("Chicago", employee.Address.City);
    }
}