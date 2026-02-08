using System;
using System.Collections.Generic;

namespace BuyIt.Shared.Enitities;

public partial class Chat
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int RecipientId { get; set; }

    public string Message { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;

    public virtual User Recipient { get; set; } = null!;
}
