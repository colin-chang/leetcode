using Amazon.Solutions;
using Xunit;

namespace Amazon.Test
{
    public class TwoSumTest
    {
        [Fact]
        public void Test()
        {
            var nums = new[] {2, 7, 11, 15};
            var target = 9;

            var res = Solution.TwoSum(nums, target);
            Assert.Equal(new[] {0, 1}, res);
        }
    }
}