using System;
using System.Collections.Generic;

namespace BuyIt.Shared.Entities;

public partial class ProductsRate
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int UserId { get; set; }

    public string? Review { get; set; }

    public int Score { get; set; }

    public DateOnly Date { get; set; }

    public virtual Product Product { get; set; } = null!;
}
