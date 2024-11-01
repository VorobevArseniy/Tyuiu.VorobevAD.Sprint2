using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VorobevAD.Sprint2.Task6.V8.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint2.ISprint2Task6V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            if (n == 1)
            {
                m = m == 1 ? 12 : m - 1;
                int daysInPrevMonth = m switch
                {
                    1 => 31,
                    2 => 28,
                    3 => 31,
                    4 => 30,
                    5 => 31,
                    6 => 30,
                    7 => 31,
                    8 => 31,
                    9 => 30,
                    10 => 31,
                    11 => 30,
                    12 => 31,
                    _ => throw new ArgumentException("Недопустимый номер месяца")
                };
                return $"{m:D2}.{daysInPrevMonth:D2}";
            }
            else
            {
                return $"{m - 1:D2}.{n:D2}";
            }
        }
    }
}
