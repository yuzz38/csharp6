using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp6
{
    public abstract class IImpactPoint
    {
        public float X; // ну точка же, вот и две координаты
        public float Y;

        // абстрактный метод с помощью которого будем изменять состояние частиц
        // например притягивать
        public abstract void ImpactParticle(Particle particle);

        // базовый класс для отрисовки точечки
        public virtual void Render(Graphics g)
        {
            g.FillEllipse(
                    new SolidBrush(Color.Red),
                    X - 5,
                    Y - 5,
                    10,
                    10
                );
        }
    }
    public class GravityPoint : IImpactPoint
    {
        public int Power = 100; // сила притяжения

        // а сюда по сути скопировали с минимальными правками то что было в UpdateState
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY); // считаем расстояние от центра точки до центра частицы
            if (r + particle.Radius < Power / 2) // если частица оказалось внутри окружности
            {
                // то притягиваем ее
                float r2 = (float)Math.Max(100, gX * gX + gY * gY);
                particle.SpeedX += gX * Power / r2;
                particle.SpeedY += gY * Power / r2;
            }
        }
        public override void Render(Graphics g)
        {
            // буду рисовать окружность с диаметром равным Power
            g.DrawEllipse(
                   new Pen(Color.Red),
                   X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
               );
            var stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            // обязательно выносим текст и шрифт в переменные
            var text = $"Я гравитон\nc силой {Power}";
            var font = new Font("Verdana", 10);

            // вызываем MeasureString, чтобы померить размеры текста
            var size = g.MeasureString(text, font);

            // рисуем подложнку под текст
            g.FillRectangle(
                new SolidBrush(Color.Red),
                X - size.Width / 2, // так как я выравнивал текст по центру то подложка должна быть центрирована относительно X,Y
                Y - size.Height / 2,
                size.Width,
                size.Height
            );

            // ну и текст рисую уже на базе переменных
            g.DrawString(
                text,
                font,
                new SolidBrush(Color.White),
                X,
                Y,
                stringFormat
            );
        }
    }
    public class AntiGravityPoint : IImpactPoint
    {
        public int Power = 100; // сила отторжения

        // а сюда по сути скопировали с минимальными правками то что было в UpdateState
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            float r2 = (float)Math.Max(100, gX * gX + gY * gY);

            particle.SpeedX -= gX * Power / r2; // тут минусики вместо плюсов
            particle.SpeedY -= gY * Power / r2; // и тут
        }
    }
    public class TeleportPoint : IImpactPoint
    {
        public float ExitX; // координаты выхода
        public float ExitY;
        public int Radius = 50; // радиус действия телепорта

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY); // расстояние до центра телепорта

            // если частица в радиусе действия телепорта
            if (r + particle.Radius < Radius)
            {
                float relativeSpeedX = particle.SpeedX;
                float relativeSpeedY = particle.SpeedY;

                // телепортируем частицу
                particle.X = ExitX;
                particle.Y = ExitY;

                // инвертируем направление скорости (разворачиваем частицу)
                particle.SpeedX = -relativeSpeedX;
                particle.SpeedY = -relativeSpeedY;
            }
        }

        public override void Render(Graphics g)
        {
            // рисуем вход телепорта (синий круг)
            g.DrawEllipse(
                new Pen(Color.Blue, 2),
                X - Radius,
                Y - Radius,
                Radius * 2,
                Radius * 2
            );

            // рисуем выход телепорта (зеленый круг)
            g.DrawEllipse(
                new Pen(Color.Green, 2),
                ExitX - Radius,
                ExitY - Radius,
                Radius * 2,
                Radius * 2
            );

            // соединяем вход и выход линией
            g.DrawLine(
                new Pen(Color.White, 1),
                X, Y,
                ExitX, ExitY
            );
        }
    }
}
