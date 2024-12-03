public class Customer
{
    public string UserName { get; private set; }
    public BankAccount Account { get; private set; }

    public Customer(string userName, BankAccount account)
    {
        UserName = userName;
        Account = account;
    }
}