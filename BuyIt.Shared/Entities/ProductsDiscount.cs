using System;
using System.Collections.Generic;

namespace BuyIt.Shared.Entities;

public partial class ProductsDiscount
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public decimal Price { get; set; }

    public virtual Product Product { get; set; } = null!;
}
