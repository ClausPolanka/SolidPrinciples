using System;

namespace SolidPrinciples.LSP
{
    public class FinbonacciNumberGeneratorWithHistory : FinbonacciNumberGenerator
    {
        private int lastSequenceLength;

        public virtual int LastSequenceLength
        {
            get { return lastSequenceLength; }
        }

        public override int[] GetSequenceOfLength(int length)
        {
            if (length < 8 || length > 50)
                throw new ArgumentException();

            lastSequenceLength = length;
            return base.GetSequenceOfLength(length);
        }
    }
}