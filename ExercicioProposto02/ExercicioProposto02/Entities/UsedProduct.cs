using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto02.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name , Double price, DateTime manufactureDate )
        : base( name , price )
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + " (Manufacture Date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")".ToString();
        }
    }
}
