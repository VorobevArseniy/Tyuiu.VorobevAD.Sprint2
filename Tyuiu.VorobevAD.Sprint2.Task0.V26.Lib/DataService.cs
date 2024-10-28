using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.VorobevAD.Sprint2.Task0.V26.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint2.ISprint2Task0V26
    {
        public bool[] GetCompareOperations(int x, int y)
        {
        return new bool[]
            {
            x == y,              // 1. False
            !(x != y),           // 2. False
            !(x < y),            // 3. False
            x > y,               // 4. True
            !(x <= y),           // 5. True
            x >= y               // 6. True
            };
            throw new NotImplementedException();
        }
    }
}
