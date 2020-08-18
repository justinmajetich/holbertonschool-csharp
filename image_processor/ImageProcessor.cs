﻿using System;
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

        List<Task> tasks = new List<Task>();

        // Iterate through all .jpg files in images directory
        Parallel.ForEach(filenames, (imagePath) =>
        {
            {
                // For each image file create a new Bitmap object
                Bitmap image = new Bitmap(imagePath);

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

                // Extract filename from path and edit for new save
                string[] nameSplit = imagePath.Split(new Char[] {'/', '.'});
                String newFilename = nameSplit[nameSplit.Length - 2] + "_inverse." +
                                        nameSplit[nameSplit.Length - 1];

                // Save inverted image to new file
                image.Save(newFilename);
            }
        });
    }
}