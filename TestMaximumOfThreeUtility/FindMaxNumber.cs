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

        public float findMax(float numberOne, float numberTwo, float numberThree)
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

        public string findMax (string numberOne, string numberTwo, string numberThree)
        {
            if (String.Compare(numberOne, numberTwo) > 0 && String.Compare(numberOne, numberThree) > 0)
            {
                return numberOne;
            }
            else if (String.Compare(numberTwo, numberOne) > 0 && String.Compare(numberTwo, numberThree) > 0)
            {
                return numberTwo;
            }
            else
                return numberThree;
        }
    }
}