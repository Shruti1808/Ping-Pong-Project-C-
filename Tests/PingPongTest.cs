using Xunit;
namespace PingPong
{
  public class PingPongTest
  {
    [Fact]
    public void listNumbers_ForPrintingNumbers_PrintNumbers()
    {
      int number01 = 1;
      PingPongGenerator newPingPongGenerator = new PingPongGenerator(number01);

      int result = newPingPongGenerator.listNumbers();

      Assert.Equal(number01, result);
    }
  }
}
