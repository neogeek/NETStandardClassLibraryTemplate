using NETStandardClassLibrary;
using NUnit.Framework;

namespace NETCoreAppClassLibraryTest
{

    public class SampleClassTest
    {

        [Test]
        public void AddNumbersTest()
        {

            Assert.That(SampleClass.AddNumbers(1, 1), Is.EqualTo(2));

        }

    }

}
