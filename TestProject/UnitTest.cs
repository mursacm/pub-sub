using System.Linq;
using NUnit.Framework;
using PubSub;

namespace TestProject
{
    public class Tests
    {
        [TestCase("test string", "TEST STRING")]
        [TestCase("another Test string #$%", "ANOTHER TEST STRING #$%")]
        [TestCase("TESTing UpperCase STrInG", "TESTING UPPERCASE STRING")]
        public void TestString(string testValue, string expectedValue)
        {
            Pub pub = new Pub();
            string result = string.Empty;
            pub.OnChange += (sender, args) => result = args.Data;
            pub.Raise(testValue);
            Assert.AreEqual(result, expectedValue);
        }
        
        [TestCase("test sTring 2")]
        public void TestLowercase(string testValue)
        {
            Pub pub = new Pub();
            string result = string.Empty;
            pub.OnChange += (sender, args) => result = args.Data;
            pub.Raise(testValue);
            Assert.IsFalse(result.Any(char.IsLower));
        }
    }
}