using System;
using System.Collections.Generic;

namespace BuyIt.Shared.Enitities;

public partial class Product
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int StatusId { get; set; }

    public int CategoryId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int UnitsSold { get; set; }

    public int ProductsNumber { get; set; }

    public decimal Price { get; set; }

    public virtual ICollection<CartList> CartLists { get; set; } = new List<CartList>();

    public virtual ProductsCategory Category { get; set; } = null!;

    public virtual ICollection<Chat> Chats { get; set; } = new List<Chat>();

    public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();

    public virtual ICollection<ProductsDiscount> ProductsDiscounts { get; set; } = new List<ProductsDiscount>();

    public virtual ICollection<ProductsImage> ProductsImages { get; set; } = new List<ProductsImage>();

    public virtual ICollection<ProductsRate> ProductsRates { get; set; } = new List<ProductsRate>();

    public virtual ProductsStatus Status { get; set; } = null!;

    public virtual User User { get; set; } = null!;

    public virtual ICollection<Wishlist> Wishlists { get; set; } = new List<Wishlist>();
}
