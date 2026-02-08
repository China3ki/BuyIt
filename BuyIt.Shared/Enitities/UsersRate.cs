using System;
using System.Collections.Generic;

namespace BuyIt.Shared.Enitities;

public partial class UsersRate
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string? Review { get; set; }

    public int Score { get; set; }

    public DateOnly Date { get; set; }

    public virtual User User { get; set; } = null!;
}
