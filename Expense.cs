// See https://aka.ms/new-console-template for more information
class Expense : Transaction
{
    public Expense(string transactionID, DateTime date, decimal amount, string category) : base(transactionID, date, amount, category) { }
}
