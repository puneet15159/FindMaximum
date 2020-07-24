using System;
using System.Linq;

namespace FindMaximumUtility
{
    public class FindMaxNumber <E>
    {
        public E findMax(E numberOne, E numberTwo, E numberThree)
        {

            E[] array = { numberOne, numberTwo, numberThree };
            Array.Sort(array);

            return array[array.Length-1];
        }

       /* public float findMax(float numberOne, float numberTwo, float numberThree)
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
        }*/
    }
}