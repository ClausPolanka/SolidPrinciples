using System;

namespace SolidPrinciples.OCP
{
    public sealed class FibonacciNumberGenerator
    {
        public int GetNumberAt(int positionInSequence)
        {
            if (positionInSequence < 2)
                return positionInSequence;

            return GetNumberAt(positionInSequence - 1) + GetNumberAt(positionInSequence - 2);
        }

        public int[] GetSequenceOfLength(int length)
        {
            if (length < 8 || length > 50)
                throw new ArgumentException();

            var sequence = new int[length];
            
            for (int i = 0; i < length; i++)
                sequence[i] = GetNumberAt(i);

            return sequence;
        }
    }
}