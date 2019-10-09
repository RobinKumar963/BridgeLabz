


using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.ObjectOriented.Inventory
{
    public class Inventory
    {
        
            public String name;
            public float weight;
            public float price;

            public Inventory(string name, float weight, float price)
            {
                this.name = name;
                this.weight = weight;
                this.price = price;
            }


            public String Get_name()
            {
                return name;
            }

            public float Get_price()
            {
                return price;
            }

            public float Get_weight()
            {
                return weight;
            }

    }
}
