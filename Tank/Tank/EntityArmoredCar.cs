using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{
    /// <summary>
    /// Класс-сущность "Бронемашина"
    /// </summary>
    internal class EntityArmoredCar
    {
        /// <summary>
        /// Скорость
        /// </summary>
        public int Speed { get; private set; }
        /// <summary>
        /// Вес
        /// </summary>
        public float Weight { get; private set; }
        /// <summary>
        /// цвет кузова
        /// </summary>
        public Color BodyColor { get; private set; }
        /// <summary>
        /// шаг перемещения
        /// </summary>
        public float Step => Speed * 100 / Weight;
        /// <summary>
        /// Инициализация полей объекта-класса автомобиля
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="weight"></param>
        /// <param name="bodyColor"></param>
        public void Init(int speed, float weight, Color bodyColor)
        {
            Random rnd = new();
            Speed = speed <= 0 ? rnd.Next(50, 150) : speed;
            Weight = weight <= 0 ? rnd.Next(40, 70) : weight;
            BodyColor = bodyColor;
        }
    }
}
