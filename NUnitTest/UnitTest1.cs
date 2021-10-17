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

        [Test]
        public void StringSetContains()
        {
            StringSet set = new StringSet();
            Assert.That(() => set.Contains("Hello"), Is.False);
        }

        [Test]
        public void StringSetRemove()
        {
            StringSet set = new StringSet();
            set.Add("Hello");
            Assert.That(() => set.Remove("Hello"), Throws.Nothing);
        }

    }
}