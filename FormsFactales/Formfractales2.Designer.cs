namespace FormsFactales
{
    partial class Formfractales2
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
            ptb1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptb1).BeginInit();
            SuspendLayout();
            // 
            // ptb1
            // 
            ptb1.Location = new Point(9, 6);
            ptb1.Name = "ptb1";
            ptb1.Size = new Size(550, 550);
            ptb1.TabIndex = 0;
            ptb1.TabStop = false;
            ptb1.Click += ptb1_Click_1;
            // 
            // Formfractales2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 568);
            Controls.Add(ptb1);
            Name = "Formfractales2";
            Text = "Formfractales2";
            Click += ptb1_Click;
            ((System.ComponentModel.ISupportInitialize)ptb1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptb1;
    }
}