using System;

namespace Assignment_2_C__Advanced
{
    
    public class CSVFileHandler
    {
        string file;
        public event EventHandler Notify;
        public CSVFileHandler(string file)
        {
            this.file = file;
        }
        public void UploadFile()
        {
            Console.WriteLine("Uploading...");
        }
        public void Convert()
        {
            Console.WriteLine("Converting...");
        }
        public void Save()
        {
            Console.WriteLine("Saving...");
            Notify.Invoke(this,EventArgs.Empty);
        }
    }
    public class NotificationSystem
    {
        public void Component1(object sender, EventArgs e)
        {
            Console.WriteLine("Component 1 working....");
        }
        public void Component2(object sender, EventArgs e)
        {
            Console.WriteLine("Component 2 working....");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CSVFileHandler file = new CSVFileHandler("Hello");
            Action process = null;
            process += file.UploadFile;
            process += file.Convert;
            process += file.Save;
            NotificationSystem system = new NotificationSystem();
            file.Notify += system.Component1;
            file.Notify += system.Component2;

            process();
        }
    }
}
