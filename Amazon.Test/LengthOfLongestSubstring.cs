using System.Security.Cryptography;
using Amazon.Solutions;
using Xunit;

namespace Amazon.Test
{
    public class LengthOfLongestSubstring
    {
        [Fact]
        public void Test()
        {
            var s1 = "abba";
            Assert.Equal(2, Solution.LengthOfLongestSubstring(s1));
            
            var s2 = "bbbbb";
            Assert.Equal(1, Solution.LengthOfLongestSubstring(s2));
            
            var s3 = "abcdbedfg";
            Assert.Equal(5, Solution.LengthOfLongestSubstring(s3));
            
            var s4 = "abcdbecfg";
            Assert.Equal(6, Solution.LengthOfLongestSubstring(s4));
        }
    }
}