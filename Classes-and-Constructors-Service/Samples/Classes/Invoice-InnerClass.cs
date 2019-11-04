using System;

namespace Classes_and_Constructors_Service.Samples.Classes
{
    public class Invoice_InnerClass
    {
        private InvoiceDetails _invoiceDetails;

        public Invoice_InnerClass()
        {
            _invoiceDetails = new InvoiceDetails();
        }

        public Invoice_InnerClass(int invoiceId, string customerName, double invoiceTotal)
        {
            _invoiceDetails = new InvoiceDetails
            {
                _invoiceId = invoiceId,
                _customerName = customerName,
                _invoiceTotal = invoiceTotal
            };
        }

        public Invoice_InnerClass(InvoiceDetails invoiceDetails)
        {
            _invoiceDetails = invoiceDetails;
        }

        public void DisplayData()
        {
            Console.WriteLine("*** Invoice Data ***");
            Console.WriteLine($"InvoiceId: #{_invoiceDetails._invoiceId}");
            Console.WriteLine($"Customer: {_invoiceDetails._customerName}");
            Console.WriteLine($"Total: {_invoiceDetails._invoiceTotal}");
        }

        /// <summary>
        /// Inner class defined inside a class
        /// </summary>
        public class InvoiceDetails
        {
            public int _invoiceId;
            public string _customerName;
            public double _invoiceTotal;
        }
    }
}
