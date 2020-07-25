using System;
using System.Linq;

namespace FindMaximumUtility
{
    public class FindMaxNumber <E>
    {
        public E numberOne;
        public E numberTwo;
        public E numberThree;
        public E maxElement;

        public FindMaxNumber(E numberOne, E numberTwo, E numberThree)
        {
            //E[] array = { numberOne, numberTwo, numberThree };
            this.numberOne = numberOne;
            this.numberTwo = numberTwo;
            this.numberThree = numberThree;

            findMax();

        }

        public void findMax()
        {

            E[] array = { this.numberOne, this.numberTwo, this.numberThree };
            Array.Sort(array);

            this.maxElement = array[array.Length-1];
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