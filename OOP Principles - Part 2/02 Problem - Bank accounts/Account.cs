namespace ProblemBankAccounts
{
    using System;

    public abstract class Account : ICustomer, IDeposit
    {
        private string name;
        protected EnumCustomerType customer;
        protected decimal interestRate;
        // InterestRate: company - 5.7%; individual - 6.8%
        //                         0.057M             0.068M
        private readonly decimal interestRateCompany = 0.057M;
        private readonly decimal interestRateIndividual = 0.068M;


        protected Account(EnumCustomerType customer) // , decimal interestRate
        {
            this.Customer = customer;
            this.InterestRate = interestRate;
        }

        protected Account(string name, EnumCustomerType customer) // , decimal interestRate
        {
            this.Name = name;
            this.Customer = customer;
            this.InterestRate = interestRate;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("This is not correct name.");
                
                this.name = value;
            }
        }

        public EnumCustomerType Customer
        {
            get { return this.customer; }
            set
            {
                if (value.Equals(EnumCustomerType.None))
                    Console.WriteLine("NONE it is not possible choose.");
                
                if (!value.Equals(EnumCustomerType.Company) && !value.Equals(EnumCustomerType.Individual))
                    Console.WriteLine("This is different from 'Company' or 'Individual' customer type.");
                
                this.customer = value;
            }
        }

        protected decimal InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (Customer.Equals(EnumCustomerType.Company))
                {
                    this.interestRate = interestRateCompany;
                }

                if (Customer.Equals(EnumCustomerType.Individual))
                {
                    this.interestRate = interestRateIndividual;                    
                }

            }
        }

        public virtual void DepositMoney()
        {
            Console.WriteLine("Deposit Money!");
        }

        public abstract decimal CalcInterestAmount();
    }
}
