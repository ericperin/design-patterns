namespace src.State
{
    public class Disapprove : IStateOfBudget
    {
        public void ApplyDiscount(Budget budget)
        {
            throw new System.Exception("Disapproved budget not receive discount");
        }

        public void Approve(Budget budget)
        {
            throw new System.Exception("Transaction invalid");
        }

        public void Finish(Budget budget)
        {
            budget.State = new Finish();
        }

        void IStateOfBudget.Disapprove(Budget budget)
        {
            throw new System.Exception("Transaction invalid");
        }
    }
}