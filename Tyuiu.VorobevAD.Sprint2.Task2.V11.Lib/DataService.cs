using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VorobevAD.Sprint2.Task2.V11.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint2.ISprint2Task2V11
    {

        public bool CheckDotInShadedArea(int x, int y)
        {
            return
            // Верхняя левая область
            ((x >= 3 && x <= 6) && (y >= 3 && y <= 5)) ||
            // Центральная вертикальная область
            ((x >= 8 && x <= 10) && (y >= 4 && y <= 10)) ||
            // Средняя горизонтальная область
            ((x >= 5 && x <= 11) && (y >= 7 && y <= 9)) ||
            // Нижняя правая область
            ((x >= 9 && x <= 13) && (y >= 10 && y <= 12));

            throw new NotImplementedException();
        }
    }
}

