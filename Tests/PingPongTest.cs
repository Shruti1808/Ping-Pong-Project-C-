using Xunit;
using PingPong.Objects;
using System.Collections.Generic;
namespace PingPong
{
  public class PingPongTest
  {
    // [Fact]
    // public void listNumbers_ForPrintingMultiplesOfThree_PrintPing()
    // {
    //   int number01 = 6;
    //   PingPongGenerator newPingPongGenerator = new PingPongGenerator(number01);
    //   List<string> testList = new List<string> { "1", "2", "ping", "4","5","ping" };
    //
    //   List<string> result = newPingPongGenerator.listNumbers();
    //
    //   Assert.Equal(testList, result);
    // }
    [Fact]
    public void listNumbers_ForPrintingMultiplesOfFive_PrintPong()
    {
      int number02 = 10;
      PingPongGenerator newPingPongGenerator = new PingPongGenerator(number02);
      List<string> testList = new List<string> {"1","2","ping","4","pong","ping","7","8","ping","pong"};
      List<string> result = newPingPongGenerator.listNumbers();
      Assert.Equal(testList,result);
    }
    [Fact]
    public void listNumbers_ForPrintingMultiplesOfFifteen_PrintPingPong()
    {
      int number03 = 15;
      PingPongGenerator newPingPongGenerator = new PingPongGenerator(number03);
      List<string> testList = new List<string> {"1","2","ping","4","pong","ping","7","8","ping","pong","11","ping","13","14","pingpong"};
      List<string> result = newPingPongGenerator.listNumbers();
      Assert.Equal(testList,result);
    }

  }
}
