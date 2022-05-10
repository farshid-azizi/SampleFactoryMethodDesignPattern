using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFactoryMethodDesignPattern
{
    public abstract class CardType
    {
        protected double CreditLimit;
        public abstract void setCreditLimit();
        public override string ToString()
        {
            return "Your card is " + this.GetType().Name + " & your credit limit is " + CreditLimit;   
        }

    }
}
