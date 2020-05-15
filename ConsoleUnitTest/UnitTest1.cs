using CSharp_Tutorials.Exercises;
using NUnit.Framework;

namespace ConsoleUnitTest
{
    [TestFixture]
    public class CodeExecisesTest
    {
        [Test]
        public void NewString_ShouldChangeStrings()
        {
            //Arrange
            var set = "e3resourcw";

            //Act
            var expected = CodeExecises.NewString("w3resource");

            //Assert
            Assert.AreEqual(expected,set);
        }

        [Test]
        public void OneCharacterFromFirstToLast_ShouldChange()
        {
            var set = "TThe quick brown fox jumps over the lazy dog.T";

            var expected = CodeExecises.OneCharacterFromFirstToLast("The quick brown fox " +
                                                                    "jumps over the lazy dog.");
            Assert.AreEqual(set, expected);
        }
    }
}