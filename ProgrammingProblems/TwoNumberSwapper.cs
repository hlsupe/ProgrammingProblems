namespace ProgrammingProblems
{
    public interface ITwoNumberSwapper
    {
        void Swap(ref int a, ref int b);
    }

    public class SwapperUsingArithmeticOperation : ITwoNumberSwapper
    {
        public void Swap(ref int a, ref int b)
        {
            a += b;
            b = a - b;
            a = a - b;
        }
    }

    public class SwapperUsingXorOperation : ITwoNumberSwapper
    {
        public void Swap(ref int a, ref int b)
        {
            a ^= b;
            b = a ^ b;
            a = a ^ b;
        }
    }
}