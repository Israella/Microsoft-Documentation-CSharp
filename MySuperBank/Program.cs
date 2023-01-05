using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // PROPRIETARIO DA CONTA, VALOR INICIAL E COMO VAI FUNCIONAR O BALANÇO DA CONTA.
            var account = new BankAccount("Israella", 2000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            account.MakeWithdrawal(120, DateTime.Now, "Presente");
            Console.WriteLine(account.Balance);
            account.MakeWithdrawal(500, DateTime.Now, "Pagar conta");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Pix");
            Console.WriteLine(account.Balance);

            // Test that the initial balances must be positive.
            BankAccount invalidAccount;
            try
            {
                invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
                return;
            }

        }
    }
}