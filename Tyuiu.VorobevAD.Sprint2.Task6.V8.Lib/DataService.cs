using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VorobevAD.Sprint2.Task6.V8.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint2.ISprint2Task6V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            int daysInPreviousMonth = m switch
            {
                1 => 31,   // Январь -> Декабрь (31 день)
                2 => 31,   // Февраль -> Январь
                3 => 28,   // Март -> Февраль (28 дней в невисокосный год)
                4 => 31,   // Апрель -> Март
                5 => 30,   // Май -> Апрель
                6 => 31,   // Июнь -> Май
                7 => 30,   // Июль -> Июнь
                8 => 31,   // Август -> Июль
                9 => 31,   // Сентябрь -> Август
                10 => 30,  // Октябрь -> Сентябрь
                11 => 31,  // Ноябрь -> Октябрь
                12 => 30,  // Декабрь -> Ноябрь
                _ => throw new ArgumentOutOfRangeException("Некорректный номер месяца")
            };

            // Если n равен 1, то переходим на предыдущий месяц
            if (n == 1)
            {
                int previousMonth = (m == 1) ? 12 : m - 1;
                return $"{previousMonth}";
            }
            else
            {
                // В противном случае просто уменьшаем день на 1
                return $"{n - 1}";
            }
        }
    }
}
