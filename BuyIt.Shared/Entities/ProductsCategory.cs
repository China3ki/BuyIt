using System;
using System.Collections.Generic;

namespace BuyIt.Shared.Entities;

public partial class ProductsCategory
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual ICollection<ProductsSubcategory> ProductsSubcategories { get; set; } = new List<ProductsSubcategory>();
}
