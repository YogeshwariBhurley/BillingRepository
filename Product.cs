﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BillingApp.Models
{
    public class Product
    {
        //Defining Product entities
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }
    }
}
