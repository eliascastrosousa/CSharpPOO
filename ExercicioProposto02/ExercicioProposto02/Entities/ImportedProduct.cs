using System;


namespace ExercicioProposto02.Entities 
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(String name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            TotalPrice();
            return base.PriceTag() + " (" + CustomsFee + ")".ToString();
        }

        public double TotalPrice()
        {
            Price = Price + CustomsFee;
            return Price;
        }

        public override string ToString()
        {
            return Name + Price + CustomsFee.ToString();
        }

    }
}
