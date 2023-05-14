using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_Raffa
{
    internal class AnalisisPresensiTest
    {
        [Test]
        public void GetAttendancePercentage_ShouldReturnCorrectPercentage()
        {
            // Arrange
            var attendanceData = new List<bool> { true, false, true, false, false, true };
            var analisisPresensi = new AnalisisPresensi(attendanceData);
            double expectedPercentage = 50.0;

            // Act
            double actualPercentage = analisisPresensi.GetAttendancePercentage();

            // Assert
            Assert.AreEqual(expectedPercentage, actualPercentage);
        }

        [Test]
        public void IsAttendanceImproving_ShouldReturnTrueIfAttendanceIsImproving()
        {
            // Arrange
            var attendanceData = new List<bool> { true, true, true, true, true, true };
            var analisisPresensi = new AnalisisPresensi(attendanceData);

            // Act
            bool isImproving = analisisPresensi.IsAttendanceImproving();

            // Assert
            Assert.IsTrue(isImproving);
        }

        [Test]
        public void IsAttendanceImproving_ShouldReturnFalseIfAttendanceIsNotImproving()
        {
            // Arrange
            var attendanceData = new List<bool> { true, true, true, false, true, false };
            var analisisPresensi = new AnalisisPresensi(attendanceData);

            // Act
            bool isImproving = analisisPresensi.IsAttendanceImproving();

            // Assert
            Assert.IsFalse(isImproving);
        }
    }
}
