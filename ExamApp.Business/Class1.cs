﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp.Business
{
    
    public class Class1
    {
        public string result = string.Empty;
        dynamic order = new Order().Customer.ToString();
        
        public void Func(Order order)
        {
            var xys = order?.Customer?.Name.ToUpper();
        }
    }

   public class Order
    {
        public Customer Customer { get; set; }
    }

    public   class Customer
    {
        public string Name { get; set; }
    }
}
