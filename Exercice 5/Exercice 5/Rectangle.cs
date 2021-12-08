using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_5
{
    /// <summary>
    /// Cette classe est utilisé pour la création et modification de rectangles.
    /// <code>
    ///     Rectangle rectangle = new Rectangle(1, 2);
    ///     rectangle.SetRectangleHeight(1);
    ///     rectangle.SetRectangleLength(2);
    ///     rectangle.GetPerimeter();
    /// </code>
    /// </summary>
    public class Rectangle
    {
        private int height;
        private int length;
        /// <summary>
        /// Ce constructeur nous permet de créer un nouveau rectangle en receuillant une height et une length.
        /// </summary>
        /// <param name="height"></param>
        /// <param name="length"></param>
        public Rectangle(int height, int length)
        {
            this.height = height;
            this.length = length;
        }

        /// <summary>
        /// Cette fonction nous permet de déterminer une nouvelle height pour notre rectangle.
        /// </summary>
        /// <param name="height"></param>
        public void SetRectangleHeight(int height)
        {
            this.height = height;
        }
        /// <summary>
        /// Cette fonction nous permet de déterminer une nouvelle length pour notre rectangle.
        /// </summary>
        /// <param name="length"></param>
        public void SetRectangleLength(int length)
        {
            this.length = length;
        }
        /// <summary>
        /// Cette fonction nous retourne le périmetre de notre rectangle.
        /// </summary>
        /// <returns></returns>
        public int GetPerimeter()
        {
            return ((2 * height) + (2 * length));
        }
    }
}
