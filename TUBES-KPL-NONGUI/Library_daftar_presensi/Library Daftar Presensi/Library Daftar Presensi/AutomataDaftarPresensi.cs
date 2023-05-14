using System;
using AbsensiLibrary;

public class AttendanceAutomaton
{
    private enum State
    {
        Idle,
        Present,
        Late,
        Absent
    }

    private State currentState;
    private Absensi absensi;

    public AttendanceAutomaton()
    {
        currentState = State.Idle;
        absensi = new Absensi();
    }

    public void ProcessAttendance(bool isPresent, bool isLate, string studentName)
    {
        switch (currentState)
        {
            case State.Idle:
                if (isPresent)
                {
                    currentState = State.Present;
                    absensi.Absen(studentName);
                }
                else
                {
                    currentState = State.Absent;
                    Console.WriteLine("Status: Anda absen.");
                }
                break;
            case State.Present:
                if (!isPresent)
                {
                    currentState = State.Absent;
                    Console.WriteLine("Status: Anda absen.");
                }
                else if (isLate)
                {
                    currentState = State.Late;
                    Console.WriteLine("Status: Anda terlambat.");
                }
                break;
            case State.Late:
                if (!isPresent)
                {
                    currentState = State.Absent;
                    Console.WriteLine("Status: Anda absen.");
                }
                else if (!isLate)
                {
                    currentState = State.Present;
                    absensi.Absen(studentName);
                }
                break;
            case State.Absent:
                if (isPresent)
                {
                    currentState = State.Present;
                    absensi.Absen(studentName);
                }
                else
                {
                    Console.WriteLine("Status: Anda masih absen.");
                }
                break;
        }
    }

    public void PrintAttendanceList()
    {
        absensi.DaftarAbsensi();
    }
}


