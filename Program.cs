using System;
using System.ComponentModel;

class Paymenttracker
{
    static void Main()
    {        
        List<Payment> payments = new List<Payment>();
        //Below, we add to this list called 'payments'

        while (true)
    {
        Console.WriteLine("Payment Tracker");
        Console.WriteLine("1. Add payment");
        Console.WriteLine("2. View payments");
        Console.WriteLine("3. Search payments");
        Console.WriteLine("4. Calculate total payments");
        Console.WriteLine("5. Exit");
        Console.WriteLine("Select an option: ");
        bool conversionworked = int.TryParse(Console.ReadLine(), out int selectoption); /// int.TryParse(input, output)

        if (!conversionworked)
        {
            Console.WriteLine("Please enter a number.");
        }
        else
        {
    
        switch (selectoption)
        {
            case 1:
                Console.WriteLine("Add payment selected");
                Payment payment1 = new Payment(); ///left side is taking
                /// a copy of the blueprints of Payment and calling this copy
                /// payment1; which will be the address where the target value is
                /// stored. That is what the left side does, then the right side
                /// turns that named/labeled blueprint and finds it a space in memory;
                /// thereby creating the object. Also, I think this is
                /// an instance of Payment class. So payment1 has all that
                /// you see in the Payment class.
                Console.WriteLine("Enter client name:");
                payment1.ClientName = Console.ReadLine();
                Console.WriteLine("Enter payment amount");
                payment1.Amount = decimal.Parse(Console.ReadLine());
                payment1.PaymentDate = DateTime.Today;
                Console.WriteLine("Enter insurance name");
                payment1.InsuranceCompany = Console.ReadLine();
                //The above assigns values to each property in
                //the Payment object, payment1.
                payments.Add(payment1);//this stores payment1 in payments list -
                //which comes, not only with the value, but also with the stuff like
                //"amount =" and "paymentdate =" etc.
                break;
            case 2:
                foreach (Payment payment in payments)
                        {
                            Console.WriteLine(payment.ClientName);
                            Console.WriteLine(payment.Amount);
                            Console.WriteLine(payment.PaymentDate);
                            Console.WriteLine(payment.InsuranceCompany);
                        }
                break;
            case 3:
                Console.WriteLine("Enter client name to search:");
                string searchName = Console.ReadLine();
                bool found = false;
                foreach (Payment payment in payments)
                {
                    if (payment.ClientName == searchName)
                    {
                        Console.WriteLine($"Client: {payment.ClientName}");
                        Console.WriteLine($"Amount: {payment.Amount:C}");
                        Console.WriteLine($"Date: {payment.PaymentDate.ToShortDateString()}");
                        Console.WriteLine($"Insurance: {payment.InsuranceCompany}");
                        found=true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine
                break;
            case 4:
                decimal total = 0;
                foreach (Payment payment in payments)
                {
                 total += payment.Amount;
                }
                 Console.WriteLine($"Total payments: {total:C}");   
                break;
            case 5:
                Console.WriteLine("Existing...");
                return;
            default:
            Console.WriteLine("Invalid selection");
                break;
        }
        }
    }

    }

}