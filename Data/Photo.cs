using System;

namespace MyPhotoshop
{
    public class Photo
    {
        public readonly int width;
        public readonly int height;
        /// <summary>
        /// Поле, которое представляет собой изображение (набор пикселей)
        /// </summary>
        public readonly Pixel[,] data;

        public Photo(int width, int height)
        {
            this.height = height;
            this.width = width;

            this.data = new Pixel[this.width, this.height];
        }

        public ref Pixel this[int x, int y]
        {
            get { return ref this.data[x, y]; }
        }

    }
}

