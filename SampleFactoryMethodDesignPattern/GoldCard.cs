using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFactoryMethodDesignPattern
{
    public class GoldCard : CardType
    {
        public GoldCard()
        {
            setCreditLimit();
        }
        public override void setCreditLimit()
        {
            CreditLimit = 25000;
        }
    }
}
