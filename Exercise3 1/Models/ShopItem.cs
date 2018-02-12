﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise3_1.Models
{
    public class ShopItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public ItemClass Class { get; set; }
        public string ImageURL { get; set; }

    }
    public enum ItemClass {
        Health, 
        Magic,
        Stamina
    }
}