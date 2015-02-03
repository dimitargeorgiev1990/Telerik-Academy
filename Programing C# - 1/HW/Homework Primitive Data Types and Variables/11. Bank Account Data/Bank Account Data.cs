using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Stefan ";
        string middleName = "Ivanov ";
        string lastName = "Nikolov";
        decimal balance = 8123456789123.25M;
        string bankName = "CCB";
        string iban = "BG80 BNBG 9661 1020 3456 78";
        long card1 = 5555555555555555L;
        long card2 = 6666666666666666L;
        long card3 = 7777777777777777L;

        Console.WriteLine("Name: " + firstName + middleName + lastName);
        Console.WriteLine("Balance: " + balance);
        Console.WriteLine("Bank name: " + bankName);
        Console.WriteLine("IBAN: " + iban);
        Console.WriteLine("Credit card № 1: " + card1 + "\nCredit card № 2: " + card2 + "\nCredit card № 3: " + card3);
    }
}
