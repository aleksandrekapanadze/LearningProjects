namespace DemoCode
{
    public class DecimalCalculator
    {
        public decimal Value { get; private set; }

        public void Substract(decimal number)
        {
            Value -= number;
        }

        public void Add(decimal number)
        {
            Value += number;
        }
    }
}
