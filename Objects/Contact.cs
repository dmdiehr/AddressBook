using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private int _id;
    private string _name;
    private string _phone;
    private string _address;
    private static Dictionary<int, Contact> _contactInstances = new Dictionary<int, Contact> {};

    public Contact(string name, string phone, string address)
    {
      _name = name;
      _phone = phone;
      _address = address;
      _contactInstances.Add(_contactInstances.Count, this);
      _id = _contactInstances.Count;

    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public string GetPhone()
    {
      return _phone;
    }
    public void SetPhone(string newPhone)
    {
      _phone = newPhone;
    }
    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }
    public int GetId()
    {
      return _id;
    }
    public static Dictionary<int, Contact> GetAll()
    {
      return _contactInstances;
    }
    public static void DeleteAll()
    {
      _contactInstances.Clear();
    }
  }
}
