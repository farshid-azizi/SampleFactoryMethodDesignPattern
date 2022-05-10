using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFactoryMethodDesignPattern
{
    public class PlatinumCard : CardType
    {
        public PlatinumCard()
        {
            setCreditLimit();
        }
        public override void setCreditLimit()
        {
            CreditLimit = 50000;
        }
    }
}
