﻿namespace FormGraphics
{
    partial class FrmLineasEscalar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ptbDubujo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptbDubujo).BeginInit();
            SuspendLayout();
            // 
            // ptbDubujo
            // 
            ptbDubujo.Dock = DockStyle.Fill;
            ptbDubujo.Location = new Point(0, 0);
            ptbDubujo.Name = "ptbDubujo";
            ptbDubujo.Size = new Size(800, 450);
            ptbDubujo.TabIndex = 1;
            ptbDubujo.TabStop = false;
            ptbDubujo.Click += ptbDubujo_Click;
            ptbDubujo.Paint += ptbDubujo_Paint;
            // 
            // FrmLineasEscalar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ptbDubujo);
            Name = "FrmLineasEscalar";
            Text = "FrmLineasEscalar";
            Load += FrmLineasEscalar_Load;
            KeyDown += FrmLineasEscalar_KeyDown;
            ((System.ComponentModel.ISupportInitialize)ptbDubujo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptbDubujo;
    }
}