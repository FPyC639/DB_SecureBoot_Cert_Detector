﻿namespace WindowsMicrosoftHashingDB
{
    partial class Form1
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
            button1 = new Button();
            PCA2011 = new Label();
            CA20101 = new Label();
            detailsTextBox = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(244, 146);
            button1.Name = "button1";
            button1.Size = new Size(308, 29);
            button1.TabIndex = 0;
            button1.Text = "Press to Upload File for DB file checking";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PCA2011
            // 
            PCA2011.AutoSize = true;
            PCA2011.Location = new Point(347, 201);
            PCA2011.Name = "PCA2011";
            PCA2011.Size = new Size(54, 20);
            PCA2011.TabIndex = 1;
            PCA2011.Text = "Temp1";
            // 
            // CA20101
            // 
            CA20101.AutoSize = true;
            CA20101.Location = new Point(347, 221);
            CA20101.Name = "CA20101";
            CA20101.Size = new Size(54, 20);
            CA20101.TabIndex = 2;
            CA20101.Text = "Temp2";
            // 
            // detailsTextBox
            // 
            detailsTextBox.AutoSize = true;
            detailsTextBox.Location = new Point(365, 242);
            detailsTextBox.Name = "detailsTextBox";
            detailsTextBox.Size = new Size(50, 20);
            detailsTextBox.TabIndex = 3;
            detailsTextBox.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(detailsTextBox);
            Controls.Add(CA20101);
            Controls.Add(PCA2011);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label PCA2011;
        private Label CA20101;
        private Label detailsTextBox;
    }
}