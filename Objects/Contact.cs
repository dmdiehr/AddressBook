using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private int _id;
    private string _name;
    private string _phone;
    private string _address;
    private static List<Contact> _contactInstances = new List<Contact> {}

    public Contact(string name, string phone, string address)
    {
      _name = name;
      _phone = phone;
      _address = address;
      _contactInstances.Add(this);
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
    public static List<Contact> GetAll()
    {
      return _contactInstances;
    }
    public static Contact Find(int searchId)
    {
      return _placeInstances[searchId-1];
    }



    // public void // create SetMethod(parameter newElementVariable)
    // {
    //   // set class element = newElementVariable;
    }

  }
}
