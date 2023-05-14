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
        for (int i = 1; i < attendanceData.Count; i++)
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
                        return false;
                    }
                    break;
            }
        }
        return currentState == States.Improving;
    }
}
