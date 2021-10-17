using NUnit.Framework;
using TDD_1;

namespace NUnitTest
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StringSetAdd()
        {
            StringSet set = new StringSet();
            Assert.That(() => set.Add("Hello"), Throws.Nothing);
        }

    }
}