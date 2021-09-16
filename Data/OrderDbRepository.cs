using Microsoft.EntityFrameworkCore;
using akbkoleso.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace akbkoleso.Data { 
    public class OrderDbRepository : IOrderRepository
    {
        private readonly akbkolesoContext akbkolesoContext;

        public OrderDbRepository(akbkolesoContext akbkolesoContext)
        {
            this.akbkolesoContext = akbkolesoContext;
        }

        public Order TryGetByUserId(string userId)
        {
            var orders = GetAll();
            foreach (var order in orders)
            {
                if (order.UserId == userId && order.Status == null)
                {
                    return order;
                }
            }
            return null;
        }

        public List<Order> TryGetAllByUserId(string userId)
        {
            var allOrders = GetAll();
            var orders = new List<Order>();
            foreach (var order in allOrders)
            {
                if (order.UserId == userId)
                {
                    orders.Add(order);
                }
            }
            return orders;
        }

        public List<Order> GetAll()
        {
            return akbkolesoContext.Orders.AsNoTracking().Include(o => o.OrderItems).ThenInclude(p => p.Product).ToList();
        }

        public void AddProduct(Guid orderId, Product product, int amount)
        {
            var order = akbkolesoContext.Orders.FirstOrDefault(x => x.Id == orderId);
            order.OrderItems.Add(new OrderItem { Order = order, Product = product, Amount = amount, Id = Guid.NewGuid() });
            akbkolesoContext.SaveChanges();
        }

        public void Create(string userId, Product product, int amount)
        {
            var order = new Order { UserId = userId, Number = GetAll().Count + 1 };
            akbkolesoContext.Orders.Add(order);
            order.OrderItems.Add(new OrderItem { Order = order, Product = product, Amount = amount, Id = Guid.NewGuid() });
            akbkolesoContext.SaveChanges();
        }

        public void AddInformation(Order orderInfo)
        {
            var order = akbkolesoContext.Orders.FirstOrDefault(x => x.Id == orderInfo.Id);
            if (orderInfo.UserAddress != null)
                order.UserAddress = orderInfo.UserAddress;
            if (orderInfo.UserPhone != null)
                order.UserPhone = orderInfo.UserPhone;
            if (orderInfo.Status != null)
                order.Status = orderInfo.Status;
            if (orderInfo.DateTime != null)
                order.DateTime = orderInfo.DateTime;
            if (orderInfo.UserFirstName != null)
                order.UserFirstName = orderInfo.UserFirstName;
            if (orderInfo.UserLastName != null)
                order.UserLastName = orderInfo.UserLastName;
            if (orderInfo.UserEmail != null)
                order.UserEmail = orderInfo.UserEmail;
            if (orderInfo.UserComment != null)
                order.UserComment = orderInfo.UserComment;
            akbkolesoContext.SaveChanges();
        }

        public void ChangeStatus(string status, Guid orderId)
        {
            var order = akbkolesoContext.Orders.FirstOrDefault(x => x.Id == orderId);
            order.Status = status;
            akbkolesoContext.SaveChanges();
        }

        public Order TryGetByOrderId(Guid orderId)
        {
            var orders = GetAll();
            foreach (var order in orders)
            {
                if (order.Id == orderId)
                {
                    return order;
                }
            }
            return null;
        }
    }
}