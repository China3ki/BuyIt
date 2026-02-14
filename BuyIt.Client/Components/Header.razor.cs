namespace BuyIt.Client.Components
{
    public partial class Header
    {
        private bool _focus = false;
        private void FocusInput() => _focus = true;
        private void BlurInput() => _focus = false;
    }
}
