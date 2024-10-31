using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VorobevAD.Sprint2.Task1.V27.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint2.ISprint2Task1V27
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] results = new bool[6];
            results[0] = (a > b) & (c == d);            // False
            results[1] = (a < b) | (c != d);            // False
            results[2] = (a >= c) ^ (b < d);            // True
            results[3] = !(a == 654) && (d > b);        // False
            results[4] = (b <= d) || (c < a);           // True
            results[5] = (a != b) && (c > d);           // False
            return results;
            throw new NotImplementedException();
        }
    }
}
