public class BankAccount
{
    public string? AccountNumber { get; private set; }
    public decimal Balance { get; private set; }

    public BankAccount(string accountNumber, decimal initialBalance = 0)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if(amount > 0)
        {
            Balance += amount;
            System.Console.WriteLine($"{amount} so\'m depozit qilindi. Hozida balansingiz {Balance} so\'m");
        }
        else
        {
            System.Console.WriteLine("Deposit summasi musbat bolishi kerak!");
        }
    }

    public void Withdrow(decimal amount)
    {
        if(amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            System.Console.WriteLine($"{amount} so\'m pul yechildi. Hozirda balansingiz {Balance} so\'m");
        }
        else
        {
            System.Console.WriteLine("Noto\'g\'ri mablag\' kiritildi!!!");
        }
    }

    public decimal GetBalance()
    {
        return Balance;
    }
}