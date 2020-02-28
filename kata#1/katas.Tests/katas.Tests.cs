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

        [Fact]
        public void test_modulo()
        {
            var result1 = _Katas.modulo(4, 2);
            Assert.Equal(result1, 0);

            var result2 = _Katas.modulo(7, 2);
            Assert.Equal(result2, 0);
        }
    }
}
