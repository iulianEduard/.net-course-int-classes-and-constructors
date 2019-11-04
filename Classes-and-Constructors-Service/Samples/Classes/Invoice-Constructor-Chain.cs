using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Constructors_Service.Samples.Classes
{
    public class Invoice_Constructor_Chain
    {
        private int _invoiceId;
        private string _customerName;
        private double _invoiceTotal;
        private DateTime createdDate;

        public Invoice_Constructor_Chain()
        {
            createdDate = DateTime.Now;
            Console.WriteLine("0 - This is the base constructor!");
            Console.WriteLine("");
        }

        public Invoice_Constructor_Chain(int invoiceId, double invoiceTotal) : this()
        {
            Console.WriteLine("1 - First chain constructor!");
            Console.WriteLine("");
            _invoiceId = invoiceId;
            _invoiceTotal = invoiceTotal * 0.001;
            Console.WriteLine("Penalty for not providing customer name applied");
        }

        public Invoice_Constructor_Chain(int invoiceId, string customerName, double invoiceTotal) : this(invoiceId, invoiceTotal)
        {
            Console.WriteLine("2 - Second chain constructor!");
            Console.WriteLine("");
            _customerName = customerName;
        }

        public void DisplayData()
        {
            Console.WriteLine("");
            Console.WriteLine("*** Invoice Data ***");
            Console.WriteLine($"InvoiceId: #{_invoiceId}");
            Console.WriteLine($"Customer: {_customerName}");
            Console.WriteLine($"Total: {_invoiceTotal}");
            Console.WriteLine($"Created date: {createdDate.Ticks}");
            Console.WriteLine("");
        }
    }
}
