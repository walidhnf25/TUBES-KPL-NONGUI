using NUnit.Framework;
using System;
using System.Collections.Generic;
using TUBES_KPL_NONGUI;

namespace UnitTest_Raffa
{
    [TestFixture]
    public class SystemNotifikasiTests
    {
        private SystemNotifikasi systemNotifikasi;

        [SetUp]
        public void Setup()
        {
            systemNotifikasi = new SystemNotifikasi();
        }

        [Test]
        public void MarkAttendance_ShouldUpdateAttendanceData()
        {
            // Arrange
            string studentId = "A001";
            bool isPresent = true;

            // Act
            systemNotifikasi.MarkAttendance(studentId, isPresent);

            // Assert
            Assert.IsTrue(systemNotifikasi.GetAttendanceData()[studentId] == isPresent);
        }

        [Test]
        public void AlertAbsentStudents_ShouldNotifyAbsentStudents()
        {
            // Arrange
            string studentId1 = "A001";
            string studentId2 = "A002";
            string studentId3 = "A003";

            systemNotifikasi.MarkAttendance(studentId1, true);
            systemNotifikasi.MarkAttendance(studentId2, false);
            systemNotifikasi.MarkAttendance(studentId3, false);

            // Act
            systemNotifikasi.AlertAbsentStudents();

            // Assert - check the output manually
        }
    }
}
