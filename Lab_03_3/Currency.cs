namespace Lab_03_3
{
    public class Currency
    {
        public decimal Value { get; set; }

        public Currency(decimal value)
        {
            Value = value;
        }
    }

    class CurrencyUSD : Currency
    {
        public decimal ExchangeRate { get; set; }

        public CurrencyUSD(decimal value, decimal exchangeRate) : base(value)
        {
            ExchangeRate = exchangeRate;
        }

        public static explicit operator CurrencyEUR(CurrencyUSD usd)
        {
            decimal convertedValue = usd.Value * usd.ExchangeRate;
            return new CurrencyEUR(convertedValue, usd.ExchangeRate);
        }

        public static explicit operator CurrencyRUB(CurrencyUSD usd)
        {
            decimal convertedValue = usd.Value * usd.ExchangeRate;
            return new CurrencyRUB(convertedValue, usd.ExchangeRate);
        }
    }

    class CurrencyEUR : Currency
    {
        public decimal ExchangeRate { get; set; }

        public CurrencyEUR(decimal value, decimal exchangeRate) : base(value)
        {
            ExchangeRate = exchangeRate;
        }

        public static explicit operator CurrencyUSD(CurrencyEUR eur)
        {
            decimal convertedValue = eur.Value / eur.ExchangeRate;
            return new CurrencyUSD(convertedValue, eur.ExchangeRate);
        }

        public static explicit operator CurrencyRUB(CurrencyEUR eur)
        {
            decimal convertedValue = eur.Value * eur.ExchangeRate;
            return new CurrencyRUB(convertedValue, eur.ExchangeRate);
        }
    }

    class CurrencyRUB : Currency
    {
        public decimal ExchangeRate { get; set; }

        public CurrencyRUB(decimal value, decimal exchangeRate) : base(value)
        {
            ExchangeRate = exchangeRate;
        }

        public static explicit operator CurrencyUSD(CurrencyRUB rub)
        {
            decimal convertedValue = rub.Value / rub.ExchangeRate;
            return new CurrencyUSD(convertedValue, rub.ExchangeRate);
        }

        public static explicit operator CurrencyEUR(CurrencyRUB rub)
        {
            decimal convertedValue = rub.Value / rub.ExchangeRate;
            return new CurrencyEUR(convertedValue, rub.ExchangeRate);
        }
    }
}