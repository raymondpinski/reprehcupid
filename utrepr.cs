Image image = liveLocal.Render(); // Render the image
using (FileStream fs = new FileStream("image.png", FileMode.Create))
{
    image.Save(fs, ImageFormat.Png); // Save the image to a file stream in PNG format
}
