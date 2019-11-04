using System;

namespace Classes_and_Constructors_Service.Samples.Classes
{
    public partial class Invoice_Partial
    {
        private int _invoiceId;
        private string _customerName;
        private double _invoiceTotal;

        public Invoice_Partial()
        {
            Console.WriteLine("Default Constructor!");
        }
    }
}
