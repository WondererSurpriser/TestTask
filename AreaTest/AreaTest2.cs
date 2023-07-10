using AreaSolution;

namespace AreaTest
{
    public class AreaTest2
    {
        [Fact]
        public void TestArea2()
        {
            double[] sides = { 8, 6, 9 };
            double expected = 23.525252389719434;
            double res = Area.AreaResult(sides);
            Assert.Equal(expected, res);
        }
    }
}
