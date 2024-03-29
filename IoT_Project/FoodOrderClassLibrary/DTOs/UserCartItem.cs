﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IoT_Project_Food_Ordering.DTOs
{
    public class UserCartItem
    {
        public int CartItemId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Cost { get; set; }
    }
}
