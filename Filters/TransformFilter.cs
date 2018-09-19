using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public class TransformFilter : ParametrizedFilter<EmptyParameters>
    {
        /// <summary>
        /// Как размер исходного фото превращается в размер результирующего
        /// </summary>
        readonly Func<Size, Size> sizeTransform;
        /// <summary>
        /// Логика трансформации точки.
        /// </summary>
        readonly Func<Point, Size, Point> pointTransform;

        readonly string name;
        public override string ToString()
        {
            return name;
        }

        public TransformFilter(Func<Size, Size> sizeTransform, Func<Point, Size, Point> pointTransform, string name)
        {
            this.name = name;
            this.sizeTransform = sizeTransform;
            this.pointTransform = pointTransform;
        }

        public override Photo Process(Photo original, EmptyParameters parametrs)
        {
            //получаем размер старого изображения
            Size oldSize = new Size(original.width, original.height);
            //получаем размер нового изображения (если это будет просто зеркальное оборажение, но размер изменяться не будет)
            Size newSize = sizeTransform.Invoke(oldSize);

            //результирующее фото
            Photo photoRezult = new Photo(newSize.Width, newSize.Height);

            for (int x = 0; x < newSize.Width; x++)
                for (int y = 0; y < newSize.Height; y++)
                {
                    //текущая точка старого изображения 
                    Point point = new Point(x, y);

                    //берем точку из старого изображения, изменяем ее координаты
                    Point oldPoint = pointTransform.Invoke(point, oldSize);

                    //записываем 
                    photoRezult[x, y] = original[oldPoint.X, oldPoint.Y];
                }

            return photoRezult;
        }
    }
}
