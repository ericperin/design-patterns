namespace src.State
{
    public interface IStateOfBudget
    {
        void ApplyDiscount(Budget budget);
        void Approve(Budget budget);
        void Disapprove(Budget budget);
        void Finish(Budget budget);
    }
}