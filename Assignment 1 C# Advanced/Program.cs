using System.Globalization;

namespace Assignment_1_C__Advanced
{
    
    public interface IPrinter
    {
        void Print();
    }
    public class Report : IPrinter
    {
        private string report;
        public Report(string report)
        {
            this.report = report;
        }
        public void Print()
        {
            Console.WriteLine("Report: " + report);
        }
    }
    public class Invoice : IPrinter
    {
        private string invoice;
        public Invoice(string invoice)
        {
            this.invoice = invoice;
        }
        public void Print()
        {
            Console.WriteLine("Invoice: " + invoice);
        }

    }

    public class Printer<T> where T:IPrinter
    {
        public void Print(T item)
        {
            item.Print();
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Report report = new Report("Hello");
            Invoice invoice = new Invoice("Hello");
            Printer<Report> printer1 = new Printer<Report>();
            Printer<Invoice> printer2 = new Printer<Invoice>();
            printer1.Print(report);
            printer2.Print(invoice);
        }
    }
}
