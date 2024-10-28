using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.VorobevAD.Sprint2.Task0.V26.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint2.ISprint2Task0V26
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] results = new bool[6];

            results[0] = x == y;       // False
            results[1] = x < y;        // False
            results[2] = x <= y;       // False
            results[3] = x > y;        // True
            results[4] = x >= y;       // True
            results[5] = x != y;       // True

            return (results);

            throw new NotImplementedException();
        }
    }
}
