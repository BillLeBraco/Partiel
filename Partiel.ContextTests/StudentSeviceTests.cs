using Microsoft.VisualStudio.TestTools.UnitTesting;
using Partiel.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partiel.Context.Tests
{
    [TestClass()]
    public class StudentSeviceTests
    {
        [TestMethod()]
        public void GetSeriousMemberTest()
        {
            StudentSevice studentSevice = new StudentSevice();
            var actual = studentSevice.GetSeriousMember();
            var expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetStudentsNoDepenseTest()
        {
            StudentSevice studentSevice = new StudentSevice();
            var actual = studentSevice.GetStudentsNoDepense();
            var expected = 1;
            Assert.AreEqual(expected, actual);
        }
    }
}