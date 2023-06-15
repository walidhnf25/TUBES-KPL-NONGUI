using System;
using System.Collections.Generic;
using System.Linq;

public class AnalisisPresensi
{
    private List<bool> attendanceData;

    private enum AttendanceStates
    {
        Initial,
        Improving,
        NotImproving
    }

    public AnalisisPresensi(List<bool> attendanceData)
    {
        this.attendanceData = attendanceData;
    }

    public double GetAttendancePercentage()
    {
        int presentCount = attendanceData.Count(isPresent => isPresent);
        double percentage = (double)presentCount / attendanceData.Count * 100;
        return percentage;
    }

    public bool IsAttendanceImproving()
    {
        AttendanceStates currentState = AttendanceStates.Initial;
        int classCount = attendanceData.Count;
        int startIdx = Math.Max(0, classCount - 3); // 3 kelas terakhir
        int presentCountLastThree = attendanceData.GetRange(startIdx, classCount - startIdx).Count(isPresent => isPresent);

        // Memeriksa apakah ada peningkatan kehadiran
        if (presentCountLastThree < 3)
        {
            return false;
        }

        for (int i = 1; i < classCount; i++)
        {
            bool isPresent = attendanceData[i];
            switch (currentState)
            {
                case AttendanceStates.Initial:
                    if (isPresent)
                    {
                        currentState = AttendanceStates.Improving;
                    }
                    else
                    {
                        currentState = AttendanceStates.NotImproving;
                    }
                    break;
                case AttendanceStates.Improving:
                    if (!isPresent)
                    {
                        currentState = AttendanceStates.NotImproving;
                    }
                    break;
                case AttendanceStates.NotImproving:
                    if (isPresent)
                    {
                        return true;
                    }
                    break;
            }
        }

        return currentState == AttendanceStates.Improving;
    }
}
