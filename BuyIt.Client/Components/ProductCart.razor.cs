using Microsoft.AspNetCore.Components;

namespace BuyIt.Client.Components
{
    public partial class ProductCart
    {
        [Parameter]
        public string Name { get; set; } = string.Empty;
        [Parameter]
        public string Image { get; set; } = string.Empty;
        [Parameter]
        public decimal Price { get; set; }
        [Parameter]
        public decimal PromotionalPrice { get; set; }
    }
}
