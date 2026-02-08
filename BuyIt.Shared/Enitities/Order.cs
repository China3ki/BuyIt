using System;
using System.Collections.Generic;

namespace BuyIt.Shared.Enitities;

public partial class Order
{
    public int Id { get; set; }

    public int SellerId { get; set; }

    public int UserId { get; set; }

    public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();

    public virtual User Seller { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
