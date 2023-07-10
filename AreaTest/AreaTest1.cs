using AreaSolution;

namespace AreaTest
{
    public class AreaTest1
    {
        [Fact]
        public void TestArea()
        {
            int r = 12;
            double expected = 452.16;
            double res = Area.AreaResult(r);
            Assert.Equal(expected, res);
        }
    }
}