﻿using System.Collections.Generic;

// By Filipe
namespace ImageProcessorLibrary
{
    public interface IImageLoader
    {
        /// <summary>
        /// Load the initial images that will appear when the program first starts
        /// </summary>
        /// <returns>a vector of strings containing the path for each image found</returns>
        IList<string> LoadInitalImages();
    }
}