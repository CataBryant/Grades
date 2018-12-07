using System;
using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GradesUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ComputesHighestGrade()
        {
            //Assert.AreEqual(3, 4);
            Gradebook book = new Gradebook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistic result = book.ComputerStatistic();
            Assert.AreEqual(91, result.HighestGrade);
            //Assert.AreEqual(11,result.LowestGrade);
            //Assert.AreEqual(51, result.AvgGrade);
        }
        [TestMethod]
        public void ComputesLowestrade()
        {
            //Assert.AreEqual(3, 4);
            Gradebook book = new Gradebook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistic result = book.ComputerStatistic();
            //Assert.AreEqual(90, result.HighestGrade);
            Assert.AreEqual(75,result.LowestGrade);
            //Assert.AreEqual(51, result.AvgGrade);
        }
        [TestMethod]
        public void ComputesAvgGrade()
        {
            //Assert.AreEqual(3, 4);
            Gradebook book = new Gradebook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistic result = book.ComputerStatistic();
            //Assert.AreEqual(90, result.HighestGrade);
            //Assert.AreEqual(10, result.LowestGrade);
            Assert.AreEqual(85.16666, result.AvgGrade,0.0001);
            
        }
    }
}
