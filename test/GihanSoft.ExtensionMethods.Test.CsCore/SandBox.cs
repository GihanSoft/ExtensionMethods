using System.Text;
using Xunit;

public class SandBox {
    [Fact]
    public void TestName () {
        Encoding.RegisterProvider (CodePagesEncodingProvider.Instance);
        var encodings = Encoding.GetEncodings ();
    }
}