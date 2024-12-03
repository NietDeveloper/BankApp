public class Bank
{
    private List<Customer> Customers = new List<Customer>();

    public void OpenAccount(string customerName, string accountNumber, decimal initialBalance = 0)
    {
        BankAccount account = new BankAccount(accountNumber, initialBalance);
        Customer customer = new Customer(customerName, account);
        Customers.Add(customer);
        System.Console.WriteLine($"Hisob ochildi Name:{customerName}. Hisob raqami:{accountNumber}");
    }

    public void CloseAccount(string accountNumber)
    {
        var customer = Customers.Find(c => c.Account.AccountNumber == accountNumber);
        if(customer != null)
        {
            Customers.Remove(customer);
            System.Console.WriteLine($" {accountNumber} : shu hisob raqam yopildi. ");
        }
        else
        {
            System.Console.WriteLine("Kiritilgan hisob raqam topilmadi!");
        }
    }

    public void Transfer(string fromAccountNumber, string toAccountNumber, decimal amount)
    {
        var fromCustomer = Customers.Find(s => s.Account.AccountNumber == fromAccountNumber);
        var toCustomer = Customers.Find(s => s.Account.AccountNumber == toAccountNumber);
        if(fromCustomer != null && toCustomer != null && amount > 0 && fromCustomer.Account.GetBalance() > amount)
        {
            fromCustomer.Account.Withdrow(amount);
            toCustomer.Account.Deposit(amount);
            System.Console.WriteLine($"{fromAccountNumber} dan {toAccountNumber} ga {amount} so\'m o\'tkazildi!");
        }
        else
        {
            System.Console.WriteLine("Error P2P! Try it later!");
        } 
    }
}