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

        [Test]
        public void StringSetCountItems()
        {
            StringSet set = new StringSet();
            set.Add("Hello");
            Assert.That(() => set.CountItems(), Is.EqualTo(1));
        }

        [Test]
        public void StringSetUnion()
        {
            StringSet setA = new StringSet();
            setA.Add("Hello");
            setA.Add("Good day");
            StringSet setB = new StringSet();
            setB.Add("Goodbye");
            setB.Add("So long");
            StringSet setC= new StringSet();
            setC.Add("Hello");
            setC.Add("Good day");
            setC.Add("Goodbye");
            setC.Add("So long");
            Assert.That(() => setA.Union(setB), Is.EquivalentTo(setC));
        }

    }
}