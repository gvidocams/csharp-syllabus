namespace Account
{
    class Account
    {
        private string _name;
        private double _money;

        public Account(string v1, double v2)
        {
            _name = v1;
            _money = v2;
        }

        public double Withdrawal(double i)
        {
            if(_money >= i)
            {
                _money -= i;
                return i;
            }
            else
            {
                return 0;
            }
        }

        public void Deposit(double i)
        {
            _money += i;
        }

        public double Balance()
        {
            return _money;
        }

        public override string ToString()
        {
            return $"{_name}: {_money}";
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
}
