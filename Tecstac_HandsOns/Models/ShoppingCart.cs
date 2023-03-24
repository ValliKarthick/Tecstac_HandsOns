namespace Tecstac_HandsOns.Models
{
    public class ShoppingCart
    {
        public string CartId { get; set; }
        public string ItemName { get; set; }
        public int Price { get; set; }
        public string ItemType { get; set; }
        public ShoppingCart(string cartId, string itemName, int price, string itemType)
        {
            this.ItemName = itemName;
            this.CartId = cartId;
            this.Price = price;
            this.ItemType = itemType;
        }
    }
}