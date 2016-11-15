using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PKW.ControlCenter.Data;

namespace PKW.ControlCenter.UnitTests
{
    /// <summary>
    /// Summary description for CandidatesModelTests
    /// </summary>
    [TestClass]
    public class CandidatesModelTests
    {
        public CandidatesModelTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Test1()
        {
            CandidatesModel candidate = new CandidatesModel();
            candidate.Code = 77020203551;//PESEL OK            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test2()
        {
            CandidatesModel candidate = new CandidatesModel();
            candidate.Code = 77020203557;//wrong checksum            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test3()
        {
            CandidatesModel candidate = new CandidatesModel();
            candidate.Code = 9999999999;//too short            
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test4()
        {
            CandidatesModel candidate = new CandidatesModel();
            candidate.Code = 100000000000;//too long            
        }
    }
}
