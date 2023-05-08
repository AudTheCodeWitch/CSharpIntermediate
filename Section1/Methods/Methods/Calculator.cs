namespace Methods
{
    public class Calculator
    {
        public int Add(params int[] numbers) // params keyword allows us to pass in a variable number of arguments
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}