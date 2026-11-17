using System;

class Payment
{
   public string ClientName {get; set;}
   public decimal Amount {get;set;}
   public DateTime PaymentDate{get;set;}
   public string InsuranceCompany {get;set;}

   // 'get' is intruction to get value, 'set' is instruction
   // to retrieve value; this isn't a dict.

   public Payment(string clientName, decimal amount)
   {
      ClientName = clientName;
      Amount = amount;
   }

}