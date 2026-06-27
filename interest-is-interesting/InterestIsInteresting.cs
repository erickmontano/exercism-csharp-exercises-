static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        switch (balance)
        {
            case >= 5000: return 2.475f;

            case >= 1000: return 1.621f;

            case >= 0: return 0.5f;

            default: return 3.213f; // < 0
        }

    }

    public static decimal Interest(decimal balance) => (balance * (decimal)InterestRate(balance)) / 100m;

    public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            years++;
        }
        return years;
    }
}
