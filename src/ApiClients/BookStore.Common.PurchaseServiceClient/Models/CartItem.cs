﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Common.PurchaseServiceClient.Models
{
    class CartItem
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int BookId { get; set; }
    }
}
