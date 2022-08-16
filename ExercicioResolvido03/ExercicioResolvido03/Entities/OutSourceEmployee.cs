using System;
using ExercicioResolvido03.Entities;

namespace ExercicioResolvido03.Entities
{
    internal class OutSourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutSourceEmployee()
        {

        }

        public OutSourceEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }

        public override string ToString()
        {
            return ("Name: "+Name + " Hours: " + Hours + " ValuePerHour: " + ValuePerHour + " AdditionalCharge: " + AdditionalCharge + " Payment: " + Payment());

        }


    }
}
