Console.WriteLine("Please enter the monthlyPrice of the Subscription:");

bool isPriceValid = decimal.TryParse(Console.ReadLine(), out decimal monthlyPrice);

Console.WriteLine("Please enter the number of months:");

bool isMonthsValid = int.TryParse(Console.ReadLine(), out int months);

if (isPriceValid == false || monthlyPrice <= 0 || isMonthsValid == false || months <= 0) 
{
    Console.WriteLine("Invalid Input!");
    return;
        }

    decimal originalPrice = monthlyPrice * months;
    
    decimal discountAmount = 0;

    if (months >= 12)
    {
        discountAmount = months *(monthlyPrice * 0.10m);
          
    }

    decimal totalPrice = originalPrice - discountAmount;
    
    Console.WriteLine($"The originalPrice is: {originalPrice} EUR");
    Console.WriteLine($"The discountAmount is: {discountAmount} EUR");
    Console.WriteLine($"The total price is: {totalPrice} EUR");


