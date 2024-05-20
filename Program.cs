FinanceManager financeManager = new FinanceManager();

financeManager.AddTransaction(new Income("I001", new DateTime(2024, 1, 1), 5000, "Salary"));
financeManager.AddTransaction(new Expense("E001", new DateTime(2024, 1, 2), 1500, "Rent"));
financeManager.AddTransaction(new Expense("E002", new DateTime(2024, 1, 3), 300, "Groceries"));

Console.WriteLine("All Transactions:");
financeManager.GenerateReport();

decimal balance = financeManager.CalculateBalance();
Console.WriteLine($"Current Balance: {balance}");

Console.WriteLine("Search transactions by Category 'Rent':");
var searchResults = financeManager.SearchTransactionsByCategory("Rent");
foreach (var t in searchResults)
{
    Console.WriteLine(t.ToString());
}

Console.ReadLine();

