using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Security.Cryptography.X509Certificates;

namespace RefactorMe
{
    class Drawing
    {
        static float x, y;
        static Graphics graphics;

        public static void Initialization(Graphics newGraphics)
        {
            graphics = newGraphics;
            graphics.SmoothingMode = SmoothingMode.None;
            graphics.Clear(Color.Black);
        }

        public static void Set_position(float x0, float y0)
        {
            x = x0; y = y0;
        }

        public static void MakeIt(Pen pen, double length, double angle)
        {
            //Делает шаг длиной length в направлении angle и рисует пройденную траекторию
            var x1 = (float)(x + length * Math.Cos(angle));
            var y1 = (float)(y + length * Math.Sin(angle));
            graphics.DrawLine(pen, x, y, x1, y1);
            x = x1;
            y = y1;
        }

        public static void Change(double length, double angle)
        {
            x = (float)(x + length * Math.Cos(angle)); 
            y = (float)(y + length * Math.Sin(angle));
        }
    }

    public class ImpossibleSquare
    {
        public static void Draw(int width, int height, double angleOfRotation, Graphics graphics)
        {
            //angleOfRotation пока не используется, но будет использоваться в будущем
            Drawing.Initialization(graphics);

            var size = Math.Min(width, height);

            var diagonal_length = Math.Sqrt(2) * (size * 0.375f + size * 0.04f) / 2;
            var x0 = (float)(diagonal_length * Math.Cos(Math.PI / 4 + Math.PI+ angleOfRotation)) + width / 2f;
            var y0 = (float)(diagonal_length * Math.Sin(Math.PI / 4 + Math.PI + angleOfRotation)) + height / 2f;

            Drawing.Set_position(x0, y0);
            DrawSide1(size, angleOfRotation);

            DrawSide2(size, angleOfRotation);
            DrawSide3(size, angleOfRotation);
            DrawSide4(size, angleOfRotation);
        }

        private static void DrawSide4(int size, double angleOfRotation)
        {
            //Рисуем 4-ую сторону
            Drawing.MakeIt(Pens.Yellow, size * 0.375f, Math.PI / 2 + angleOfRotation);
            Drawing.MakeIt(Pens.Yellow, size * 0.04f * Math.Sqrt(2), Math.PI / 2 + Math.PI / 4+ angleOfRotation);
            Drawing.MakeIt(Pens.Yellow, size * 0.375f, Math.PI / 2 + Math.PI + angleOfRotation);
            Drawing.MakeIt(Pens.Yellow, size * 0.375f - size * 0.04f, Math.PI / 2 + Math.PI / 2 + angleOfRotation);

            Drawing.Change(size * 0.04f, Math.PI / 2 - Math.PI+ angleOfRotation);
            Drawing.Change(size * 0.04f * Math.Sqrt(2), Math.PI / 2 + 3 * Math.PI / 4 + angleOfRotation);
        }

        private static void DrawSide3(int size, double angleOfRotation)
        {
            //Рисуем 3-ю сторону
            Drawing.MakeIt(Pens.Yellow, size * 0.375f, Math.PI+ angleOfRotation);
            Drawing.MakeIt(Pens.Yellow, size * 0.04f * Math.Sqrt(2), Math.PI + Math.PI / 4 + angleOfRotation);
            Drawing.MakeIt(Pens.Yellow, size * 0.375f, Math.PI + Math.PI+ angleOfRotation);
            Drawing.MakeIt(Pens.Yellow, size * 0.375f - size * 0.04f, Math.PI + Math.PI / 2 + angleOfRotation);

            Drawing.Change(size * 0.04f, Math.PI - Math.PI+ angleOfRotation);
            Drawing.Change(size * 0.04f * Math.Sqrt(2), Math.PI + 3 * Math.PI / 4+ angleOfRotation);
        }

        private static void DrawSide2(int size, double angleOfRotation)
        {
            //Рисуем 2-ую сторону
            Drawing.MakeIt(Pens.Yellow, size * 0.375f, -Math.PI / 2 + angleOfRotation);
            Drawing.MakeIt(Pens.Yellow, size * 0.04f * Math.Sqrt(2), -Math.PI / 2 + Math.PI / 4 + angleOfRotation);
            Drawing.MakeIt(Pens.Yellow, size * 0.375f, -Math.PI / 2 + Math.PI + angleOfRotation);
            Drawing.MakeIt(Pens.Yellow, size * 0.375f - size * 0.04f, -Math.PI / 2 + Math.PI / 2 + angleOfRotation);

            Drawing.Change(size * 0.04f, -Math.PI / 2 - Math.PI + angleOfRotation);
            Drawing.Change(size * 0.04f * Math.Sqrt(2), -Math.PI / 2 + 3 * Math.PI / 4 + angleOfRotation);
        }

        private static void DrawSide1(int size, double angleOfRotation)
        {
            //Рисуем 1-ую сторону

            Drawing.MakeIt(Pens.Yellow, size * 0.375f, angleOfRotation);
            Drawing.MakeIt(Pens.Yellow, size * 0.04f * Math.Sqrt(2), Math.PI / 4 + angleOfRotation);
            Drawing.MakeIt(Pens.Yellow, size * 0.375f, Math.PI + angleOfRotation);
            Drawing.MakeIt(Pens.Yellow, size * 0.375f - size * 0.04f, Math.PI / 2 + angleOfRotation);

            Drawing.Change(size * 0.04f, -Math.PI + angleOfRotation);
            Drawing.Change(size * 0.04f * Math.Sqrt(2), 3 * Math.PI / 4 + angleOfRotation);
        }
    }
}