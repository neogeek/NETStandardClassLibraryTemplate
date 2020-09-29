using NETStandardClassLibrary;
using NUnit.Framework;

namespace NETCoreAppClassLibraryTest
{

    public class SampleClassTest
    {

        [Test]
        public void AddNumbersTest()
        {

            Assert.AreEqual(2, SampleClass.AddNumbers(1, 1));

        }

    }

}
