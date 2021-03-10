namespace src.State
{
    public class Finish : IStateOfBudget
    {
        public void ApplyDiscount(Budget budget)
        {
            throw new System.Exception("Finish budget not receive discount");
        }

        public void Approve(Budget budget)
        {            
            throw new System.Exception("Transaction invalid");
        }

        public void Disapprove(Budget budget)
        {
            throw new System.Exception("Transaction invalid");
        }

        void IStateOfBudget.Finish(Budget budget)
        {
            throw new System.Exception("Transaction invalid");
        }
    }
}