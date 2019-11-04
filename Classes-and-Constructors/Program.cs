using Classes_and_Constructors.Class_Samples;
using Classes_and_Constructors_Service.Samples.Classes;
using System;

namespace Classes_and_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void ImplicitInvoice()
        {
            /*
             * The class is implictily private and declared in the same
             * assembly we can access it
             */
            var invoice = new InvoiceImplicit(230232, "John Doe", 23.33);
            invoice.DisplayData();

            Console.ReadKey();
        }

        static void PublicInvoice()
        {
            /*
             * This class is explictly public declared 
             * and can be access from any assembly
             */
            var invoice = new Invoice(123221, "Mary Doe", 26.36);
            invoice.DisplayData();

            Console.ReadKey();
        }

        static void BaseClassSample()
        {
            /*
             * Because the class is implicitly private and declared in another 
             * assembly we cannot access it
             */
            // var baseClass = new BaseClass();
        }

        static void ConstructorOverloading()
        {
            var defaultConstructor = new Invoice_Overloading();
            defaultConstructor.DisplayData();

            var constructorOverloaded_1 = new Invoice_Overloading(2321312, 49.99);
            constructorOverloaded_1.DisplayData();

            var constructorOverloaded_2 = new Invoice_Overloading(1232131, 59.99);
            constructorOverloaded_2.DisplayData();

            Console.ReadKey();
        }

        static void ChainedConstructors()
        {
            Console.WriteLine("--> Constructor no chain");
            var chained = new Invoice_Constructor_Chain();
            chained.DisplayData();

            Console.WriteLine("--> Constructor chain 1");
            var chained_1 = new Invoice_Constructor_Chain(21321, 99.99);
            chained_1.DisplayData();

            Console.WriteLine("--> Constructor chain 2");
            var chained_2 = new Invoice_Constructor_Chain(24944, "Mother of Dragons", 199.99);
            chained_2.DisplayData();

            Console.ReadKey();
        }

        static void PartialClasses()
        {
            /*
             * The files on the disk have different names but they share a partial class
             * When we initiate the class, it's not the file name but the class(es) defined inside
             * This is useful when you are grouping a functionality that consists of a big chuck of code
             */

            var basicPartial = new Invoice_Partial();
            basicPartial.DisplayData();

            var advancedPartial = new Invoice_Partial(8988, "Jon Snow", 999.99);
            advancedPartial.DisplayData();

            Console.ReadKey();
        }

        static void InnerClass()
        {
            var invoiceWithInnerClass = new Invoice_InnerClass();
            invoiceWithInnerClass.DisplayData();

            invoiceWithInnerClass = new Invoice_InnerClass(922, "Arya Stark", 32.32);
            invoiceWithInnerClass.DisplayData();

            var innerClass = new Invoice_InnerClass.InvoiceDetails
            {
                _invoiceId = 32,
                _customerName = "The Hound",
                _invoiceTotal = 29.99
            };

            var invoiceWithInnerClass_1 = new Invoice_InnerClass(innerClass._invoiceId, innerClass._customerName, innerClass._invoiceTotal);
            invoiceWithInnerClass_1.DisplayData();

            var invoiceDetails = new Invoice_InnerClass.InvoiceDetails
            {
                _invoiceId = 98,
                _customerName = "Jaime Lanister",
                _invoiceTotal = 124.99
            };

            var invoiceWithInnerClass_2 = new Invoice_InnerClass(invoiceDetails);
            invoiceWithInnerClass_2.DisplayData();
        }
    }
}
