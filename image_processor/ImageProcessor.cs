using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Collections.Generic;

/// <summary>
/// Provides methods to perfrom various image processing techniques.
/// </summary>
class ImageProcessor {

    /// <summary>
    /// Inverts a list of image(s).
    /// </summary>
    /// <param name="filenames">A list of images to invert.</param>
    public static void Inverse(string[] filenames) {

        // Iterate through all .jpg files in images directory
        foreach (var imagePath in filenames)
        {
            // For each image file create a new Bitmap object
            Bitmap image = new Bitmap(imagePath);

            // Create an async task to process each image
            Task task = Task.Factory.StartNew( () => {

                // Iterate through each pixel, inverting its color
                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        // Get color of current pixel
                        Color pixelColor = image.GetPixel(x, y);

                        // Set color of current pixel to inverse
                        image.SetPixel(x, y, Color.FromArgb(pixelColor.A,
                            255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B));
                    }
                }
            } );
            // Pause main thread
            task.Wait();

            // Extract filename from path and edit for new save
            string[] nameSplit = imagePath.Split(new Char[] {'/', '.'});
            String newFilename = nameSplit[nameSplit.Length - 2] + "_inverse." +
                                    nameSplit[nameSplit.Length - 1];

            // Save inverted image to new file
            image.Save(newFilename);
        }
    }
}