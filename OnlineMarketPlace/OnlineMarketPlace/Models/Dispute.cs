﻿using System;

namespace Shared
{
    public class Dispute
    {
        public string DisputeId { get; set; }
        public string OrderId { get; set; }       // Which order the dispute is about
        public string BuyerUsername { get; set; }
        public string SellerUsername { get; set; }
        public string Reason { get; set; }        // Reason for dispute
        public string Status { get; set; }        // e.g. "Open", "Under Review", "Resolved", "Closed"
        public DateTime DateFiled { get; set; }
        public DateTime? DateResolved { get; set; }

        public Dispute() { }

        public Dispute(string disputeId, string orderId, string buyerUsername, string sellerUsername, string reason)
        {
            DisputeId = disputeId;
            OrderId = orderId;
            BuyerUsername = buyerUsername;
            SellerUsername = sellerUsername;
            Reason = reason;
            Status = "Open";
            DateFiled = DateTime.Now;
        }

        public void UpdateStatus(string newStatus)
        {
            Status = newStatus;

            if (newStatus == "Resolved" || newStatus == "Closed")
            {
                DateResolved = DateTime.Now;
            }
        }

        public void DisplayDisputeInfo()
        {
            Console.WriteLine($"Dispute ID: {DisputeId}");
            Console.WriteLine($"Order ID: {OrderId}");
            Console.WriteLine($"Buyer: {BuyerUsername}");
            Console.WriteLine($"Seller: {SellerUsername}");
            Console.WriteLine($"Reason: {Reason}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Filed On: {DateFiled}");

            if (DateResolved.HasValue)
                Console.WriteLine($"Resolved On: {DateResolved.Value}");
        }
    }
}