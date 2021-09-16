using Microsoft.EntityFrameworkCore;
using akbkoleso.Models;
using System;
using System.Linq;

namespace akbkoleso.Data
{
    public class CartDbRerpository : ICartRepository
    {
        private readonly akbkolesoContext akbkolesoContext;

        public CartDbRerpository(akbkolesoContext akbkolesoContext)
        {
            this.akbkolesoContext = akbkolesoContext;
        }

        public Cart AddProduct(Guid id, Product product)
        {
            var cart = akbkolesoContext.Carts.FirstOrDefault(x => x.Id == id);
            var existingSameProduct = cart.CartItems.FirstOrDefault(x => x.ProductId == product.Id);
            if (existingSameProduct != null)
            {
                existingSameProduct.Amount += 1;
            }
            else
            {
                cart.CartItems.Add(new CartItem { Cart = cart, Product = product, Amount = 1, Id = Guid.NewGuid() });
            }
            akbkolesoContext.SaveChanges();
            return cart;
        }

        public Cart Create(string userId, Product product)
        {
            var cart = new Cart { UserId = userId };
            akbkolesoContext.Carts.Add(cart);
            cart.CartItems.Add(new CartItem { Cart = cart, Product = product, Amount = 1, Id = Guid.NewGuid() });//натсроить чтобы id генерировалась автоматически
            akbkolesoContext.SaveChanges();
            return cart;
        }

        public void DeleteCart(string userId)
        {
            akbkolesoContext.Carts.Remove(TryGetByUserId(userId));
            akbkolesoContext.SaveChanges();
        }

        public Cart TryGetByUserId(string userId)
        {
            var cart = akbkolesoContext.Carts.Include(c => c.CartItems).ThenInclude(p => p.Product).FirstOrDefault(i => i.UserId == userId);
            return cart;
        }

        public void Update(Cart existingCart)
        {
            var cart = akbkolesoContext.Carts.FirstOrDefault(x => x.Id == existingCart.Id);
            cart = existingCart;
            akbkolesoContext.SaveChanges();
        }

        public void DeleteItem(Cart existingCart, Product product)
        {
            var cart = akbkolesoContext.Carts.FirstOrDefault(x => x.Id == existingCart.Id);
            var cartItem = cart.CartItems.FirstOrDefault(x => x.ProductId == product.Id);
            product.CartItems.Remove(cartItem);
            akbkolesoContext.SaveChanges();
        }
    }
}