using ConverterLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniterTestConverter
{
    [TestClass]
    public class UnitTest1
    {
        #region RomanConverterTests

        [TestMethod]
        public void Test0()
        {
            var convertisseur = new RomanConverter();

            var converti = convertisseur.Convert(0);

            Assert.AreEqual("0", converti);
        }

        [TestMethod]
        public void TestI()
        {
            var convertisseur = new RomanConverter();

            var converti = convertisseur.Convert(1);

            Assert.AreEqual("I", converti);
        }

        [TestMethod]
        public void TestV()
        {
            var convertisseur = new RomanConverter();

            var converti = convertisseur.Convert(5);

            Assert.AreEqual("V", converti);
        }

        [TestMethod]
        public void TestX()
        {
            var convertisseur = new RomanConverter();

            var converti = convertisseur.Convert(10);

            Assert.AreEqual("X", converti);
        }

        #endregion

        #region ASCIIConverterTests

        [TestMethod]
        public void Test48()
        {
            var convertisseur = new ASCIIConverter();

            var converti = convertisseur.Convert(48);

            Assert.AreEqual("0", converti);
        }

        [TestMethod]
        public void Test65()
        {
            var convertisseur = new ASCIIConverter();

            var converti = convertisseur.Convert(65);

            Assert.AreEqual("A", converti);
        }

        [TestMethod]
        public void Test97()
        {
            var convertisseur = new ASCIIConverter();

            var converti = convertisseur.Convert(97);

            Assert.AreEqual("a", converti);
        }

        #endregion
    }
}
