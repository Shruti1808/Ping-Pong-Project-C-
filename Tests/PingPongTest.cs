using Xunit;
using PingPong.Objects;
using System.Collections.Generic;
namespace PingPong
{
  public class PingPongTest
  {
    [Fact]
    public void listNumbers_ForPrintingNumbers_PrintNumbers()
    {
      int number01 = 3;
      PingPongGenerator newPingPongGenerator = new PingPongGenerator(number01);
      List<int> testList = new List<int> { 1, 2, 3 };

      List<int> result = newPingPongGenerator.listNumbers();

      Assert.Equal(testList, result);
    }
  }
}
