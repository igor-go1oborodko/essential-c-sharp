using System;
namespace aggregation
{
    public abstract class Deposit
    {
        public decimal Amount { get; }
        public int Period { get; }

        public Deposit(decimal depositAmount, int depositPeriod)
        {
            this.Amount = depositAmount;
            this.Period = depositPeriod;
        }

        public abstract decimal Income();
    }

    public class BaseDeposit : Deposit
    {
        public BaseDeposit(decimal amount, int period) : base(amount, period)
        {
        }

        public override decimal Income()
        {
            int counter = 0;
            decimal income = 0;

            while (counter < this.Period)
            {
                income = decimal.Round(income + (income * (decimal)0.05), 2, MidpointRounding.AwayFromZero);

                counter++;
            }

            return income;
        }
    }

    public class SpecialDeposit : Deposit
    {
        public SpecialDeposit(decimal amount, int period) : base(amount, period)
        {
        }

        public override decimal Income()
        {
            int counter = 0;
            decimal basePercent = (decimal)0.01;
            decimal income = 0;

            while (counter < this.Period)
            {
                income = decimal.Round(income + (income * basePercent), 2, MidpointRounding.AwayFromZero);

                basePercent = basePercent + (decimal)0.01;
                counter++;
            }

            return income;
        }
    }

    public class LongDeposit : Deposit
    {
        public LongDeposit(decimal amount, int period) : base(amount, period)
        {
        }

        public override decimal Income()
        {
            int counter = 6;
            decimal income = 0;

            while (counter < this.Period)
            {
                income = decimal.Round(income + (income * (decimal)0.15), 2, MidpointRounding.AwayFromZero);

                counter++;
            }

            return income;
        }
    }

    public class Client
    {
        private Deposit[] deposits;
        private readonly int depositsLimit = 10;
        private int depositsCount = 0;

        public Client()
        {
            this.deposits = new Deposit[this.depositsLimit];
        }

        public bool AddDeposit(Deposit deposit)
        {

            if (this.depositsCount < this.depositsLimit)
            {
                this.deposits[this.depositsCount] = deposit;
                this.depositsCount++;

                return true;
            }

            return false;
        }

        public decimal TotalIncome()
        {
            decimal totalIncome = 0;

            for (int i = 0; i < this.deposits.Length; i++)
            {
                totalIncome += deposits[i].Income();
            }

            return totalIncome;
        }

        public decimal MaxIncome()
        {
            decimal maxIncome = this.deposits[0].Income();

            for (int i = 1; i < this.deposits.Length; i++)
            {
                if (this.deposits[i].Income() > maxIncome)
                {
                    maxIncome = deposits[i].Income();
                }
            }

            return maxIncome;
        }

        public decimal GetIncomeByNumber(int number)
        {

            if (this.deposits[number - 1] != null)
            {
                return this.deposits[number - 1].Income();
            }

            return 0;
        }
    }
}

