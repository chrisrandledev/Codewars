using System;
using System.Collections;
using System.Diagnostics;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace ValidBraces
{
    [TestFixture]
    public class BraceTests
    {
        [Test]
        public void Test1()
        {
            ClassicAssert.AreEqual(true, Brace.ValidBraces("()"));
        }

        [Test]
        public void Test2()
        {

            ClassicAssert.AreEqual(false, Brace.ValidBraces("[(])"));
        }  

        [Test]
        public void Test3()
        {

            ClassicAssert.AreEqual(true, Brace.ValidBraces("(){}[]"));
        }  

        [Test]
        public void Test4()
        {

            ClassicAssert.AreEqual(true, Brace.ValidBraces("([{}])"));
        }   

        [Test]
        public void Test5()
        {
            ClassicAssert.AreEqual(false, Brace.ValidBraces("(}"));
        }  

        [Test]
        public void Test6()
        {
            ClassicAssert.AreEqual(false, Brace.ValidBraces("[(])"));
        }   

        [Test]
        public void Test7()
        {
            ClassicAssert.AreEqual(false, Brace.ValidBraces("[({})](]"));
        }
    }

}