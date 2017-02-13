using Nancy;
using System.Collections.Generic;
using PingPong.Objects;

namespace PingPong
{
  public class HomeModule : NancyModule
  {
    public  HomeModule()
    {
      Get["/"] =_=> {
        return View["index.cshtml"];
      };
      Post["/result"] = _ => {
        int userInput = int.Parse(Request.Form["number"]);
        PingPongGenerator newPingPongGenerator = new PingPongGenerator(userInput);
        List<int> listNumbers = newPingPongGenerator.listNumbers();
        return View["view_pingpong", listNumbers];
      };
    }
  }

}
