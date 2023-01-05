using StringCurrency;

namespace StringCurrency.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void DoesStringReturnValidValue()
        {
            string s = "231";
            Assert.Equal("$231", s.toCurrency());
        }

        [Fact]
        public void DoesStringThrowExceptionInvalidValue()
        {
            string s = "abc";
            Assert.Throws<FormatException>(() => s.toCurrency());
        }

        [Fact]
        public void DoesStringThrowExceptionBigValue()
        {
            string s = "13455667777777777777323232";
            Assert.Equal("$13455667777777777777323232", s.toCurrency());
        }
    }
}