// See https://aka.ms/new-console-template for more information
class FinanceManager
{
    private List<Transaction> Transactions;

    public FinanceManager()
    {
        Transactions = new List<Transaction>();
    }

    public void AddTransaction(Transaction transaction)
    {
        Transactions.Add(transaction);
    }

    public decimal CalculateBalance()
    {
        decimal balance = 0;

        foreach (var t in Transactions)
        {
            if (t is Income)
            {
                balance += t.Amount;
            }
            else if (t is Expense)
            {
                balance -= t.Amount;
            }
        }
        return balance;
    }

    public void GenerateReport()
    {
        foreach (var t in Transactions)
        {
            Console.WriteLine(t.ToString());
        }
    }

    public List<Transaction> SearchTransactionsByCategory(string category)
    {
        List<Transaction> results = new List<Transaction>();

        foreach (var t in Transactions)
        {
            if (t.Category == category)
            {
                results.Add(t);
            }
        }
        return results;
    }
}