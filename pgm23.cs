// An ecommerce website provide cashback on the purchase amount.take a input of amount from the user side.Calculate the cashback amount

using System;

class CashbackCalculator
{
    private double purchaseAmount;
    private double cashbackRate = 0.05; // 5% cashback

    // Constructor to initialize purchase amount
    public CashbackCalculator(double amount)
    {
        purchaseAmount = amount;
    }

    // Method to calculate cashback
    public double CalculateCashback()
    {
        return purchaseAmount * cashbackRate;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the purchase amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        // Creating an object for cashback calculation
        CashbackCalculator cashback = new CashbackCalculator(amount);
        double cashbackAmount = cashback.CalculateCashback();

        Console.WriteLine($"Cashback Amount: ₹{cashbackAmount}");
    }
}
