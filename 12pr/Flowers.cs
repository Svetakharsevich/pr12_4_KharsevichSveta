using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13pr
{
    public class Flowers
    {
        private string name;
        private string type;
        private string country;
        private int length;
        private int price;
        static public int price_bye = 0;
        public int price_one;
        static public List<Flowers> list=new List<Flowers>();
        
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
      
        public string Type
        {
            get
            {
               return type;
            }
            set
            {
                type = value;
            }
        }
     
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public int Length
        {
            get
            {
               return length;
            }
            set
            {
                length = value;
            }
        }
        public int Price
        {
            get
            {
               return price;
            }
            set
            {
                price = value;
            }

        }
        public int bounquent(int count)
        {
            return price * count;
        }
        public int price_more(int value)
        {
            price_bye+= price * value;
            return price * value;
        }
    }
}
