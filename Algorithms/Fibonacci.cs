using Algorithms.Abstract;
using System;

namespace Algorithms
{
    public class Fibonacci : IFibonacci
    {
        public long GetFibonacciNumber(long inputNumber)
        {
            inputNumber = inputNumber < 0 ? inputNumber *= -1 : inputNumber;

            long previousNumber = 0;
            long currentNumber = 1;
            long placeHolderNumber = 0;

            try
            {
                for (long i = 1; i < inputNumber; i++)
                {
                    placeHolderNumber = checked(previousNumber + currentNumber);
                    previousNumber = currentNumber;
                    currentNumber = placeHolderNumber;
                }
            }
            catch (OverflowException ex)
            {
                throw new OverflowException($"Could not perform the fibonacci process for input value {inputNumber}. {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
            return placeHolderNumber;
        }


    }
}
