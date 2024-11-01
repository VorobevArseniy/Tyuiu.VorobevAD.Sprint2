using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VorobevAD.Sprint2.Task7.V10.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint2.ISprint2Task7V10

    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            return y >= x * x - 2 && y <= x && y <= -x;

            throw new NotImplementedException();
        }
    }
}
