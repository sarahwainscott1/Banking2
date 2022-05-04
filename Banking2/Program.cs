using Banking2;

var acct1 = new Account() {
    AcctName = "Checking"
    };
var acct2 = new Account() {
    AcctName = "Savings"
    };
var acct3 = new Account() {
    AcctName = "House Downpayment"
    };

acct1.Deposit(1500);
acct2.Deposit(4000);
acct3.Deposit(25000);

acct1.GetBalance();
acct2.GetBalance();
acct3.GetBalance();

acct1.Withdraw(500);
acct2.Withdraw(800);

acct2.Transfer(1500, acct3);

Console.WriteLine($"Acct1: {acct1.AcctNbr}. Acct2: {acct2.AcctNbr}. Acct3: {acct3.AcctNbr}");

