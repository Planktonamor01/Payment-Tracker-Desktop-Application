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
        DisplayMenu();

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
                AddPayment(payments);
                break;
            case 2:
                ViewPayments(payments);
                break;
            case 3:
                SearchPayments(payments);
                break;
            case 4:
                CalculateTotal(payments);
                break;
            case 5:
                Console.WriteLine("Existing...");
                return;
            default:
            Console.WriteLine("Invalid selection. Please choose an option from 1 to 5");
                break;
        }
        }
    }
    }
static void DisplayMenu()
{
    Console.WriteLine("Payment Tracker");
    Console.WriteLine("1. Add payment");
    Console.WriteLine("2. View payments");
    Console.WriteLine("3. Search payments");
    Console.WriteLine("4. Calculate total payments");
    Console.WriteLine("5. Exit");
    Console.WriteLine("Select an option: ");
}
static void AddPayment(List<Payment> payments) //data type, random variable name.
//eg static void SayHello(string, name)
//    {Console.WriteLine($"Hello, {name}!");}
    {
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
        string clientName = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(clientName))
            {Console.WriteLine("Client name cannot be empty. Please enter a name:");
            clientName = Console.ReadLine();
            }
        payment1.ClientName = clientName;
        Console.WriteLine("Enter payment amount");
        bool amountConverted = decimal.TryParse(Console.ReadLine(), out decimal amount);
        while (!amountConverted || amount <= 0)
            {Console.WriteLine("Invalid amount. Please enter a number greater than zero.");
            amountConverted = decimal.TryParse(Console.ReadLine(), out amount);
            }   

        payment1.Amount = amount;

        payment1.PaymentDate = DateTime.Today;

        Console.WriteLine("Enter insurance name");
        string insuranceName = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(insuranceName))
            {Console.WriteLine("Insurance cannot be empty. Please enter a name:");
            insuranceName = Console.ReadLine();
            }
        payment1.InsuranceCompany = insuranceName;
        //The above assigns values to each property in
        //the Payment object, payment1.
        payments.Add(payment1);//this stores payment1 in payments list -
        //which comes, not only with the values, but also with stuff like
        //"amount =" and "paymentdate =" etc.
        Console.WriteLine("Payment added successfully!:");        
    }
static void ViewPayments(List<Payment> payments)
    {
    if (payments.Count == 0)
        {Console.WriteLine("No payments have been added yet.");}
    else
        {foreach (Payment payment in payments)
            {
            Console.WriteLine($"Client: {payment.ClientName}");
            Console.WriteLine($"Amount: {payment.Amount:C}");
            Console.WriteLine($"Date: {payment.PaymentDate}");
            Console.WriteLine($"Insurance: {payment.InsuranceCompany}");
            Console.WriteLine("---------------------");
            }
        }
    }
static void SearchPayments(List<Payment> payments)
    {Console.WriteLine("Enter client name to search:");
    string searchName = Console.ReadLine();
    bool found = false;
    foreach (Payment payment in payments)
        {
        if (payment.ClientName.Equals(searchName, StringComparison.OrdinalIgnoreCase))
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
            Console.WriteLine("No matching payments found.");
            }
    }
static decimal CalculateTotal(List<Payment> payments)
    {
    decimal total = 0;
    foreach (Payment payment in payments)
        {total += payment.Amount;}
    return total; 
    }
}