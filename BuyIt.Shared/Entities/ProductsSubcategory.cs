using System;
using System.Collections.Generic;

namespace BuyIt.Shared.Entities;

public partial class ProductsSubcategory
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int CategoryId { get; set; }

    public virtual ProductsCategory Category { get; set; } = null!;
}
