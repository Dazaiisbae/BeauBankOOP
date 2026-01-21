using System;
using ClassLibrary;

Console.WriteLine("console Testing app for Beau Bank Library");

// Base Account Test

Account testacct = new Account();
testacct.IsActive = true; //
Console.WriteLine("base account created");
Console.WriteLine($"Account Number: {testacct.AccountNumber}");
Console.WriteLine($"Owner Name: {testacct.OwnerName}");
Console.WriteLine($"Balance: {testacct.Balance}");
Console.WriteLine($"Is Active: {testacct.IsActive}");
Console.WriteLine($"Date Opened: {testacct.DateOpened}");

// Base account deposit test
testacct.deposit(500);
Console.WriteLine($"After depositing $500, Balance: {testacct.Balance:C}");

// Base Account Withdraw Test
bool withdrawSuccess = testacct.Withdraw(500);
Console.WriteLine($"Attempt to withdraw $200: {(withdrawSuccess ? "Success" : "Failed")}, New Balance: {testacct.Balance:C}");
