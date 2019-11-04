﻿using System;

namespace Classes_and_Constructors_Service.Samples.Classes
{
    public class Invoice
    {
        private int _invoiceId;
        private string _customerName;
        private double _invoiceTotal;

        public Invoice(int invoiceId, string customerName, double invoiceTotal)
        {
            _invoiceId = invoiceId;
            _customerName = customerName;
            _invoiceTotal = invoiceTotal;
        }

        public void DisplayData()
        {
            Console.WriteLine("*** Invoice Data ***");
            Console.WriteLine($"InvoiceId: #{_invoiceId}");
            Console.WriteLine($"Customer: {_customerName}");
            Console.WriteLine($"Total: {_invoiceTotal}");
        }
    }
}
