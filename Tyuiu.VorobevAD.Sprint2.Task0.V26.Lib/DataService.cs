using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.VorobevAD.Sprint2.Task0.V26.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint2.ISprint2Task0V26
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] results =
            [
                x == y,       // False
                x < y,        // False
                x <= y,       // False
                x > y,        // True
                x >= y,       // True
                x != y,       // True
            ];
            return (results);

            throw new NotImplementedException();
        }
    }
}
