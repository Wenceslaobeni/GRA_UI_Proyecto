﻿namespace FormsMenu
{
    partial class FrmMenuPrincipal
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(0, 23);
            button1.Name = "button1";
            button1.Size = new Size(188, 29);
            button1.TabIndex = 0;
            button1.Text = "Menu_1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(0, 58);
            button2.Name = "button2";
            button2.Size = new Size(188, 29);
            button2.TabIndex = 1;
            button2.Text = "Menu_2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(0, 93);
            button3.Name = "button3";
            button3.Size = new Size(188, 29);
            button3.TabIndex = 2;
            button3.Text = "Menu_Fractales";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(0, 137);
            button4.Name = "button4";
            button4.Size = new Size(188, 29);
            button4.TabIndex = 3;
            button4.Text = "Graficación_2D";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(5, 170);
            button5.Name = "button5";
            button5.Size = new Size(183, 29);
            button5.TabIndex = 4;
            button5.Text = "Graficación_2D";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(5, 217);
            button6.Name = "button6";
            button6.Size = new Size(183, 29);
            button6.TabIndex = 5;
            button6.Text = "Graficación_3D";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(5, 263);
            button7.Name = "button7";
            button7.Size = new Size(183, 29);
            button7.TabIndex = 6;
            button7.Text = "Tiro parabólíco 3D Unity";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(5, 315);
            button8.Name = "button8";
            button8.Size = new Size(183, 29);
            button8.TabIndex = 7;
            button8.Text = "Graficos";
            button8.UseVisualStyleBackColor = true;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMenuPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}