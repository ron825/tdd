using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pagevalue;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace pagevalue.Tests
{
    [TestClass()]
    public class CollectionSumTests
    {
        [TestMethod()]
        public void SumTest_Group_3()
        {
            //arrange
            var target = new CollectionSum();

            var groupNum = 3;
            var groupColumns = "Cost";
            var expected = "6,15,24,21";

            //act
            var actual = target.Sum(groupNum, groupColumns);

            //assert
            Assert.AreEqual(expected, actual);  
        }

        [TestMethod()]
        public void SumTest_Group_4()
        {
            //arrange
            var target = new CollectionSum();

            var groupNum = 4;
            var groupColumns = "Revenue";
            var expected = "50,66,60";

            //act
            var actual = target.Sum(groupNum, groupColumns);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
