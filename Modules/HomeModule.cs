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

    } //closes HomeModule function
  } // closes HomeModule class
} // closes namespace
