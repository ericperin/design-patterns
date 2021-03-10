using System;
using src.State;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = new Budget(500);
            Console.WriteLine(budget.Value);

            budget.ApplyDiscount();
            Console.WriteLine(budget.Value);

            budget.Approve();

            budget.ApplyDiscount();
            Console.WriteLine(budget.Value);

            budget.Finish();
        }
    }
}
