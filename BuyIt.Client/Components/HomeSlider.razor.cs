namespace BuyIt.Client.Components
{
    public partial class HomeSlider
    {
        private readonly string[] _promoImagesUrl = ["/images/promo1.png", "/images/promo2.png", "/images/promo3.png", "/images/promo4.png", "/images/promo5.png"];
        private int _currentImageNumber = 0;
        /// <summary>
        /// Sets the currently selected image by specifying its number.
        /// </summary>
        /// <param name="imageNumber">The number of the image to select. Must be a valid index corresponding to an available image.</param>
        private void SelectImage(int imageNumber) => _currentImageNumber = imageNumber;
    }
}
