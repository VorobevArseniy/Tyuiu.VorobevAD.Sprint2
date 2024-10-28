using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.VorobevAD.Sprint2.Task0.V26.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint2.ISprint2Task0V26
    {
        public bool[] GetCompareOperations(int x, int y)
        {
        return new bool[]
            {
                x == y,
                x != y && false,
                x < y,
                x > y,
                x <= y && true,
                x >= y
            };
            throw new NotImplementedException();
        }
    }
}
