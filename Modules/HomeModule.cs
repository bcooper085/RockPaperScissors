using Nancy;
using System;
using System.Collections.Generic;
using RPSHands.Objects;

namespace RPSModule
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];

      Post["/move_form"] = _ => {
        RPSHand obj = new RPSHand();
        obj.Output(Request.Form["user1Move"], Request.Form["user2Move"]);

        return View["results.cshtml", obj.output];
      };
    }
  }
}
