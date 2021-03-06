﻿using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace FindMaximumUtility
{
    public class FindMaxNumber <E>
    {
        public E numberOne;
        public E numberTwo;
        public E numberThree;
        public E[] extraValues;
        public E maxElement;

        public FindMaxNumber()
        {
        }

        public FindMaxNumber(E numberOne, E numberTwo, E numberThree, [Optional] E[] extraValues)
        {
            this.numberOne = numberOne;
            this.numberTwo = numberTwo;
            this.numberThree = numberThree;
            this.extraValues = extraValues;

            //findMax();
        }

        public E findMax(E numberOne, E numberTwo, E numberThree, params object[] extraValues)
        {
            System.Collections.Generic.SortedSet<E> set = new System.Collections.Generic.SortedSet<E>();
            set.Add(numberOne);
            set.Add(numberTwo);
            set.Add(numberThree);
            //E[] array = { this.numberOne, this.numberTwo, this.numberThree };
            //int index = 2;
            if (extraValues.Length != 0)
            {
                foreach (E value in extraValues)
                {
                    set.Add(value);
                }
            }

            foreach (E value in set)
            {
                this.maxElement = value;
            }
            printmax(this.maxElement);

            return this.maxElement;

            
        }

        public void printmax(E maxElement)
        {
            Console.WriteLine(maxElement);
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