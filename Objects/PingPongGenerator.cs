using System.Collections.Generic;
namespace PingPong.Objects
{
  public class PingPongGenerator
  {
    private int _number;
    private List<int> _listPingPong = new List<int> {};

    public PingPongGenerator(int number)
    {
      _number = number;
    }

    public List<int> listNumbers()
    {
      for(int i = 1; i <= _number; i++)
      {
        _listPingPong.Add(i);
      }
      return _listPingPong;
    }
  }
}
