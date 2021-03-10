namespace src.State
{
    public class Approve : IStateOfBudget
    {
        public void ApplyDiscount(Budget budget)
        {
            budget.Value -= budget.Value * 0.02;
        }

        public void Disapprove(Budget budget)
        {
            throw new System.Exception("Transaction invalid");
        }

        public void Finish(Budget budget)
        {
            budget.State = new Finish();
        }

        void IStateOfBudget.Approve(Budget budget)
        {
            throw new System.Exception("Transaction invalid");
        }
    }
}