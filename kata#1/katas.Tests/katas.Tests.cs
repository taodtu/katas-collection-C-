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

        [Theory]
        [InlineData(0, 4, 2)]
        [InlineData(1, 5, 2)]
        [InlineData(3, 7, 4)]
        public void test_modulo(int expected, int a, int b)
        {
            var result = _Katas.modulo(a, b);
            Assert.Equal(expected, actual: result);
        }

        [Theory]
        [InlineData(2, 4)]
        [InlineData(3, 9)]
        [InlineData(1, 1)]
        public void test_squareRoot(int expected, int a)
        {
            var result = _Katas.squareRoot(a);
            Assert.Equal(expected, actual: result);
        }
    }
}
