// See https://aka.ms/new-console-template for more information
class Transaction
{
    public string TransactionID { get; private set; }
    public DateTime Date { get; private set; }
    public decimal Amount { get; private set; }
    public string Category { get; private set; }

    public Transaction(string transactionID, DateTime date, decimal amount, string category)
    {
        TransactionID = transactionID;
        Date = date;
        Amount = amount;
        Category = category;
    }

    public override string ToString()
    {
        return $"TransactionID: {TransactionID}, Date: {Date}, Amount: {Amount}, Category: {Category}";
    }
}
