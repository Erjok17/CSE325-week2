using System.Linq; // Ensure this is at the top for .Sum() to work
using System; // Ensure this is at the top for Math.Round() to work

namespace BlazingPizza;

public class Order
{
    public int OrderId { get; set; }
    public string UserId { get; set; }
    public DateTime CreatedTime { get; set; }
    public Address DeliveryAddress { get; set; } = new Address();
    public List<Pizza> Pizzas { get; set; } = new List<Pizza>();

    public decimal GetTotalPrice() => Pizzas.Sum(p => p.GetTotalPrice());

    public string GetFormattedTotalPrice()
    {
        // Round the total price to the nearest whole number for UGX
        long roundedPrice = (long)Math.Round(GetTotalPrice(), 0);
        // Format it with commas for thousands and no decimals
        return $"USh {roundedPrice:#,0}";
    }
}