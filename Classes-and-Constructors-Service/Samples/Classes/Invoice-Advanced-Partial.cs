using System;

namespace Classes_and_Constructors_Service.Samples.Classes
{
    public partial class Invoice_Partial
    {
        public Invoice_Partial(int invoiceId, string customerName, double invoiceTotal)
        {
            _invoiceId = invoiceId;
            _invoiceTotal = invoiceTotal;
            _customerName = customerName;
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
