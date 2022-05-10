using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFactoryMethodDesignPattern
{
    public class SilverCard : CardType
    {
        public SilverCard()
        {
            setCreditLimit();
        }
        public override void setCreditLimit()
        {
            CreditLimit = 10000;
        }
    }
}
