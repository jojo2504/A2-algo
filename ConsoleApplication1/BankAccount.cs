namespace ConsoleApplication1
{
    public class BankAccount
    {
        private string _client;
        private float _balance;
        private bool _isBlocked = false;
        private int _failCount = 0;
    
        public static int NumberClient;
        public static int NumberClientBlocked;
        
        public BankAccount(string client, float balance)
        {
            NumberClient++;
            _client = client;
            _balance = balance;
        }
    
        public bool Debit(float amount)
        {
            if (amount < 0 || _isBlocked)
            {
                return false;
            } 
            if (amount > _balance)
            {
                _failCount++;
                if (_failCount >= 2)
                {
                    NumberClientBlocked++;
                    _isBlocked = true;
                }
                return false;
            }
    
            NumberClient--;
            _isBlocked = false;
            _balance -= amount;
            return true;
        }
    
        public void Credit(float amount)
        {
            _balance -= amount;
        }
    }
}