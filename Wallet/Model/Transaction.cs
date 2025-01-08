namespace Wallet.Model
{
    public class WalletTransactionViewModel
    {
        public decimal Balance { get; set; } = 2499.73M;
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

        public void AddTransaction(string type, decimal amount)
        {
            if (type == "Deposit")
            {
                Balance += amount;
            }
            else if (type == "Withdraw" && amount <= Balance)
            {
                Balance -= amount;
            }

            Transactions.Add(new Transaction
            {
                Type = type,
                Amount = amount,
                Time = DateTime.Now
            });
        }
    }

    public class Transaction
    {
        public string? Type { get; set; }
        public decimal Amount { get; set; }
        public DateTime Time { get; set; } 
    }
}
