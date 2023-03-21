namespace ConsoleApp33
{

    public abstract class Beverage
    {
        public abstract string GetName();
        public abstract string GetDescription();
        public abstract decimal GetPrice();
    }

    public class Tea : Beverage
    {
        private string _name;
        private string _description;
        private decimal _price;

        public Tea(string name, string description, decimal price)
        {
            _name = name;
            _description = description;
            _price = price;
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override decimal GetPrice()
        {
            return _price;
        }
    }

    public class Coffee : Beverage
    {
        private string _name;
        private string _description;
        private decimal _price;

        public Coffee(string name, string description, decimal price)
        {
            _name = name;
            _description = description;
            _price = price;
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override decimal GetPrice()
        {
            return _price;
        }
    }

    public class Juice : Beverage
    {
        private string _name;
        private string _description;
        private decimal _price;

        public Juice(string name, string description, decimal price)
        {
            _name = name;
            _description = description;
            _price = price;
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override decimal GetPrice()
        {
            return _price;
        }
    }
}
