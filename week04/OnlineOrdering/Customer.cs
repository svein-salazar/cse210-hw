using System;

class Customer
{
    public string Name { get; private set; }
    private Address _address;

    public Customer(string name, Address address)
    {
        Name = name;
        _address = address;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetShippingLabel()
    {
        return $"{Name}\n{_address.GetFullAddress()}";
    }
}
