using System;

namespace MyPhotoshop
{
    public class Photo
    {
        public int width;
        public int height;
        /// <summary>
        /// Поле, которое представляет собой изображение (набор пикселей)
        /// </summary>
        public Pixel[,] data;
    }
}

