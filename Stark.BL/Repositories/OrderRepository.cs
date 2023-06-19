﻿using Stark.Common.Models;
using System;
using System.Collections.Generic;

namespace Stark.BL.Repositories
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if (orderId == 101)
            {
                order.OrderDate = DateTimeOffset.UtcNow;
            }
            return order;
        }

        public List<Order> Retrieve()
        {
            return new List<Order>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
