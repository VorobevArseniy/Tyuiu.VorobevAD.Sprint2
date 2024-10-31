using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VorobevAD.Sprint2.Task1.V27.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint2.ISprint2Task1V27
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] results =
            [
                (a > b) & (c == d),            // False
                (a < b) | (c != d),            // False
                (a >= c) ^ (b < d),            // True
                !(a == 654) && (d > b),        // False
                (b <= d) || (c < a),           // True
                (a != b) && (c > d),           // False
            ];
            return results;
            throw new NotImplementedException();
        }
    }
}
