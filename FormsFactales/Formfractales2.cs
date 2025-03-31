using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormsFactales
{
    public partial class Formfractales2 : Form
    {
        public Formfractales2()
        {
            InitializeComponent();
            FractalRaiz();

        }

        private void FractalRaiz()
        {
            if (ptb1 == null || ptb1.Width == 0 || ptb1.Height == 0) return;

            int ancho = ptb1.Width;
            int altura = ptb1.Height;
            Bitmap bmp = new Bitmap(ancho, altura);

            double xMin = -2.0, xMax = 2.0, yMin = -2.0, yMax = 2.0;

            for (int fila = 0; fila < altura; fila++)
            {
                for (int columna = 0; columna < ancho; columna++)
                {
                    double c_re = xMin + columna * (xMax - xMin) / ancho;
                    double c_im = yMin + fila * (yMax - yMin) / altura;

                    double zx = c_re, zy = c_im;
                    int iteraciones = 0;
                    double tolerancia = .001;

                    while (iteraciones < 100)
                    {
                        double zx2 = zx * zx, zy2 = zy * zy;
                        double zx4 = zx2 * zx2, zy4 = zy2 * zy2;
                        double f_re = (zx * (zx4 - 10 * zx2 * zy2 + 5 * zy4)) - 1;
                        double f_im = zy * (5 * zx4 - 10 * zx2 * zy2 + zy4);

                        double df_re = 5 * (zx4 - 6 * zx2 * zy2 + zy4);
                        double df_im = 5 * (4 * zx * zy * (zx2 - zy2));

                        double denom = df_re * df_re + df_im * df_im;
                        if (denom < tolerancia) break;

                        double zx_nuevo = zx - (f_re * df_re + f_im * df_im) / denom;
                        double zy_nuevo = zy - (f_im * df_re - f_re * df_im) / denom;

                        if (Math.Abs(zx_nuevo - zx) < tolerancia && Math.Abs(zy_nuevo - zy) < tolerancia)
                            break;

                        zx = zx_nuevo;
                        zy = zy_nuevo;
                        iteraciones++;
                    }

                    if (iteraciones < 1000)
                    {
                        bmp.SetPixel(columna, fila, Color.FromArgb(iteraciones % 256, iteraciones * 1 % 256,iteraciones * 9 % 256));
                    }
                    else
                    {
                        bmp.SetPixel(columna, fila, Color.Black); 
                    }
                }
            }

            ptb1.Image = bmp;
        }
      

        private void ptb1_Click(object sender, EventArgs e)
        {
        }

        private void ptb1_Click_1(object sender, EventArgs e)
        {
        }
    }
}
