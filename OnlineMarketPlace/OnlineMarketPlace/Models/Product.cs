﻿using System;

namespace Shared
{
    public class Product
    {
        public string ProductId { get; set; }
        public string SellerUsername { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int QuantityAvailable { get; set; }
        public string ImageUrl { get; set; }  // URL or file path of product image
        public DateTime DateAdded { get; set; }
        public bool IsActive { get; set; }  // To indicate if product is available or removed

        public Product() { }

        public Product(string productId, string sellerUsername, string name, string description, decimal price, int quantityAvailable, string imageUrl)
        {
            ProductId = productId;
            SellerUsername = sellerUsername;
            Name = name;
            Description = description;
            Price = price;
            QuantityAvailable = quantityAvailable;
            ImageUrl = imageUrl;
            DateAdded = DateTime.Now;
            IsActive = true;
        }

        // Basic validation
        public bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(Name)) return false;
            if (Price <= 0) return false;
            if (QuantityAvailable < 0) return false;
            return true;
        }

        // Display product details
        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product ID: {ProductId}");
            Console.WriteLine($"Seller: {SellerUsername}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Quantity Available: {QuantityAvailable}");
            Console.WriteLine($"Image URL: {ImageUrl}");
            Console.WriteLine($"Date Added: {DateAdded}");
            Console.WriteLine($"Active: {IsActive}");
        }

        // Methods for CRUD can be implemented or handled externally by a data access class
        public void UpdatePrice(decimal newPrice)
        {
            if (newPrice > 0)
                Price = newPrice;
        }

        public void UpdateQuantity(int newQuantity)
        {
            if (newQuantity >= 0)
                QuantityAvailable = newQuantity;
        }

        public void RemoveProduct()
        {
            IsActive = false;
        }
    }
}
