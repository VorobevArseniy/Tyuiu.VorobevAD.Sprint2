﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VorobevAD.Sprint2.Task4.V1.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint2.ISprint2Task4V1
    {
        public double Calculate(double x, double y)
        {
            double z = (x < y) ? (x + 3) / y : (x + 1) / (x - 2);
            return Math.Round(z, 3);
            throw new NotImplementedException();
        }
    }
}
