namespace FormsFactales
{
    public partial class Formfractales4 : Form
    {
        public Formfractales4()
        {
            InitializeComponent();
            TrianguloSierpinski();
        }

        private void TrianguloSierpinski()
        {
            int ancho = ptb4.Width;
            int alto = ptb4.Height;
            Bitmap imagen = new Bitmap(ancho, alto);

            using (Graphics g = Graphics.FromImage(imagen))
            {
                g.Clear(Color.White);
                float  x = 75;
                float y = 75;
                float tamaño = 400;
                int nivel = 5;

                void DibujarTriangulo(float x, float y, float tamaño, int nivel)
                {
                    if (nivel == 0)
                    {
                        PointF p1 = new PointF(x, y);
                        PointF p2 = new PointF(x + tamaño, y);
                        PointF p3 = new PointF(x + tamaño / 2, y + (float)(Math.Sqrt(3) * tamaño / 2));
                        int iteraciones = nivel * 100;
                        Color color = iteraciones < 1000 ?
                            Color.FromArgb(iteraciones % 128, iteraciones % 50 * 5, iteraciones % 10) :
                            Color.Black;
                        Brush brush = new SolidBrush(color);
                        g.FillPolygon(brush, new PointF[] { p1, p2, p3 });
                    }
                    else
                    {
                        float nuevoTamaño = tamaño / 2;
                        Color color = Color.FromArgb(255, nivel * 50 % 255, (nivel * 100) % 255, (nivel * 150) % 255);
                        Brush brush = new SolidBrush(color);

                        PointF p1 = new PointF(x, y);
                        PointF p2 = new PointF(x + tamaño, y);
                        PointF p3 = new PointF(x + tamaño / 2, y + (float)(Math.Sqrt(3) * tamaño / 2));
                        g.FillPolygon(brush, new PointF[] { p1, p2, p3 });

                        DibujarTriangulo(x, y, nuevoTamaño, nivel - 1);
                        DibujarTriangulo(x + nuevoTamaño, y, nuevoTamaño, nivel - 1);
                        DibujarTriangulo(x + nuevoTamaño / 2, y + (float)(Math.Sqrt(3) * nuevoTamaño / 2), nuevoTamaño, nivel - 1);
                    }
                }

                DibujarTriangulo(x, y, tamaño, nivel);
            }

            ptb4.Image = imagen;
        }
    }
}
