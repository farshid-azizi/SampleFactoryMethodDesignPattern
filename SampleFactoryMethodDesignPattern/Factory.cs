using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFactoryMethodDesignPattern
{
    public class Factory
    {
        public static CardType Getcard(String type)
        {
            switch (type)
            {
                case "Silver":
                    return new SilverCard();
                case "Gold":
                    return new GoldCard();
                case "Platinum":
                    return new PlatinumCard();
                default:
                    return null;
            }
        }
    }
}
