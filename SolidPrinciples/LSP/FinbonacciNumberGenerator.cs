namespace SolidPrinciples.LSP
{
    public class FinbonacciNumberGenerator
    {
        public virtual int GetNumberAt(int positionInSequence)
        {
            if (positionInSequence < 2)
                return positionInSequence;

            return GetNumberAt(positionInSequence - 1) + GetNumberAt(positionInSequence - 2);
        }

        public virtual int[] GetSequenceOfLength(int length)
        {
            var sequence = new int[length];

            for (int i = 0; i < length; i++)
                sequence[i] = GetNumberAt(i);

            return sequence;
        }
    }
}