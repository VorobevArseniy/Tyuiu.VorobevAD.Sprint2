using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VorobevAD.Sprint2.Task6.V8.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint2.ISprint2Task6V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            if (n == 1)
            {
                // Уменьшаем месяц
                m--;

                // Находим количество дней в предыдущем месяце
                int daysInPrevMonth = m switch
                {
                    1 => 31,  // Январь
                    2 => 31,  // Февраль (предыдущий месяц - Январь)
                    3 => 28,  // Март (без учёта високосного года)
                    4 => 31,  // Апрель
                    5 => 30,  // Май
                    6 => 31,  // Июнь
                    7 => 30,  // Июль
                    8 => 31,  // Август
                    9 => 31,  // Сентябрь
                    10 => 30, // Октябрь
                    11 => 31, // Ноябрь
                    12 => 30, // Декабрь
                    _ => throw new ArgumentException("Недопустимый номер месяца")
                };

                return $"{daysInPrevMonth}.{m}";
            }
            else
            {
                // Если n не равен 1, просто уменьшаем день на 1
                return $"{n - 1}.{m}";
            }
        }
    }
}
