namespace src.State
{
    public class InAnalyse : IStateOfBudget
    {
        public void ApplyDiscount(Budget budget)
        {
            budget.Value = budget.Value - (budget.Value * 0.05);
        }
        public void Approve(Budget budget)
        {
            budget.State = new Approve();
        }

        public void Disapprove(Budget budget)
        {
            budget.State = new Disapprove();
        }

        public void Finish(Budget budget)
        {
            throw new System.Exception("Transaction invalid");
        }

    }
}