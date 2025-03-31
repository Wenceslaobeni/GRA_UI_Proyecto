using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormsFactales
{
    public partial class Formfracales3 : Form
    {
        private int iteraciones = 0;

        public Formfracales3()
        {
            InitializeComponent();
            GenerarCopoDeNieve();
        }

        private void GenerarCopoDeNieve()
        {
            int ancho = ptb3.Width;
            int alto = ptb3.Height;
            Bitmap bmp = new Bitmap(ancho, alto);
            for (int x = 0; x < ancho; x++)
            {
                for (int y = 0; y < alto; y++)
                {
                    bmp.SetPixel(x, y, Color.Black);
                }
            }

            PointF punto1 = new PointF(ancho / 4, alto / 2);
            PointF punto2 = new PointF(3 * ancho / 4, alto / 2);
            PointF medio = new PointF((punto1.X + punto2.X) / 2,
                punto1.Y - (float)((Math.Sqrt(3) / 2)) * (punto2.X - punto1.X));

            int profundidad = 4;

            void GenerarKoch(PointF p1, PointF p2, int prof)
            {
                if (prof == 0)
                {
                    DibujarLinea(p1, p2);
                    iteraciones++;
                    return;
                }

                PointF a = new PointF((2 * p1.X + p2.X) / 3, (2 * p1.Y + p2.Y) / 3);
                PointF b = new PointF((p1.X + 2 * p2.X) / 3, (p1.Y + 2 * p2.Y) / 3);

                double angulo = Math.PI / 3;
                PointF c = new PointF(
                    (float)(a.X + (b.X - a.X) * Math.Cos(angulo) - (b.Y - a.Y) * Math.Sin(angulo)),
                    (float)(a.Y + (b.X - a.X) * Math.Sin(angulo) + (b.Y - a.Y) * Math.Cos(angulo))
                );

                GenerarKoch(p1, a, prof - 1);
                GenerarKoch(a, c, prof - 1);
                GenerarKoch(c, b, prof - 1);
                GenerarKoch(b, p2, prof - 1);
            }

            void DibujarLinea(PointF p1, PointF p2)
            {
                int x0 = (int)p1.X, y0 = (int)p1.Y;
                int x1 = (int)p2.X, y1 = (int)p2.Y;
                int dx = Math.Abs(x1 - x0), sx = x0 < x1 ? 1 : -1;
                int dy = -Math.Abs(y1 - y0), sy = y0 < y1 ? 1 : -1;
                int err = dx + dy, e2;

                Color color = Color.FromArgb(
                    (iteraciones * 5) % 256,
                    (iteraciones * 3) % 256,
                    (iteraciones * 7) % 256
                );

                while (true)
                {
                    if (x0 >= 0 && x0 < bmp.Width && y0 >= 0 && y0 < bmp.Height)
                        bmp.SetPixel(x0, y0, color);
                    if (x0 == x1 && y0 == y1) break;
                    e2 = 2 * err;
                    if (e2 >= dy) { err += dy; x0 += sx; }
                    if (e2 <= dx) { err += dx; y0 += sy; }
                }
            }

            GenerarKoch(punto1, punto2, profundidad);
            GenerarKoch(punto2, medio, profundidad);
            GenerarKoch(medio, punto1, profundidad);

            ptb3.Image = bmp;
        }
        private void pbt3_Click(object sender, EventArgs e)
        {
        }
    }
}