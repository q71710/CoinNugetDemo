namespace CoinNugetDemo.Contracts
{
    public interface ICalculator
    {
        public int Add(int a, int b);
        public int Subtract(int a, int b);
        public int Multiply(int a, int b);
        public int Divide(int a, int b);
        
        public int Divide2(int a, int b);
    }
}