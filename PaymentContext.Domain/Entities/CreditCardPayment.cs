using System;

namespace PaymentContext.Domain.Entities
{
  public class CreditCardPayment : Payment
    {
    public CreditCardPayment(
      string cardHolderName, 
      string cardNumber, 
      string lastTrasactionNumber,
      DateTime date, 
      DateTime expireDate, 
      decimal total, 
      decimal totalPaid, 
      string payer, 
      string document, 
      string address, 
      string email) : base(
        date, 
        expireDate, 
        total, 
        totalPaid, 
        payer, 
        document, 
        address, 
        email)
    {
      CardHolderName = cardHolderName;
      CardNumber = cardNumber;
      LastTrasactionNumber = lastTrasactionNumber;
    }

    public string CardHolderName { get; private set; }
      public string CardNumber { get; private set; }
      public string LastTrasactionNumber { get; private set; }
    }
}