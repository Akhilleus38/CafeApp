﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Models
{
    public class ShoppingCartItem
    {
        //public int id { get; set; }
        //public double price { get; set; }
        //public decimal totalAmount { get; set; }
        //public int qty { get; set; }
        public string ProductName { get; set; }


        public int Id { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
        public double TotalAmount { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
    }
}
