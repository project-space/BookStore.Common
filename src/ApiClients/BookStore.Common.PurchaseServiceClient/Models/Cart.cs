﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Common.PurchaseServiceClient.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int? AccountId { get; set; }
        public string GuestId { get; set; }
    }
}
