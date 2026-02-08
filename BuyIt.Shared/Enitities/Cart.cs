namespace BuyIt.Shared.Enitities;

public partial class Cart
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public virtual ICollection<CartList> CartLists { get; set; } = new List<CartList>();

    public virtual User User { get; set; } = null!;
}
