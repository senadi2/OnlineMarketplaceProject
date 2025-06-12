using System;
using Shared;

namespace BuyerModule
{
    public class Buyer : User
    {
        public string ShippingAddress { get; set; }

        public Buyer() { }

        public Buyer(int userID, string username, string password, string email, string shippingAddress)
            : base(userID, username, password, email)
        {
            ShippingAddress = shippingAddress;
        }

        public void PlaceOrder()
        {
            Console.WriteLine($"{Username} placed an order.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Shipping Address: {ShippingAddress}");
        }
    }
}
