using System;
using System.Collections.Generic;
using System.Text;

namespace intermediateone
{
    class Customer
    {
        public int Id;
        public string name;
        public List<Order> orders;
        public Customer()
        {
           orders = new List<Order>();
        }
        public Customer(int id)
            :this()
        {
            this.Id = id;
        }

        public Customer(int id,string name)
            :this(id)
        {
      
            this.name = name;
        }
    }
}
