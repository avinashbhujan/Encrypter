using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MessageEncrypter;

namespace MessageEncrypter.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            char expected = 'b';
            char msg = 'a';
            EncryptionHelper th = new EncryptionHelper();
            
            //act
            char actual = th.encryptAlphabet(msg);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string expected = "bcd";
            string msg = "abc";

            EncryptionHelper th = new EncryptionHelper();

            string actual = th.encryptMessage(msg);

            Assert.AreEqual(expected,actual);

        }

        [TestMethod]
        public void TestMethod3()
        {
            string expected = "bcd";
            string msg = "555";

            EncryptionHelper th = new EncryptionHelper();

            string actual = th.encryptMessage(msg);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod4()
        {
            string expected = "aaa";
            string msg = "zzz";

            EncryptionHelper th = new EncryptionHelper();

            string actual = th.encryptMessage(msg);

            Assert.AreEqual(expected, actual);

        }
    }
}
