using System;
using System.Collections.Generic;

namespace BuyIt.Shared.Entities;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Address { get; set; }

    public string? StreetNumber { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Avatar { get; set; }

    public bool? CompanyAccount { get; set; }

    public bool? AdminAccount { get; set; }

    public DateOnly? JoinDate { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual ICollection<Chat> Chats { get; set; } = new List<Chat>();

    public virtual ICollection<Company> Companies { get; set; } = new List<Company>();

    public virtual ICollection<Order> OrderSellers { get; set; } = new List<Order>();

    public virtual ICollection<Order> OrderUsers { get; set; } = new List<Order>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual ICollection<UsersRate> UsersRates { get; set; } = new List<UsersRate>();

    public virtual ICollection<Wishlist> Wishlists { get; set; } = new List<Wishlist>();
}
