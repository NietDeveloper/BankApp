namespace BankApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.OpenAccount("Nietbay","1234567",150000);
            bank.OpenAccount("Artur","1234569", 200000 );
            bank.OpenAccount("Alpamis","1234568",250000);
            bank.Transfer("1234569","1234567",50000);
            
        }
    }
}