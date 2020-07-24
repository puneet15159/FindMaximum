using System;

namespace FindMaximumUtility
{
    public class FindMaxNumber
    {
        public int findMax(int numberOne, int numberTwo, int numberThree)
        {
            if (numberOne > numberTwo && numberOne > numberThree)
            {
                return numberOne;
            }
            else if (numberTwo > numberOne && numberTwo > numberThree)
            {
                return numberTwo;
            }
            else
                return numberThree;
        }
    }
}