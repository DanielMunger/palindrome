using Nancy;
using System.Collections.Generic;
using System;
using Palindromes.Objects;

namespace Palindromes
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["TEMPLATE.cshtml"];
      };

    }
  }
}
