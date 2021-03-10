namespace src.State
{
    public class Budget
    {
        public Budget(double value)
        {
            Value = value;
            State = new InAnalyse();
        }
        public IStateOfBudget State { get; set; }
        public double Value { get; set; }

        public void ApplyDiscount() => this.State.ApplyDiscount(this);
        public void Approve() => this.State.Approve(this);
        public void Disapprove() => this.State.Disapprove(this);
        public void Finish() => this.State.Finish(this);
    }
}