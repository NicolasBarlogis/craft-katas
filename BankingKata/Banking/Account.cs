namespace Banking
{

    public class Account
    {
        private float balance;

        public void Deposit(float money)
        {
            balance += money;
        }

        public float Balance()
        {
            return balance;
        }

        public void Withdrawal(float money)
        {
            throw new System.NotImplementedException();
        }
    }

}
