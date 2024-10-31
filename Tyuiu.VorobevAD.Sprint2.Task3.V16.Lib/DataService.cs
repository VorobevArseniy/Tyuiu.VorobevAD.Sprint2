using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VorobevAD.Sprint2.Task3.V16.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint2.ISprint2Task3V16
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 1)
            {
                y = x + Math.Pow((x + 1) / (x - 1), 3);
            }
            else if (x == 0)
            {
                y = 2 * Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10;
            }
            else if (20 < x && x < 2)
            {
                y = 5 * Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12;
            }
            else if (-20 < x && x < 2)
            {
                y = Math.Pow(1 + 1 / x, 7);
            }
            else if (x <= -20)
            {
                y = x + 10 * (x - 1 / x);
            }

            return Math.Round(y, 3);
            throw new NotImplementedException();
        }
    }
}
