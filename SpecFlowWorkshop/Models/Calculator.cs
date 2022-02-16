namespace SpecFlowWorkshop.Models
{
    public class Calculator
    {
        public int CurrentTotal { get; set; }

        public Calculator()
        {
            CurrentTotal = 0;
        }

        public void SetTotalTo(int NewTotal)
        {
            CurrentTotal = NewTotal;
        }

        public void Add(int NumberToAdd)
        {
            CurrentTotal += NumberToAdd;
        }

        public void Subtract(int NumberToSubtract)
        {
            CurrentTotal -= NumberToSubtract;
        }

        public void Multiply(int NumberToMultiplyWith)
        {
            CurrentTotal *= NumberToMultiplyWith;
        }
    }
}
