using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid_Danilchenko()
        {
            Console.WriteLine("Running test: Add_Valid_Danilchenko");
            Assert.AreEqual(3, Program.Add("1", "2"));  // This will pass
            Assert.AreEqual(5, Program.Add("3", "2"));  // This will pass
            Assert.AreEqual(10, Program.Add("5", "7")); // This will fail intentionally (correct value is 12)
        }

        [Test]
        public void Add_Invalid_Danilchenko()
        {    
            Console.WriteLine("Running test: Add_Invalid_Danilchenko");
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null_Danilchenko()
        {    
            Console.WriteLine("Running test: Add_Null_Danilchenko");
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
    }
}

