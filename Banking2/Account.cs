using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking2 {
    internal class Account {
        //properties
        private static int NextId = 1;
        public int AcctNbr { get; private set; } = 0;
        public string AcctName { get; set; } = string.Empty;
        public decimal Balance  { get; private set; } = 0;

        //methods
        public bool Deposit(decimal Amount) {
            if (Amount > 0) {
                Balance += Amount;
                Console.WriteLine($"{AcctName}: {Amount:c} added to balance. New balance is {Balance:c}. ");
                return true;
                }
            Console.WriteLine($"Deposit must be greater than 0.");
            return false;
            }
        public bool Withdraw(decimal Amount) {
            if (Amount < 0) {
                Console.WriteLine($"Withdraw must be greater than 0");
                return false;
                }
            if (Amount > Balance) {
                Console.WriteLine($"Insufficient funds in {AcctName}.");
                return false;
                }
            Balance -= Amount;
            Console.WriteLine($"{AcctName}: {Amount:c} withdrawn. New balance is {Balance:c}.");
            return true;
            }
        public bool Transfer(decimal Amount, Account DAcct) {
                if (Withdraw(Amount)) {
                 
                    DAcct.Deposit(Amount);
                    Console.WriteLine($"Transfered {Amount:c} from {this.AcctName} to {DAcct.AcctName}. New balance of {DAcct.AcctName} is {DAcct.Balance:c}");
                    return true;
                    }
                Console.WriteLine($"Insufficient funds to transfer from {this.AcctName}.");
                return false;
                }
        public decimal GetBalance() {
            Console.WriteLine($"{AcctName} Balance: {Balance:c}");
            return Balance;
            }

        public Account() {
            AcctNbr = NextId;
            NextId++;
            }
           
        }
    }
