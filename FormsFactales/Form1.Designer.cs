namespace FormsFactales
{
    partial class FrmFractal01
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1Mandelbrot = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1Mandelbrot).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1Mandelbrot
            // 
            pictureBox1Mandelbrot.Location = new Point(12, 6);
            pictureBox1Mandelbrot.Name = "pictureBox1Mandelbrot";
            pictureBox1Mandelbrot.Size = new Size(550, 550);
            pictureBox1Mandelbrot.TabIndex = 0;
            pictureBox1Mandelbrot.TabStop = false;
            pictureBox1Mandelbrot.Click += pictureBox1Mandelbrot_Click;
            // 
            // FrmFractal01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 568);
            Controls.Add(pictureBox1Mandelbrot);
            Name = "FrmFractal01";
            Text = "FractalMandelbrot";
            Load += FrmFractal01_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1Mandelbrot).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1Mandelbrot;
    }
}
