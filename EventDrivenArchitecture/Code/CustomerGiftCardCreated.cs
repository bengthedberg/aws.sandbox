/// <summary>
/// Event that repesent when a gift card was created for a customer.
/// </summary>

public class CustomerGiftCardCreated 
{
    public Guid CustomerId { get; }
    public Guid GiftCardId { get; }
    public string GiftCardNumber { get; }
    public DateTime ExpiryDate { get; }
    public double Value { get; }

    public CustomerGiftCardCreated(string customerId,
        string giftCardId,
        string giftCardNumber,
        DateTime expiryDate,
        double value) 
    {
        CustomerId = customerId;
        GiftCardId = giftCardId;
        GiftCardNumber = giftCardNumber;
        ExpiryDate = expiryDate;
        Value = value;
    }
}


