using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/contact_new"] = _ => {
        return View["contact_new.cshtml"];
      };
      Get["/contact_all"] = _ => {
        Dictionary<int, Contact> allContacts = Contact.GetAll();
        return View["contact_all.cshtml", allContacts];
      };
      Post["contact_created"] = _ => {
        Contact newContact = new Contact(Request.Form["new-name"], Request.Form["new-phone"], Request.Form["new-address"]);
        return View["contact_created.cshtml", newContact];
      };
      Post["contact_deleted"] = _ => {
        Contact.DeleteAll();
        return View["/contact_deleted"];
      };


    } //closes HomeModule function
  } // closes HomeModule class
} // closes namespace
