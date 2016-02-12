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
        return View["contact_all.cshtml"];
      };
      Post["contact_created"] = _ => {
        Contact newContact = new Contact(Request.Form["new-name"], Request.Form["new-phone"], Request.Form["new-address"]);
        return View["contact_created.cshtml", newContact];
      };


    } //closes HomeModule function
  } // closes HomeModule class
} // closes namespace
