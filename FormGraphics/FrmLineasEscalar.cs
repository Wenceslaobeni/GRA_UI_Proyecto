using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormGraphics
{
    public partial class FrmLineasEscalar : Form
    {
        public FrmLineasEscalar()
        {
            InitializeComponent();
        }
        Graphics graphics;
        int ex = 1, ey = 1;
        private void ptbDubujo_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            Pen pen = new Pen(Color.Blue, 3);
            Rectangle rectangle = new Rectangle(50, 50, 50 + ex, 50 + ey);
            graphics.DrawRectangle(pen, rectangle);
        }

        private void FrmLineasEscalar_Load(object sender, EventArgs e)
        {

        }

        private void FrmLineasEscalar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    //incremento
                    ex++;
                    ey++;
                    ptbDubujo.Refresh();
                    break;
                case Keys.Down:
                    //DEcremento
                    if (ex > 1)
                    {
                        ex--;
                        ey--;
                        ptbDubujo.Refresh();

                    }
                    break;



            }
        }

        private void ptbDubujo_Click(object sender, EventArgs e)
        {

        }
    }
}
