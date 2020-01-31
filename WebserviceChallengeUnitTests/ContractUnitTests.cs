using NUnit.Framework;
using SoapServer;
using SoapServer.Exeptions;

namespace WebserviceChallengeUnitTests
{
    public class Tests
    {
        private Contract _contract;

        [SetUp]
        public void Setup()
        {
             _contract = new Contract();

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Should_Be_Return_1_When_Param_Equal_1()
        {
            Assert.AreEqual(_contract.Fibonacci(1), 1);
        }

        [Test]
        public void Should_Be_Return_Exception_1_When_Param_Negative()
        {
            Assert.Throws<InvalidFibonacciNumberException>(() => _contract.Fibonacci(-1));
        }

        [Test]
        public void Should_Be_Return_Exception_1_When_Param_Superior_To_999()
        {
            Assert.Throws<InvalidFibonacciNumberException>(() => _contract.Fibonacci(1000));
        }

        [Test]
        public void Should_Be_Return_1_When_Param_EqualTo_2()
        {
            Assert.AreEqual(_contract.Fibonacci(2), 1);
        }

        [Test]
        public void Should_Be_Return_1_When_Param_EqualTo_6()
        {
            Assert.AreEqual(_contract.Fibonacci(6), 8);
        }


        [Test]
        public void Should_Be_Return_1_When_Param_EqualTo_11()
        {
            Assert.AreEqual(_contract.Fibonacci(11), 89);
        }

        [Test]
        public void Should_Be_Return_Json_Format_Exemple1()
        {
            string xml = "<foo>bar</foo>";
            Assert.AreEqual(_contract.XmlToJson(xml), "{\"foo\":\"bar\"}");
        }

        [Test]
        public void Should_Be_Return_Json_Format_Exemple2()
        {
            string xml = "<TRANS><HPAY><ID>103</ID><STATUS>3</STATUS><EXTRA><IS3DS>0</IS3DS><AUTH>031183</AUTH></EXTRA><INT_MSG/><MLABEL>501767XXXXXX6700</MLABEL><MTOKEN>project01</MTOKEN></HPAY></TRANS>";
            string jsonResult = "{\"TRANS\":{\"HPAY\":{\"ID\":\"103\",\"STATUS\":\"3\",\"EXTRA\":{\"IS3DS\":\"0\",\"AUTH\":\"031183\"},\"INT_MSG\":null,\"MLABEL\":\"501767XXXXXX6700\",\"MTOKEN\":\"project01\"}}}";
            Assert.AreEqual(_contract.XmlToJson(xml), jsonResult);
        }


        [Test]
        public void Should_Return_Exception_Bad_xml_Format()
        {
            string badXmlFormat = "<foo>hello</bar>";
            Assert.AreEqual(_contract.XmlToJson(badXmlFormat), "Bad Xml format");
        }


    }
}