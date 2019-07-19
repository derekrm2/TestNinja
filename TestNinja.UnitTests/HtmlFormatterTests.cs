using NUnit.Framework;
using NUnit.Framework.Internal;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStrinWithStrongElement()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");

            // specific
            Assert.That(result, Is.EqualTo("<strong>abc</strong>"));

            // more general
            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("abc"));

            // ignore casing
            Assert.That(result, Does.Contain("<STRONG>").IgnoreCase);
        }
    }
}
