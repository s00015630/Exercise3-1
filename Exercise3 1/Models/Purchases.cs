﻿using System;

namespace Exercise3_1.Models
{
    public class Purchases
    {
        public int ID { get; set; }
        public DateTime PurchaseDate { get; set; }
        public virtual User User { get; set; }
        public virtual ShopItem Item { get; set; }
    }
}