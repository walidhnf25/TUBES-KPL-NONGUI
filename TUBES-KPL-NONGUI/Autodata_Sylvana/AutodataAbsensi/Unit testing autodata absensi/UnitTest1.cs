using NUnit.Framework;
using System.Collections.Generic;

public class AttendanceList
{
    private List<string> presentStudents;

    public AttendanceList()
    {
        presentStudents = new List<string>();
    }

    public void MarkPresent(string studentName)
    {
        presentStudents.Add(studentName);
    }

    public bool IsPresent(string studentName)
    {
        return presentStudents.Contains(studentName);
    }

    public int CountPresentStudents()
    {
        return presentStudents.Count;
    }
}

[TestFixture]
public class AttendanceListTests
{
    [Test]
    public void MarkPresent_ShouldAddStudentToPresentList()
    {
        // Arrange
        AttendanceList attendanceList = new AttendanceList();
        string studentName = "John Doe";

        // Act
        attendanceList.MarkPresent(studentName);

        // Assert
        Assert.IsTrue(attendanceList.IsPresent(studentName));
    }

    [Test]
    public void IsPresent_ShouldReturnFalse_WhenStudentIsNotPresent()
    {
        // Arrange
        AttendanceList attendanceList = new AttendanceList();
        string studentName = "John Doe";

        // Act
        bool isPresent = attendanceList.IsPresent(studentName);

        // Assert
        Assert.IsFalse(isPresent);
    }

    [Test]
    public void CountPresentStudents_ShouldReturnCorrectCount()
    {
        // Arrange
        AttendanceList attendanceList = new AttendanceList();
        attendanceList.MarkPresent("John Doe");
        attendanceList.MarkPresent("Jane Smith");

        // Act
        int count = attendanceList.CountPresentStudents();

        // Assert
        Assert.AreEqual(2, count);
    }
}
