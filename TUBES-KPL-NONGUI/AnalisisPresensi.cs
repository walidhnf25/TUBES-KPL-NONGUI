using System;
using System.Collections.Generic;
using System.Linq;

public class AnalisisPresensi
{
    private List<bool> attendanceData;

    private enum States
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
        States currentState = States.Initial;
        int classCount = attendanceData.Count();
        int startIdx = Math.Max(0, classCount - 3); // index 3 terakhir class
        int presentCountLastThree = attendanceData.GetRange(startIdx, classCount - startIdx).Count(isPresent => isPresent);

        // check mahasiswa isImproving
        if (presentCountLastThree < 3)
        {
            return false;
        }

        for (int i = 1; i < classCount; i++)
        {
            bool isPresent = attendanceData[i];
            switch (currentState)
            {
                case States.Initial:
                    if (isPresent)
                    {
                        currentState = States.Improving;
                    }
                    else
                    {
                        currentState = States.NotImproving;
                    }
                    break;
                case States.Improving:
                    if (!isPresent)
                    {
                        currentState = States.NotImproving;
                    }
                    break;
                case States.NotImproving:
                    if (isPresent)
                    {
                        return true;
                    }
                    break;
            }
        }

        return currentState == States.Improving;
    }
}
