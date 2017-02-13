using System.Collections.Generic;
namespace PingPong.Objects
{
  public class PingPongGenerator
  {
    private int _number;
    private List<string> _listPingPong = new List<string> {};

    public PingPongGenerator(int number)
    {
      _number = number;
    }

    public List<string> listNumbers()
    {
      if (_number < 1)
      {
        _listPingPong.Add("Please enter a positive number");
      }
      else{
        for(int i = 1; i <= _number; i++)
        {
          if(i % 15 == 0)
          {
            _listPingPong.Add("pingpong");
          }
          else if (i % 3 ==0)
          {
            _listPingPong.Add("ping");
          }
          else if (i % 5 == 0){
            _listPingPong.Add("pong");
          }
          else
          {
            _listPingPong.Add(i.ToString());
          }
        }
      }
      return _listPingPong;
    }
  }
}
