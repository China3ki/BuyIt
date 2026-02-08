using System;
using System.Collections.Generic;

namespace BuyIt.Shared.Entities;

public partial class Company
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string StreetNumber { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
