using System;

namespace ProblemBankAccounts
{
    class DepositAccount : Account, IWithDrawMoney
    {
        private string fullName;
        private string firstName;
        private string lastName;
        private string name;
        private EnumCustomerType customer;
        private decimal interestRate;

        public DepositAccount(string name, EnumCustomerType customer, int months)
            : base(customer)
        {
            if (customer.Equals(EnumCustomerType.Company))
                this.FullName = name;

            if (customer.Equals(EnumCustomerType.Individual))
            {
                var splitted = name.Split(' ');
                this.FirstName = splitted[0];
                this.LastName = splitted[1];
            }

            this.Months = months;

        }

        public string FullName { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set ; }

        public int Months { get; private set; }

        public void WithDrawMoney()
        {
            Console.WriteLine("Withdraw Money!");
        }

        public override void DepositMoney()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (base.customer.Equals(EnumCustomerType.Company))
                Console.WriteLine("Company - {0}: Deposit Money!", this.FullName);
            if (base.customer.Equals(EnumCustomerType.Individual))
            {
                Console.WriteLine("{0} {1}: Deposit Money!", this.FirstName, this.LastName);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public override decimal CalcInterestAmount()
        {
            Console.WriteLine("DepositA");
            var result = Months*(base.InterestRate);
            return result;
        }


    }
}
