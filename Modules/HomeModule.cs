using Nancy;
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
        PingPongGenerator newPingPongGenerator = new PingPongGenerator(Request.Form["number"]);
        int listNumbers = newPingPongGenerator.listNumbers();
        return View["view_pingpong", listNumbers];
      };
    }
  }

}
