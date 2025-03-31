namespace FormGraphics
{
    public partial class FrmLineas : Form
    {
        public FrmLineas()
        {
            InitializeComponent();
        }
        Graphics graphics;
        private void FormLineas_Load(object sender, EventArgs e)
        {

        }

        private void ptbDibujo_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            Pen pen = new Pen(Color.Blue, 3);
            graphics.DrawLine(pen, new Point(50, 50), new Point(100, 50));
            graphics.DrawLine(pen, new Point(100, 50), new Point(100, 100));
            graphics.DrawLine(pen, new Point(100, 100), new Point(50, 100));
            graphics.DrawLine(pen, new Point(50, 100), new Point(50, 50));
        }

        private void ptbDubujo_Click(object sender, EventArgs e)
        {

        }
    }
}
