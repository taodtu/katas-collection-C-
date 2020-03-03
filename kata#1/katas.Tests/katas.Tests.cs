using Xunit;

namespace katas.Tests
{
    public class Katas_tests
    {
        private readonly Katas _Katas;

        public Katas_tests()
        {
            _Katas = new Katas();
        }
        // test for modulo
        [Theory]
        [InlineData(0, 4, 2)]
        [InlineData(1, 5, 2)]
        [InlineData(3, 7, 4)]
        public void test_modulo(int expected, int a, int b)
        {
            var result = _Katas.modulo(a, b);
            Assert.Equal(expected, actual: result);
        }
        // test for squareRoot
        [Theory]
        [InlineData(2, 4)]
        [InlineData(3, 9)]
        [InlineData(1, 1)]
        public void test_squareRoot(int expected, int a)
        {
            var result = _Katas.squareRoot(a);
            Assert.Equal(expected, actual: result);
        }
        // test for getLength
        [Theory]
        [InlineData(2, "aa")]
        [InlineData(3, "bye")]
        [InlineData(7, "welcome")]
        public void test_getLength(int expected, string a)
        {
            var result = _Katas.getLength(a);
            Assert.Equal(expected, actual: result);
        }
        // test for putNamesTogether
        [Theory]
        [InlineData("Tao Li", "Tao", "Li")]
        [InlineData("James Tom", "James", "Tom")]
        public void test_putNamesTogether(string expected, string a, string b)
        {
            var result = _Katas.putNamesTogether(a, b);
            Assert.Equal(expected, actual: result);
        }
    }
}
