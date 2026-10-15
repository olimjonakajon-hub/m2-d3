// public class BankAccount
// {
//     private int accountId;
//     private decimal balance;
//     public string OwnerName;
//     private bool isFrozen;

//     public BankAccount(int accountId, decimal balance, string ownerName)
//     {
//         this.accountId = accountId;
//         this.balance = balance;
//         OwnerName = ownerName;
//         isFrozen = false;
//     }

//     public void Deposit(decimal amount)
//     {
//         if (isFrozen)
//         {
//             Console.WriteLine("Account is frozen!");
//         }
//         else if (amount <= 0)
//         {
//             Console.WriteLine("Amount must be positive!");
//         }
//         else
//         {
//             balance += amount;
//             Console.WriteLine("Money deposited!");
//         }
//     }

//     public void Withdraw(decimal amount)
//     {
//         if (isFrozen)
//         {
//             Console.WriteLine("Account is frozen!");
//         }
//         else if (amount <= 0)
//         {
//             Console.WriteLine("Amount must be positive!");
//         }
//         else if (amount > balance)
//         {
//             Console.WriteLine("Not enough money!");
//         }
//         else
//         {
//             balance -= amount;
//             Console.WriteLine("Money withdrawn!");
//         }
//     }

//     public void FreezeAccount()
//     {
//         isFrozen = true;
//         Console.WriteLine("Account frozen!");
//     }

//     public void UnfreezeAccount()
//     {
//         isFrozen = false;
//         Console.WriteLine("Account unfrozen!");
//     }

//     public void ShowInfo()
//     {
//         Console.WriteLine("ID: " + accountId);
//         Console.WriteLine("Owner: " + OwnerName);
//         Console.WriteLine("Balance: " + balance);
//         Console.WriteLine("Frozen: " + isFrozen);
//     }
// }